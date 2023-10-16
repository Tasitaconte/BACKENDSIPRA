using System.Text.Json.Serialization;

namespace SIPRA_FESC.Dtos
{
    public class TipoIdentificacionDto
    {
        public int Id { get; set; }

        public string? IdTipoIdentificacion { get; set; }

        [JsonPropertyName("identificacion")]
        public string TipoIdentificacion1 { get; set; } = null!;
    }
}
