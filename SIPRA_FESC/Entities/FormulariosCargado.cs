using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class FormulariosCargado
{
    public int Id { get; set; }

    public int IdUsuario { get; set; }

    public string IdFormularioCargado { get; set; } = null!;

    public string IdFormulario { get; set; } = null!;

    public string Url { get; set; } = null!;
}
