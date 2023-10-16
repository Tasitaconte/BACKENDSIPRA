using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class FormulariosCargado
{
    public int Id { get; set; }

    public string? IdFormularioCargado { get; set; }

    public int Url { get; set; }

    public int IdUsuario { get; set; }

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
