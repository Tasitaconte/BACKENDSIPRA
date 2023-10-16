using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class TipoIdentificacion
{
    public int Id { get; set; }

    public string? IdTipoIdentificacion { get; set; }

    public string TipoIdentificacion1 { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
