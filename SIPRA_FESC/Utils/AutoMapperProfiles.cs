using AutoMapper;
using SIPRA_FESC.Application.ViewModels.Request.UsuarioModels;
using SIPRA_FESC.Dtos;
using SIPRA_FESC.Entities;

namespace SIPRA_FESC.Utils
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Usuario, UsuarioDto>();
            
            CreateMap<TipoIdentificacion, TipoIdentificacionDto>();
            
            CreateMap<Carrera, CarreraDto>();
            
            CreateMap<Empresa, EmpresaDto>();
            
            CreateMap<Rol,RolDto>();
            
            CreateMap<UsuarioRequestCrearModel, Usuario>();
            
            CreateMap<UsuarioRequestCrearModel, UsuarioDto>();

            CreateMap<Usuario, UsuarioRequestCrearModel>();
            
            CreateMap<UsuarioDto, UsuarioRequestCrearModel>();

            CreateMap<FormulariosCargado, FormularioCargadoDto>();

            CreateMap<FormularioCargadoDto, FormulariosCargado>();
        }
    }
}
