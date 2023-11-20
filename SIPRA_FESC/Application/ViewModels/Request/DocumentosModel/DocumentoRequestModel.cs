using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SIPRA_FESC.Application.ViewModels.Request.DocumentosModel;

public class DocumentoRequestModel
{
    [Required(ErrorMessage = "Se necesita el nombre del formulario")]
    [JsonPropertyName("formulario")]
    public string Formulario { get; set; } = null!;

    [Required(ErrorMessage = "Cargue el archivo pdf")]
    [JsonPropertyName("archivo")]
    public IFormFile Archivo { get; set; } = null!;

}
