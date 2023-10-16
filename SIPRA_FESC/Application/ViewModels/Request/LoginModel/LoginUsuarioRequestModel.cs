using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SIPRA_FESC.Application.ViewModels.Request.LoginModel;

public class LoginUsuarioRequestModel
{
    [Required(ErrorMessage = "Correo Invalido")]
    [EmailAddress]
    [JsonPropertyName("correo")]
    public string Email { get; set; } = null!;


    [Required(ErrorMessage = "Digite Contraseña")]
    [JsonPropertyName ("contraseña")]
    public string Password { get; set; } = null!;

}
