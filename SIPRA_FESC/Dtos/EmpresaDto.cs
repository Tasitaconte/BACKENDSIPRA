namespace SIPRA_FESC.Dtos
{
    public class EmpresaDto
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
    }
}
