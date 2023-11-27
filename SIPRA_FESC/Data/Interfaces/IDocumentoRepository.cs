using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Dtos;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Data.Interfaces
{
    public interface IDocumentoRepository
    {
        bool Crear(Formulario formulario);
        Formulario GetById(string idformulario);
        bool UpdateFormularioCargado(FormulariosCargado formulario);
        bool CrearFormularioCargado(FormulariosCargado formulario);
        Formulario GetFormularioByName(string NombreFormulario);
        List<Formulario> GetFormulariosAll();
        bool Delete(string idFormulario);
        List<FormulariosCargado> GetFormularioCargadoByIdUsuario(int idUsuario);

        FormulariosCargado GetFormularioCargadoByIdUsuarioAndIdFormulario(string idFormulario, int usuarioId);
    }
}
