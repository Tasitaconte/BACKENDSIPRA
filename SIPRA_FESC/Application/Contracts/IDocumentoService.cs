using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Dtos;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Application.Contracts
{
    public interface IDocumentoService
    {
        bool SubirFormularioEstudiante(FormulariosCargado formulario);
        FormularioDto GetFormulariosAll();

        bool AgregarFormulario(Formulario formulario);

        List<object> obtenerFormularioCargado(string id);

    }
}
