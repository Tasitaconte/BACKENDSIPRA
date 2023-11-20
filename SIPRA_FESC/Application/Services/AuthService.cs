using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using SIPRA_FESC.Application.Contracts;
using SIPRA_FESC.Application.ViewModels.Request.LoginModel;
using SIPRA_FESC.Application.ViewModels.Responses;
using SIPRA_FESC.Data.Interfaces;
using SIPRA_FESC.Data.Models;
using System.IdentityModel.Tokens.Jwt;
using System.Net;
using System.Security.Claims;
using System.Text;

namespace SIPRA_FESC.Application.Services;

public class AuthService : IAuthService
{
    protected IMapper _mapper;
    protected IUsuarioRepository _usuarioRepository;
    protected IConfiguration _config;
    public AuthService(IMapper mapper, IUsuarioRepository usuarioRepository, IConfiguration config)
    {
        _mapper = mapper;
        _usuarioRepository = usuarioRepository;
        _config = config;
    }
    public ResponseModel<bool> Login(LoginUsuarioRequestModel login)
    {
        var response = new ResponseModel<bool>(HttpStatusCode.BadRequest);

        var usuario = _usuarioRepository.GetUsuarioByEmail(login.Email);


        if (usuario == null)
        {
            throw new Exception("Correo no encontrado");
        };


        if (BC.Verify(login.Password, usuario.Password))
        {

            var jwt = _config.GetSection("Jwt").Get<Jwt>();

            var nombre = $"{usuario.Nombres} {usuario.Apellidos}";

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, jwt.Subject),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                new Claim("id",value: usuario.IdUsuario),
                new Claim("rol",value: usuario.IdRol.ToString()),
                new Claim("nombre",value: nombre)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.Key));
            var sigIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                jwt.Issuer,
                jwt.Audience,
                claims,
                expires: DateTime.Now.AddMinutes(60 * 5),
                signingCredentials: sigIn
                );

            response.SetCode(HttpStatusCode.OK);
            response.SetData(true);
            response.AddMessage(new JwtSecurityTokenHandler().WriteToken(token));
            return response;
        };

        throw new Exception("Crendenciales Incorrectas");
    }
}
