using SIPRA_FESC.Entities;
using System.Text.Json.Serialization;

namespace SIPRA_FESC.Dtos
{
    public class UsuarioDto
    {
        public int Id { get; set; }

        public string? IdUsuario { get; set; }

        public string Nombres { get; set; } = null!;

        public string Apellidos { get; set; } = null!;

        public string Email { get; set; } = null!;

        [JsonPropertyName("Documento")]
        public TipoIdentificacionDto? IdTipoDocumentoNavigation { get; set; }
        public string NumeroIdentificacion { get; set; } = null!;
        [JsonPropertyName("Carrera")]
        public CarreraDto? IdCarreraNavigation { get; set; }
        
        [JsonPropertyName("Rol")]
        public RolDto? IdRolNavigation { get; set; }

    }
}
