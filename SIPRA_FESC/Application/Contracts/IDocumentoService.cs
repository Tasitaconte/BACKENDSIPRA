using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Application.Contracts
{
    public interface IDocumentoService
    {
        bool GuardarDocumentos();
        string ObtenerDocumentos();
        string GenerarPDF();
        string SubirNotaEstudiantes();
        bool SubirFormularioEstudiante(FormulariosCargado formulario);


        bool AgregarFormulario(Formulario formulario);

    }
}
