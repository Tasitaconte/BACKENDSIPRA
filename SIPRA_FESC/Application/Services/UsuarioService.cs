using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Application.ViewModels.Responses;
using SIPRA_FESC.Application.ViewModels.Request.UsuarioModels;
using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Dtos;
using SIPRA_FESC.Entities;
using System.Net;

namespace SIPRA_FESC.Application.Services;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IMapper _mapper;

    public UsuarioService(IUsuarioRepository usuarioRepository, IMapper mapper)
    {
        _usuarioRepository = usuarioRepository;
        _mapper = mapper;
        //  _mapper = mapper;
    }
    public bool ActualizarUsuario(string usuario)
    {
        throw new NotImplementedException();
    }

    public bool CrearUsuario()
    {
        throw new NotImplementedException();
    }

    public ResponseModel<bool> CrearExtension(UsuarioRequestCrearModel usuarioRequestCrearModel)
    {
        return CreateUser(usuarioRequestCrearModel, 1);
    }

    public ResponseModel<bool> CrearDocente(UsuarioRequestCrearModel usuarioRequestCrearModel)
    {
        return CreateUser(usuarioRequestCrearModel, 2);
    }

    public ResponseModel<bool> CrearEstudiante(UsuarioRequestCrearModel usuarioRequestCrearModel)
    {
        return CreateUser(usuarioRequestCrearModel, 3);
    }

    public bool EliminarUsuario(string usuario)
    {
        throw new NotImplementedException();
    }

    public Task<ActionResult<IEnumerable<UsuarioDto>>> GetAll()
    {
        return _usuarioRepository.GetAllUsuarios();
    }

    public string ObtenerUsuario(string usuario)
    {
        throw new NotImplementedException();
    }

    private ResponseModel<bool> CreateUser(UsuarioRequestCrearModel usuario, int idRol)
    {
        ResponseModel<bool> response = new(HttpStatusCode.OK);

        var emailUsed = _usuarioRepository.GetUsuarioByEmail(usuario.Email);

        if (emailUsed != null)
        {
            response = new ResponseModel<bool>(HttpStatusCode.InternalServerError);
            response.SetData(false);
            response.AddMessage("correo ya usado");
            return response;
        }

        var usuarioNuevo = _mapper.Map<Usuario>(usuario);

        usuarioNuevo.IdUsuario = Guid.NewGuid().ToString();
        usuarioNuevo.Password = BC.HashPassword(usuario.Password);
        usuarioNuevo.IdCarrera = usuario.IdCarrera;
        usuarioNuevo.IdRol = idRol;

        var wasCreated = _usuarioRepository.Create(usuarioNuevo);

        response.SetData(wasCreated);
        return response;
    }
}


