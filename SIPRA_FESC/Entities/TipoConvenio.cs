using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class TipoConvenio
{
    public int Id { get; set; }

    public string? IdTipoConvenio { get; set; }

    public string Convenio { get; set; } = null!;

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();
}
