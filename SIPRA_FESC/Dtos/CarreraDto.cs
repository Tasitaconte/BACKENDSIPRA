using System.Text.Json.Serialization;

namespace SIPRA_FESC.Dtos
{
    public class CarreraDto
    {
        public int Id { get; set; }

        public string? IdCarrera { get; set; }

        [JsonPropertyName("Nombre")]
        public string Carrera1 { get; set; } = null!;
    }
}
