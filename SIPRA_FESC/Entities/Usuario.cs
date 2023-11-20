using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class Usuario
{
    public int Id { get; set; }

    public string? IdUsuario { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string Email { get; set; } = null!;

    public int? IdTipoDocumento { get; set; }

    public string NumeroIdentificacion { get; set; } = null!;

    public string? Password { get; set; }

    public int? IdRol { get; set; }

    public int? IdCarrera { get; set; }

    public virtual ICollection<Empresa> Empresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Evaluacion> Evaluacions { get; set; } = new List<Evaluacion>();

    public virtual Carrera? IdCarreraNavigation { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }

    public virtual TipoIdentificacion? IdTipoDocumentoNavigation { get; set; }
}
