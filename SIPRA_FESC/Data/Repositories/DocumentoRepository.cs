using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Dtos;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Data.Repositories
{
    public class DocumentoRepository : IDocumentoRepository
    {

        private readonly SipraContext _context;
        protected IMapper _mapper;
        public DocumentoRepository(SipraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool Crear(Formulario formulario)
        {
            _context.Formularios.Add(formulario);
            return (_context.SaveChanges() > 0);
        } 
        
        public bool CrearFormularioCargado(FormulariosCargado formulario)
        {
            _context.FormulariosCargados.Add(formulario);
            return (_context.SaveChanges() > 0);
        } 
        
        public bool UpdateFormularioCargado(FormulariosCargado formulario)
        {
            _context.Entry(formulario).State = EntityState.Modified;
            return (_context.SaveChanges() > 0);
        }

        public FormulariosCargado GetFormularioCargadoByIdUsuarioAndIdFormulario(string idFormulario, int idUsuario)
        {
            return _context.FormulariosCargados.Where(x => x.IdUsuario == idUsuario && x.IdFormulario == idFormulario).FirstOrDefault();
        }

        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetFormularioByIdUsuario(int usuarioId)
        {
            return await _context.FormulariosCargados.Where(x => x.IdUsuario == usuarioId)
            .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
            .ToListAsync(); 
        }
        public Formulario GetById(string idFormulario)
        {
            return _context.Formularios.FirstOrDefault(x => x.IdFormulario == idFormulario);
        }

      
     
    }
}
