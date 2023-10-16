using System;
using System.Collections.Generic;

namespace SIPRA_FESC.Entities;

public partial class Evaluacion
{
    public int Id { get; set; }

    public string IdEvaluacion { get; set; } = null!;

    public int IdEstudiante { get; set; }

    public string Evaluacion1 { get; set; } = null!;

    public virtual Usuario IdEstudianteNavigation { get; set; } = null!;
}
