using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Application.ViewModels.Responses;
using SIPRA_FESC.Application.ViewModels.Request.UsuarioModels;
using SIPRA_FESC.Dtos;

namespace SIPRA_FESC.Application.Contracts;

public interface IUsuarioService
{
    bool CrearUsuario();
    ResponseModel<bool> CrearExtension(UsuarioRequestCrearModel usuario);
    ResponseModel<bool> CrearDocente(UsuarioRequestCrearModel usuario);
    ResponseModel<bool> CrearEstudiante(UsuarioRequestCrearModel usuario);
    string ObtenerUsuario(string usuario);
    bool EliminarUsuario(string usuario);
    Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll();
    Task<ActionResult<IEnumerable<UsuarioDto>>> GetUsuarioByRol(int idRol);

    bool ActualizarUsuario(string usuario);
}
