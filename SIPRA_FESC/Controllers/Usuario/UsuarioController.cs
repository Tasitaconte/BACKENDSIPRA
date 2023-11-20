using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Application.ViewModels.Request.UsuarioModels;
using SIPRA_FESC.Dtos;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SIPRA_FESC.Controllers.Usuario;

[Route("[controller]")]
[ApiController]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioService _services;
    public UsuarioController(IUsuarioService usuarioServices)
    {
        _services = usuarioServices;
    }

    [HttpGet]
    public Task<ActionResult<IEnumerable<UsuarioDto>>> GetUsuarios()
    {
        return _services.GetAll();
    }
    
    [HttpGet("/{idRol}")]
    public Task<ActionResult<IEnumerable<UsuarioDto>>> GetUsuarioByRol(int idRol)
    {
        return _services.GetUsuarioByRol(idRol);
    }

    [HttpPost("/crear/extension")]
    public IActionResult PostUsuarioExtension([FromBody] UsuarioRequestCrearModel usuario)
    {
        var response = _services.CrearExtension(usuario);
        return new ObjectResult(response) { StatusCode = response.Code };
    }

    [HttpPost("/crear/estudiante")]
    public IActionResult PostUsuarioEstudiante([FromBody] UsuarioRequestCrearModel usuario)
    {
        var response = _services.CrearExtension(usuario);
        return new ObjectResult(response) { StatusCode = response.Code };
    }

    [HttpPost("/crear/docente")]
    public IActionResult PostUsuarioDocente([FromBody] UsuarioRequestCrearModel usuario)
    {
        var response = _services.CrearExtension(usuario);
        return new ObjectResult(response) { StatusCode = response.Code };
    }

}
