using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Entities;
using Microsoft.EntityFrameworkCore;
using SIPRA_FESC.Dtos;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace SIPRA_FESC.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        protected SipraContext _context;
        protected IMapper _mapper;
        public UsuarioRepository(SipraContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Create(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            return (_context.SaveChanges() > 0);
        }

        public void Delete(int idUsuario)
        {
            var usuario = _context.Usuarios.Find(idUsuario);
            if (usuario == null) return; 
            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
        }

        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetAllUsuarios()
        {
            return await _context.Usuarios.ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider).ToListAsync();   
        }

        public Usuario? GetUsuarioByEmail(string email)
        {
            return _context.Usuarios.FirstOrDefault(x => x.Email == email);
        }

        public Usuario? GetUsuarioById(int id)
        {
            return _context.Usuarios.Find(id);
        }
        
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> GetUsuarioByRol(int idRol)
        {
            return  await _context.Usuarios.Where(x => x.IdRol == idRol)
            .ProjectTo<UsuarioDto>(_mapper.ConfigurationProvider)
            .ToListAsync(); ;
        }

        public Usuario? GetUsuarioByIdUsuario(string idUsuario)
        {
            return _context.Usuarios.FirstOrDefault(x=> x.IdUsuario == idUsuario);
        }

        public Usuario? GetUsuarioByNumeroIdentificacion(string numeroIdentificacion)
        {
            return _context.Usuarios.FirstOrDefault(x=> x.NumeroIdentificacion == numeroIdentificacion);
        }

        public bool Update(Usuario usuario)
        {
            _context.Entry(usuario).State = EntityState.Modified;
            return (_context.SaveChanges()>0);
        }
    }
}
