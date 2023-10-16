﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIPRA_FESC.Entities;

#nullable disable

namespace SIPRA_FESC.Migrations
{
    [DbContext(typeof(SipraContext))]
    [Migration("20230904134232_segundaVersion")]
    partial class segundaVersion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SIPRA_FESC.Entities.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Carrera1")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("carrera");

                    b.Property<string>("IdCarrera")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_carrera")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdCarrera" }, "id_carrera")
                        .IsUnique();

                    b.ToTable("carrera", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Carrera1 = "Ingenieria de Software",
                            IdCarrera = "2d453abb-9e0b-47da-b38b-d56056f0e901"
                        },
                        new
                        {
                            Id = 2,
                            Carrera1 = "Diseño y Administración de Modas",
                            IdCarrera = "380e4513-dadf-40d2-ad41-b82794620543"
                        },
                        new
                        {
                            Id = 3,
                            Carrera1 = "Diseño Grafico",
                            IdCarrera = "13e3bddf-0685-46ac-bf6d-f69add51bda3"
                        },
                        new
                        {
                            Id = 4,
                            Carrera1 = "Gestión Logistica Empresarial",
                            IdCarrera = "a3916a38-2e33-4a4c-9d2c-867dbf60304d"
                        },
                        new
                        {
                            Id = 5,
                            Carrera1 = "Administración Turística y Hotelera",
                            IdCarrera = "3bd0a050-8f98-46d3-a4c7-e0a2cd158b84"
                        },
                        new
                        {
                            Id = 6,
                            Carrera1 = "Administración Negocios Internacionales",
                            IdCarrera = "446e639f-dbeb-49a8-ba41-c21f58563aae"
                        },
                        new
                        {
                            Id = 7,
                            Carrera1 = "Administración financiera",
                            IdCarrera = "84d4a817-51f2-40ed-804a-dfd91ef2b564"
                        });
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("celular");

                    b.Property<string>("CelularJefeInmediato")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("celular_jefe_inmediato");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("correo");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("direccion");

                    b.Property<string>("IdEmpresa")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_empresa");

                    b.Property<int>("IdEstudiante")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_estudiante");

                    b.Property<int>("IdTipoConvenio")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_tipo_convenio");

                    b.Property<string>("Nit")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("nit");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("nombre");

                    b.Property<string>("NombreJefeInmedianto")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("nombre_jefe_inmedianto");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEstudiante" }, "id_estudiante");

                    b.HasIndex(new[] { "IdTipoConvenio" }, "id_tipo_convenio");

                    b.ToTable("empresa", (string)null);
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Evaluacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Evaluacion1")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("evaluacion");

                    b.Property<int>("IdEstudiante")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_estudiante");

                    b.Property<string>("IdEvaluacion")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_evaluacion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdEstudiante" }, "id_estudiante")
                        .HasDatabaseName("id_estudiante1");

                    b.ToTable("evaluacion", (string)null);
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Formulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Formulario1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("formulario");

                    b.Property<string>("IdFormulario")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_formulario")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("varchar(300)")
                        .HasColumnName("url");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdFormulario" }, "id_formulario")
                        .IsUnique();

                    b.ToTable("formularios", (string)null);
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.FormulariosCargado", b =>
                {
                    b.Property<int>("IdUsuario")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_usuario");

                    b.Property<int>("Id")
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("IdFormularioCargado")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_formulario_cargado")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<int>("Url")
                        .HasColumnType("int(11)")
                        .HasColumnName("url");

                    b.HasKey("IdUsuario", "Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdFormularioCargado" }, "id_formulario_cargado")
                        .IsUnique();

                    b.ToTable("formularios_cargados", (string)null);
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_rol")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Rol1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("rol");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdRol" }, "id_rol")
                        .IsUnique();

                    b.ToTable("rol", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdRol = "3fe158bc-4434-4407-a242-718180e850c6",
                            Rol1 = "Extension"
                        },
                        new
                        {
                            Id = 2,
                            IdRol = "eab476e0-a947-4d75-9efd-0f1ea5f4d804",
                            Rol1 = "Docente"
                        },
                        new
                        {
                            Id = 3,
                            IdRol = "69c36bc3-0813-4bf2-8b0c-c9804722d2db",
                            Rol1 = "Estudiante"
                        });
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.TipoConvenio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Convenio")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("convenio");

                    b.Property<string>("IdTipoConvenio")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_tipo_convenio")
                        .HasDefaultValueSql("'NULL'");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdTipoConvenio" }, "id_tipo_convenio")
                        .IsUnique()
                        .HasDatabaseName("id_tipo_convenio1");

                    b.ToTable("tipo_convenio", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Convenio = "CONVENIO",
                            IdTipoConvenio = "6d1e7981-29d8-4de0-ac4a-1440bf5829ae"
                        },
                        new
                        {
                            Id = 2,
                            Convenio = "TRABAJA CON EMPRESA",
                            IdTipoConvenio = "9b4c0bf7-efc6-4c9a-bfa2-c5be25ed53e5"
                        },
                        new
                        {
                            Id = 3,
                            Convenio = "EMPRESA PROPIA",
                            IdTipoConvenio = "2f16ef44-0faf-414c-aab0-a22c94862e0f"
                        },
                        new
                        {
                            Id = 4,
                            Convenio = "INVESTIGACIÓN",
                            IdTipoConvenio = "4e6a705a-81c6-4637-9e82-df3e0a7ccb78"
                        },
                        new
                        {
                            Id = 5,
                            Convenio = "APRENDIZ UNIVERSITARIO",
                            IdTipoConvenio = "36908fd4-95cd-4f93-8542-0f3035dcc692"
                        });
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.TipoIdentificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("IdTipoIdentificacion")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_tipo_identificacion")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("TipoIdentificacion1")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("tipo_identificacion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "IdTipoIdentificacion" }, "id_tipo_identificacion")
                        .IsUnique();

                    b.ToTable("tipo_identificacion", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IdTipoIdentificacion = "02261570-85f8-4d66-8d92-2ca96496df4a",
                            TipoIdentificacion1 = "C.C"
                        },
                        new
                        {
                            Id = 2,
                            IdTipoIdentificacion = "663dfd62-7f99-4157-98ac-ea2b7641afef",
                            TipoIdentificacion1 = "T.I"
                        });
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(11)")
                        .HasColumnName("id");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("apellidos");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("email");

                    b.Property<int?>("IdCarrera")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_carrera");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_rol");

                    b.Property<int?>("IdTipoDocumento")
                        .HasColumnType("int(11)")
                        .HasColumnName("id_tipo_documento");

                    b.Property<string>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(250)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("id_usuario")
                        .HasDefaultValueSql("'NULL'");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("nombres");

                    b.Property<string>("NumeroIdentificacion")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("varchar(90)")
                        .HasColumnName("numero_identificacion");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "Email" }, "email")
                        .IsUnique();

                    b.HasIndex(new[] { "IdCarrera" }, "id_carrera")
                        .HasDatabaseName("id_carrera1");

                    b.HasIndex(new[] { "IdRol" }, "id_rol")
                        .HasDatabaseName("id_rol1");

                    b.HasIndex(new[] { "IdTipoDocumento" }, "id_tipo_documento");

                    b.HasIndex(new[] { "IdUsuario" }, "id_usuario")
                        .IsUnique();

                    b.HasIndex(new[] { "NumeroIdentificacion" }, "numero_identificacion");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Empresa", b =>
                {
                    b.HasOne("SIPRA_FESC.Entities.Usuario", "IdEstudianteNavigation")
                        .WithMany("Empresas")
                        .HasForeignKey("IdEstudiante")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("empresa_ibfk_1");

                    b.HasOne("SIPRA_FESC.Entities.TipoConvenio", "IdTipoConvenioNavigation")
                        .WithMany("Empresas")
                        .HasForeignKey("IdTipoConvenio")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("empresa_ibfk_2");

                    b.Navigation("IdEstudianteNavigation");

                    b.Navigation("IdTipoConvenioNavigation");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Evaluacion", b =>
                {
                    b.HasOne("SIPRA_FESC.Entities.Usuario", "IdEstudianteNavigation")
                        .WithMany("Evaluacions")
                        .HasForeignKey("IdEstudiante")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("evaluacion_ibfk_1");

                    b.Navigation("IdEstudianteNavigation");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.FormulariosCargado", b =>
                {
                    b.HasOne("SIPRA_FESC.Entities.Usuario", "IdUsuarioNavigation")
                        .WithMany("FormulariosCargados")
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("formularios_cargados_ibfk_1");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Usuario", b =>
                {
                    b.HasOne("SIPRA_FESC.Entities.Carrera", "IdCarreraNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdCarrera")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("usuario_ibfk_2");

                    b.HasOne("SIPRA_FESC.Entities.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("usuario_ibfk_1");

                    b.HasOne("SIPRA_FESC.Entities.TipoIdentificacion", "IdTipoDocumentoNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Restrict)
                        .HasConstraintName("usuario_ibfk_3");

                    b.Navigation("IdCarreraNavigation");

                    b.Navigation("IdRolNavigation");

                    b.Navigation("IdTipoDocumentoNavigation");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Carrera", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.TipoConvenio", b =>
                {
                    b.Navigation("Empresas");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.TipoIdentificacion", b =>
                {
                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("SIPRA_FESC.Entities.Usuario", b =>
                {
                    b.Navigation("Empresas");

                    b.Navigation("Evaluacions");

                    b.Navigation("FormulariosCargados");
                });
#pragma warning restore 612, 618
        }
    }
}