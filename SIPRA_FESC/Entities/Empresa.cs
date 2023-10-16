using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class Empresa
{
    public int Id { get; set; }

    public string IdEmpresa { get; set; } = null!;

    public int IdEstudiante { get; set; }

    public int IdTipoConvenio { get; set; }

    public string Nombre { get; set; } = null!;

    public string Nit { get; set; } = null!;

    public string Celular { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string CelularJefeInmediato { get; set; } = null!;

    public string NombreJefeInmedianto { get; set; } = null!;

    public virtual Usuario IdEstudianteNavigation { get; set; } = null!;

    public virtual TipoConvenio IdTipoConvenioNavigation { get; set; } = null!;
}
