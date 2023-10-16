using System.Text.Json.Serialization;

namespace SIPRA_FESC.Dtos
{
    public class RolDto
    {
        public int Id { get; set; }

        public string? IdRol { get; set; }

        [JsonPropertyName("Nombre")]
        public string Rol1 { get; set; } = null!;
    }
}
