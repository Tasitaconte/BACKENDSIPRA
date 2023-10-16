using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SIPRA_FESC.Entities;

public partial class SipraContext : DbContext
{

    public SipraContext()
    {

    }

    public SipraContext(DbContextOptions<SipraContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Carrera> Carreras { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Evaluacion> Evaluacions { get; set; }

    public virtual DbSet<Formulario> Formularios { get; set; }

    public virtual DbSet<FormulariosCargado> FormulariosCargados { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<TipoConvenio> TipoConvenios { get; set; }

    public virtual DbSet<TipoIdentificacion> TipoIdentificacions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Carrera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("carrera");

            entity.HasIndex(e => e.IdCarrera, "id_carrera").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Carrera1)
                .HasMaxLength(300)
                .HasColumnName("carrera");
            entity.Property(e => e.IdCarrera)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("id_carrera");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("empresa");

            entity.HasIndex(e => e.IdEstudiante, "id_estudiante");

            entity.HasIndex(e => e.IdTipoConvenio, "id_tipo_convenio");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Celular)
                .HasMaxLength(150)
                .HasColumnName("celular");
            entity.Property(e => e.CelularJefeInmediato)
                .HasMaxLength(300)
                .HasColumnName("celular_jefe_inmediato");
            entity.Property(e => e.Correo)
                .HasMaxLength(300)
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(300)
                .HasColumnName("direccion");
            entity.Property(e => e.IdEmpresa)
                .HasMaxLength(250)
                .HasColumnName("id_empresa");
            entity.Property(e => e.IdEstudiante)
                .HasColumnType("int(11)")
                .HasColumnName("id_estudiante");
            entity.Property(e => e.IdTipoConvenio)
                .HasColumnType("int(11)")
                .HasColumnName("id_tipo_convenio");
            entity.Property(e => e.Nit)
                .HasMaxLength(300)
                .HasColumnName("nit");
            entity.Property(e => e.Nombre)
                .HasMaxLength(300)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreJefeInmedianto)
                .HasMaxLength(300)
                .HasColumnName("nombre_jefe_inmedianto");

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdEstudiante)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("empresa_ibfk_1");

            entity.HasOne(d => d.IdTipoConvenioNavigation).WithMany(p => p.Empresas)
                .HasForeignKey(d => d.IdTipoConvenio)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("empresa_ibfk_2");
        });

        modelBuilder.Entity<Evaluacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("evaluacion");

            entity.HasIndex(e => e.IdEstudiante, "id_estudiante");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Evaluacion1).HasColumnName("evaluacion");
            entity.Property(e => e.IdEstudiante)
                .HasColumnType("int(11)")
                .HasColumnName("id_estudiante");
            entity.Property(e => e.IdEvaluacion)
                .HasMaxLength(250)
                .HasColumnName("id_evaluacion");

            entity.HasOne(d => d.IdEstudianteNavigation).WithMany(p => p.Evaluacions)
                .HasForeignKey(d => d.IdEstudiante)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("evaluacion_ibfk_1");
        });

        modelBuilder.Entity<Formulario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("formularios");

            entity.HasIndex(e => e.IdFormulario, "id_formulario").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Formulario1)
                .HasMaxLength(250)
                .HasColumnName("formulario");
            entity.Property(e => e.IdFormulario)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("id_formulario");
            entity.Property(e => e.Url)
                .HasMaxLength(300)
                .HasColumnName("url");
        });

        modelBuilder.Entity<FormulariosCargado>(entity =>
        {
            entity.HasKey(e => new { e.IdUsuario, e.Id }).HasName("PRIMARY");

            entity.ToTable("formularios_cargados");

            entity.HasIndex(e => e.IdFormularioCargado, "id_formulario_cargado").IsUnique();

            entity.Property(e => e.IdUsuario)
                .HasColumnType("int(11)")
                .HasColumnName("id_usuario");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdFormularioCargado)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("id_formulario_cargado");
            entity.Property(e => e.Url)
                .HasColumnType("int(11)")
                .HasColumnName("url");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.FormulariosCargados)
                .HasForeignKey(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("formularios_cargados_ibfk_1");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("rol");

            entity.HasIndex(e => e.IdRol, "id_rol").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdRol)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("id_rol");
            entity.Property(e => e.Rol1)
                .HasMaxLength(250)
                .HasColumnName("rol");
        });

        modelBuilder.Entity<TipoConvenio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_convenio");

            entity.HasIndex(e => e.IdTipoConvenio, "id_tipo_convenio").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Convenio)
                .HasMaxLength(250)
                .HasColumnName("convenio");
            entity.Property(e => e.IdTipoConvenio)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("id_tipo_convenio");
        });

        modelBuilder.Entity<TipoIdentificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tipo_identificacion");

            entity.HasIndex(e => e.IdTipoIdentificacion, "id_tipo_identificacion").IsUnique();

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.IdTipoIdentificacion)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("id_tipo_identificacion");
            entity.Property(e => e.TipoIdentificacion1)
                .HasMaxLength(250)
                .HasColumnName("tipo_identificacion");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.Email, "email").IsUnique();

            entity.HasIndex(e => e.IdCarrera, "id_carrera");

            entity.HasIndex(e => e.IdRol, "id_rol");

            entity.HasIndex(e => e.IdTipoDocumento, "id_tipo_documento");

            entity.HasIndex(e => e.IdUsuario, "id_usuario").IsUnique();

            entity.Property(e => e.NumeroIdentificacion)
                .HasMaxLength(90).HasDefaultValueSql("'NULL'")
                .HasColumnName("numero_identificacion");
            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Apellidos)
                .HasMaxLength(250)
                .HasColumnName("apellidos");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("email");
            entity.Property(e => e.IdCarrera)
                .HasColumnType("int(11)")
                .HasColumnName("id_carrera");
            entity.Property(e => e.IdRol)
                .HasColumnType("int(11)")
                .HasColumnName("id_rol");
            entity.Property(e => e.IdTipoDocumento)
                .HasColumnType("int(11)")
                .HasColumnName("id_tipo_documento");
            entity.Property(e => e.IdUsuario)
                .HasMaxLength(250)
                .HasDefaultValueSql("'NULL'")
                .HasColumnName("id_usuario");
            entity.Property(e => e.Nombres)
                .HasMaxLength(90)
                .HasColumnName("nombres");

            entity.HasOne(d => d.IdCarreraNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdCarrera)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("usuario_ibfk_2");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("usuario_ibfk_1");

            entity.HasOne(d => d.IdTipoDocumentoNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdTipoDocumento)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("usuario_ibfk_3");
        });

        modelBuilder.Entity<Rol>().HasData(
           new Rol { Id = 1, IdRol = Guid.NewGuid().ToString() , Rol1 = "Extension" },
           new Rol { Id = 2, IdRol = Guid.NewGuid().ToString(), Rol1 = "Docente" },
           new Rol { Id = 3, IdRol = Guid.NewGuid().ToString(), Rol1 = "Estudiante" }
        );

        modelBuilder.Entity<Carrera>().HasData(
           new Carrera { Id = 1, IdCarrera = Guid.NewGuid().ToString(), Carrera1 = "Ingenieria de Software" },
           new Carrera { Id = 2, IdCarrera = Guid.NewGuid().ToString(), Carrera1 = "Diseño y Administración de Modas" },
           new Carrera { Id = 3,IdCarrera = Guid.NewGuid().ToString(), Carrera1 = "Diseño Grafico" },
           new Carrera { Id = 4,IdCarrera = Guid.NewGuid().ToString(), Carrera1 = "Gestión Logistica Empresarial" },
           new Carrera { Id = 5,IdCarrera = Guid.NewGuid().ToString(), Carrera1 = "Administración Turística y Hotelera" },
           new Carrera { Id = 6,IdCarrera = Guid.NewGuid().ToString(), Carrera1 = "Administración Negocios Internacionales" },
           new Carrera { Id = 7, IdCarrera = Guid.NewGuid().ToString(), Carrera1 = "Administración financiera" }
        );

        modelBuilder.Entity<TipoConvenio>().HasData(
           new TipoConvenio {Id = 1, IdTipoConvenio = Guid.NewGuid().ToString(), Convenio = "CONVENIO" },
           new TipoConvenio {Id = 2, IdTipoConvenio = Guid.NewGuid().ToString(), Convenio = "TRABAJA CON EMPRESA" },
           new TipoConvenio {Id = 3, IdTipoConvenio = Guid.NewGuid().ToString(), Convenio = "EMPRESA PROPIA" },
           new TipoConvenio {Id = 4, IdTipoConvenio = Guid.NewGuid().ToString(), Convenio = "INVESTIGACIÓN" },
           new TipoConvenio {Id = 5, IdTipoConvenio = Guid.NewGuid().ToString(), Convenio = "APRENDIZ UNIVERSITARIO" }

        );
        modelBuilder.Entity<TipoIdentificacion>().HasData(
        new TipoIdentificacion {Id = 1, IdTipoIdentificacion = Guid.NewGuid().ToString(), TipoIdentificacion1 = "C.C" },
        new TipoIdentificacion {Id = 2, IdTipoIdentificacion = Guid.NewGuid().ToString()  , TipoIdentificacion1 = "T.I" }
     );


        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
