using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SIPRA_FESC.Application.ViewModels.Request.DocumentosModel
{
    public class DocumentRequestSubirEstudiante
    {
        [Required(ErrorMessage = "Cargue el archivo pdf")]
        [JsonPropertyName("archivo")]
        public IFormFile Archivo { get; set; } = null!;
    }
}
