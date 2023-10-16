using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class Carrera
{
    public int Id { get; set; }

    public string? IdCarrera { get; set; }

    public string Carrera1 { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
