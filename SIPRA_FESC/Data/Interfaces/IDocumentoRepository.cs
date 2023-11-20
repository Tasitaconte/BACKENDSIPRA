using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Data.Interfaces
{
    public interface IDocumentoRepository
    {
        bool Crear(Formulario formulario);
        Formulario GetById(string idformulario);
        bool UpdateFormularioCargado(FormulariosCargado formulario);
        bool CrearFormularioCargado(FormulariosCargado formulario);
        FormulariosCargado GetFormularioCargadoByIdUsuarioAndIdFormulario(string idFormulario, int usuarioId);
    }
}
