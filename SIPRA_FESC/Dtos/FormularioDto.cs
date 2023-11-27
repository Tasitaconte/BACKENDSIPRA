using System.Text.Json.Serialization;

namespace SIPRA_FESC.Dtos
{
    public class FormularioDto
    {
        public int Id { get; set; }


        public string? IdFormulario { get; set; }

        public string Url { get; set; } = null!;

        [JsonPropertyName("Formulario")]
        public string Formulario1 { get; set; } = null!;
    }
}
