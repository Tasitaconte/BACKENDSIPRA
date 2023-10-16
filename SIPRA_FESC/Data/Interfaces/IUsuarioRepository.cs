using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Dtos;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Data.Interfaces
{
    public interface IUsuarioRepository
    {
        bool Create(Usuario usuario);
        bool Update(Usuario usuario);
        void Delete(int idUsuario);
        Usuario? GetUsuarioByEmail(String email);
        Usuario? GetUsuarioByNumeroIdentificacion(String numeroIdentificacion);
        Usuario? GetUsuarioByIdUsuario(string idUsuario);
        Usuario? GetUsuarioById(int id);
        Task<ActionResult<IEnumerable<UsuarioDto>>> GetAllUsuarios();
    }
}
