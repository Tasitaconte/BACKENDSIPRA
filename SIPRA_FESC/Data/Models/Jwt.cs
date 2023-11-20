using System.Security.Claims;

namespace SIPRA_FESC.Data.Models;

public class Jwt
{
    public string Key { get; set; }

    public string Issuer { get; set; }

    public string Audience { get; set; }

    public string Subject { get; set; }
    public static dynamic ValidarToken(ClaimsIdentity identity)
    {
        try
        {
            if (identity.Claims.Count()==0)
            {
                return new
                {
                    success = false,
                    message = "Token invalido",
                    result = ""
                };
            }
            var Id = identity.Claims.FirstOrDefault(x => x.Type == "id").Value;
            var Rol = identity.Claims.FirstOrDefault(x => x.Type == "rol").Value;

            return new { 
                Id,
                Rol,
            };

        }
        catch (Exception ex)
        {
            return new
            {
                success = false,
                message = ex.Message,
                result = ""
            };
        }

     }
}