using SIPRA_FESC.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SIPRA_FESC.Application.ViewModels.Request.UsuarioModels;

public class UsuarioRequestCrearModel
{
    [Required(ErrorMessage = "el campo nombre es requerido")]
    [MaxLength(255)]
    [JsonPropertyName("nombre")]
    public string Nombres { get; set; } = null!;

    [Required(ErrorMessage = "el campo apellidos es requerido")]
    [MaxLength(255)]
    [JsonPropertyName("apellidos")]
    public string Apellidos { get; set; } = null!;

    [Required(ErrorMessage = "el campo correo es requerido")]
    [JsonPropertyName("correo")]
    public string Email { get; set; } = null!;

    [Required(ErrorMessage = "el campo tipo documento es requerido")]
    [JsonPropertyName("tipo_documento")]
    public int? IdTipoDocumento { get; set; } = 0!;

    [Required(ErrorMessage = "el campo numero de identificación es requerido")]
    [JsonPropertyName("numero_identificacion")]
    public string NumeroIdentificacion { get; set; } = null!;

    [Required(ErrorMessage = "el campo carrera es requerido")]
    [JsonPropertyName("carrera")]
    public int? IdCarrera { get; set; } = 0!;

    [Required(ErrorMessage = "el campo contraseña es requerido")]
    [JsonPropertyName("contraseña")]
    public string? Password { get; set; } = null!;
}
