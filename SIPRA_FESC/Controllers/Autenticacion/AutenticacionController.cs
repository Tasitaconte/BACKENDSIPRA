using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Application.ViewModels.Request.LoginModel;
using SIPRA_FESC.Application.ViewModels.Responses;

namespace SIPRA_FESC.Controllers.Autenticacion;

[Route("/login")]
[ApiController]
public class AutenticacionController : ControllerBase
{
    private readonly IAuthService _authService;

    public AutenticacionController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost]
    public ResponseModel<bool> Login([FromBody] LoginUsuarioRequestModel credenciales)
    {
        return _authService.Login(credenciales);
    }

}
