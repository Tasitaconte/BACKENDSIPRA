using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Application.ViewModels.Request.DocumentosModel;
using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Data.Models;
using SIPRA_FESC.Entities;
using SIPRA_FESC.Utils;
using System.Security.Claims;

namespace SIPRA_FESC.Controllers.Documentos;

[Route("[controller]")]
[ApiController]
public class DocumentosController : ControllerBase
{
    private readonly IDocumentoService _documentoService;
    private readonly IDocumentoRepository _documentoRepository;
    private readonly IUsuarioRepository _usuarioRepository;
    public DocumentosController(IDocumentoService documentoService, IDocumentoRepository documentoRepository, IUsuarioRepository usuarioRepository)
    {
        _documentoService = documentoService;
        _documentoRepository = documentoRepository;
        _usuarioRepository = usuarioRepository;
    }

    [HttpPost("/agregar/formulario/pdf")]
    public IActionResult AgregarFormularioPdf([FromForm] DocumentoRequestModel documentoRequestModel)
    {
        const string savePath = "C:/documentos/formularios/guardados";
        var archivo = documentoRequestModel.Archivo;
        string nombreFormulario = documentoRequestModel.Formulario;
        UtilFunction utilFunction = new();

        try
        {
            if (!utilFunction.EsTipoPDF(archivo))
            {
                return BadRequest("Solo se permiten archivos PDF.");
            }

            string nombreArchivoUnico = utilFunction.GenerarNombreUnico(nombreFormulario);
            string rutaArchivoGuardar = utilFunction.ConstruirRutaArchivo(savePath, nombreArchivoUnico);
           
            Formulario formulario = new()
            {
                Formulario1 = nombreFormulario,
                Url = rutaArchivoGuardar
            };
               
            var result = _documentoService.AgregarFormulario(formulario);

            if (result){
                utilFunction.CrearDirectorioSiNoExiste(savePath);
                utilFunction.GuardarArchivo(archivo, rutaArchivoGuardar);
            }

            return Ok(new { message = result, RutaArchivo = rutaArchivoGuardar });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }

    [HttpGet("/formulario/all")]
    public IActionResult GetFormulariosAll()
    {
        UtilFunction utilFunction = new UtilFunction(); 
        var formulario =  _documentoRepository.GetFormulariosAll();

        var formularioDto = formulario.Select(formulario => new
        {
            formulario.Id,
            formulario.IdFormulario,
            formulario.Formulario1,
            PdfContent = Convert.ToBase64String(System.IO.File.ReadAllBytes(formulario.Url)),
        });

        return Ok(formularioDto);
    }

    [HttpGet("/formulario/all/estudiante")]
    public IActionResult GetFormulariosAllEstudiante()
    {
        UtilFunction utilFunction = new UtilFunction();

        var identity = HttpContext.User.Identity as ClaimsIdentity;
        var idUsuario = Jwt.ValidarToken(identity);
        
        var result = _documentoService.obtenerFormularioCargado(idUsuario.Id);

        var formulario = _documentoRepository.GetFormulariosAll();
        var usuarioEntidad = _usuarioRepository.GetUsuarioByIdUsuario(idUsuario.Id);


        if (usuarioEntidad == null)
        {
            throw new Exception("Usuario no existe");
        }

        if (usuarioEntidad.IdRol != 3)
        {
            throw new Exception("No es estudiante");
        }

        var formularioCargado = _documentoRepository.GetFormularioCargadoByIdUsuario(usuarioEntidad.Id);

        if (formularioCargado == null)
        {
            var formularioDto = formulario.Select(formulario => new
            {
                formulario.Id,
                formulario.IdFormulario,
                formulario.Formulario1,
                cargado = false,
                PdfContent = Convert.ToBase64String(System.IO.File.ReadAllBytes(formulario.Url)),
            });


        }

        return Ok(formularioCargado);

        /*
        ;*/
    }

    [HttpDelete("/eliminar/formulario/pdf/{idFormulario}")]
    public IActionResult EliminarFormularioPdf(string idFormulario)
    {
       bool result= _documentoRepository.Delete(idFormulario);
        return Ok(result);
    }

    [Authorize]
    [HttpPost("/subir/estudiante/formulario/pdf/{IdFormulario}")]
    public IActionResult SubirFormularioPdfByEstudiante([FromForm] DocumentRequestSubirEstudiante documentRequestSubirEstudiante,string IdFormulario)
    {
        var identity = HttpContext.User.Identity as ClaimsIdentity;
        var idUsuario = Jwt.ValidarToken(identity);

        var archivo = documentRequestSubirEstudiante.Archivo;

        var usuarioEntidad = _usuarioRepository.GetUsuarioByIdUsuario(idUsuario.Id);

        if (usuarioEntidad == null)
        {
            return BadRequest(new {message = "No existe usuario"});
        }

        if (usuarioEntidad.Id != 2)
        {
            return BadRequest(new {message = "No es estudiante"});
        }

        var formularioCargadoEntidad = _documentoRepository.GetFormularioCargadoByIdUsuarioAndIdFormulario(IdFormulario, usuarioEntidad.Id);


        if (formularioCargadoEntidad != null)
        {
            return Ok(new { message = "Usted ya subió este formulario" });
        }


        string identificador = $"{usuarioEntidad.NumeroIdentificacion}_{usuarioEntidad.Nombres}{usuarioEntidad.Apellidos}";
        string savePath = $"C:/documentos/formularios/estudiante/{identificador}/";

        var formularioEntidad = _documentoRepository.GetById(IdFormulario);
        string nombreFormulario = $"{formularioEntidad.Formulario1}_{identificador}";

        UtilFunction utilFunction = new();

        if (!utilFunction.EsTipoPDF(archivo))
        {
            return BadRequest("Solo se permiten archivos PDF.");
        }

        string nombreArchivoUnico = utilFunction.GenerarNombreUnico(nombreFormulario);
        string rutaArchivoGuardar = utilFunction.ConstruirRutaArchivo(savePath, nombreArchivoUnico);

        utilFunction.CrearDirectorioSiNoExiste(savePath);
        utilFunction.GuardarArchivo(archivo, rutaArchivoGuardar);

        FormulariosCargado formularioCargado = new()
        {
            Url = rutaArchivoGuardar,
            IdUsuario = usuarioEntidad.Id,
            IdFormulario = IdFormulario,
        };

        var result = _documentoService.SubirFormularioEstudiante(formularioCargado);
        return Ok(new { message = result, RutaArchivo = rutaArchivoGuardar });
    }
}
