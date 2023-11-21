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

            utilFunction.CrearDirectorioSiNoExiste(savePath);
            utilFunction.GuardarArchivo(archivo, rutaArchivoGuardar);

            Formulario formulario = new()
            {
                Formulario1 = nombreFormulario,
                Url = rutaArchivoGuardar
            };

            var result = _documentoService.AgregarFormulario(formulario);
            return Ok(new { message = result, RutaArchivo = rutaArchivoGuardar });
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
    }

    [HttpGet("/descargar/formulario/pdf/{idFormulario}")]
    public IActionResult DescargarFormularioPdf(string idFormulario)
    {
        try
        {

            var formulario = _documentoRepository.GetById(idFormulario);

            if (formulario == null || formulario.Formulario1 == null)
            {
                return NotFound("El archivo no existe.");
            }

            string rutaArchivo = formulario.Url;
            if (!System.IO.File.Exists(rutaArchivo))
            {
                return NotFound("El archivo no existe.");
            }


            byte[] archivoBytes = System.IO.File.ReadAllBytes(rutaArchivo);

            return File(archivoBytes, "application/pdf", formulario.Formulario1);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Error interno del servidor: {ex.Message}");
        }
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
