using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Application.Services
{
    public class DocumentoService : IDocumentoService
    {
        
        private readonly IDocumentoRepository _documentoRepository;

        public DocumentoService(IDocumentoRepository documentoRepository) {
            _documentoRepository = documentoRepository;
        }
            

        public bool AgregarFormulario(Formulario formulario)
        {
           formulario.IdFormulario = Guid.NewGuid().ToString();
           return _documentoRepository.Crear(formulario);
        } 
        public bool SubirFormularioEstudiante(FormulariosCargado formulario)
        {
           formulario.IdFormularioCargado = Guid.NewGuid().ToString();
           return _documentoRepository.CrearFormularioCargado(formulario);
        }

        public string GenerarPDF()
        {
            throw new NotImplementedException();
        }

        public bool GuardarDocumentos()
        {
            throw new NotImplementedException();
        }

        public string ObtenerDocumentos()
        {
            throw new NotImplementedException();
        }

        public string SubirNotaEstudiantes()
        {
            throw new NotImplementedException();
        }
    }
}
