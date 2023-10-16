using SIPRA_FESC.Application.ViewModels.Request.LoginModel;
using SIPRA_FESC.Application.ViewModels.Responses;

namespace SIPRA_FESC.Application.Contracts;

public interface IAuthService
{
    ResponseModel<bool> Login(LoginUsuarioRequestModel login);
}
