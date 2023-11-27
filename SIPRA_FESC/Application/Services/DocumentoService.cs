using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Data.Repositories;
using SIPRA_FESC.Dtos;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Application.Services
{
    public class DocumentoService : IDocumentoService
    {
        
        private readonly IDocumentoRepository _documentoRepository;

        public DocumentoService(IDocumentoRepository documentoRepository) {
            _documentoRepository = documentoRepository;
        }


        public FormularioDto GetFormulariosAll()
        {
            return new FormularioDto();
          //  return _documentoRepository.GetFormulariosAll();
        }
        public bool AgregarFormulario(Formulario formulario)
        {

            var formulario_entidad = _documentoRepository.GetFormularioByName(formulario.Formulario1);

            if (formulario_entidad != null)
            {
                return false;
            }

            formulario.IdFormulario = Guid.NewGuid().ToString();
            return _documentoRepository.Crear(formulario);
        }
        public bool SubirFormularioEstudiante(FormulariosCargado formulario)
        {
           formulario.IdFormularioCargado = Guid.NewGuid().ToString();
           return _documentoRepository.CrearFormularioCargado(formulario);
        }

        public List<object> obtenerFormularioCargado(string id)
        {
            throw new NotImplementedException();
        }
    }
}
