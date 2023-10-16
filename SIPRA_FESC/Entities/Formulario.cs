using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class Formulario
{
    public int Id { get; set; }

    public string? IdFormulario { get; set; }

    public string Url { get; set; } = null!;

    public string Formulario1 { get; set; } = null!;
}
