using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPRA_FESC.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "carrera",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_carrera = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValueSql: "'NULL'"),
                    carrera = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formularios",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_formulario = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValueSql: "'NULL'"),
                    url = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    formulario = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "rol",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_rol = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValueSql: "'NULL'"),
                    rol = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_convenio",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_tipo_convenio = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValueSql: "'NULL'"),
                    convenio = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tipo_identificacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_tipo_identificacion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValueSql: "'NULL'"),
                    tipo_identificacion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "usuario",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_usuario = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValueSql: "'NULL'"),
                    nombres = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false),
                    apellidos = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    email = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    id_tipo_documento = table.Column<int>(type: "int(11)", nullable: true),
                    numero_identificacion = table.Column<string>(type: "varchar(90)", maxLength: 90, nullable: false, defaultValueSql: "'NULL'"),
                    id_rol = table.Column<int>(type: "int(11)", nullable: true),
                    id_carrera = table.Column<int>(type: "int(11)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "usuario_ibfk_1",
                        column: x => x.id_rol,
                        principalTable: "rol",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuario_ibfk_2",
                        column: x => x.id_carrera,
                        principalTable: "carrera",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "usuario_ibfk_3",
                        column: x => x.id_tipo_documento,
                        principalTable: "tipo_identificacion",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "empresa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_empresa = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    id_estudiante = table.Column<int>(type: "int(11)", nullable: false),
                    id_tipo_convenio = table.Column<int>(type: "int(11)", nullable: false),
                    nombre = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    nit = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    celular = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    direccion = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    correo = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    celular_jefe_inmediato = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    nombre_jefe_inmedianto = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "empresa_ibfk_1",
                        column: x => x.id_estudiante,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "empresa_ibfk_2",
                        column: x => x.id_tipo_convenio,
                        principalTable: "tipo_convenio",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "evaluacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    id_evaluacion = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false),
                    id_estudiante = table.Column<int>(type: "int(11)", nullable: false),
                    evaluacion = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "evaluacion_ibfk_1",
                        column: x => x.id_estudiante,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "formularios_cargados",
                columns: table => new
                {
                    id = table.Column<int>(type: "int(11)", nullable: false),
                    id_usuario = table.Column<int>(type: "int(11)", nullable: false),
                    id_formulario_cargado = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: true, defaultValueSql: "'NULL'"),
                    url = table.Column<int>(type: "int(11)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.id_usuario, x.id });
                    table.ForeignKey(
                        name: "formularios_cargados_ibfk_1",
                        column: x => x.id_usuario,
                        principalTable: "usuario",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "carrera",
                columns: new[] { "id", "carrera", "id_carrera" },
                values: new object[,]
                {
                    { 1, "Ingenieria de Software", "34ec1ba1-666b-43cd-b1a0-074ebb2f980d" },
                    { 2, "Diseño y Administración de Modas", "5342eb64-ae4d-4284-a985-50a2e815f7fa" },
                    { 3, "Diseño Grafico", "87f6ee04-c732-4ac9-a7c5-ec9e84106774" },
                    { 4, "Gestión Logistica Empresarial", "45107200-15df-4706-9b1a-224e8ff2c133" },
                    { 5, "Administración Turística y Hotelera", "a49961fe-889e-4aa6-97d2-bf9fc5ea0abc" },
                    { 6, "Administración Negocios Internacionales", "12ccc31a-dcb7-444a-8022-8b765e79eed5" },
                    { 7, "Administración financiera", "dc396fba-141f-4f6e-b672-7d78985e1aed" }
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "id", "id_rol", "rol" },
                values: new object[,]
                {
                    { 1, "7f5f385f-e4ef-45f6-a9b3-38d70ff13450", "Extension" },
                    { 2, "085bb635-553c-46da-a1bb-f2bd1c72e975", "Docente" },
                    { 3, "34e9a774-8aea-42f3-a062-a7ab61b74177", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "tipo_convenio",
                columns: new[] { "id", "convenio", "id_tipo_convenio" },
                values: new object[,]
                {
                    { 1, "CONVENIO", "d2f78570-e21f-48bd-8b89-e1387fc78980" },
                    { 2, "TRABAJA CON EMPRESA", "461fac44-0ea9-4100-99a3-d4058034cc82" },
                    { 3, "EMPRESA PROPIA", "5ff27100-dbaf-4cc0-812e-2b6adda70c9c" },
                    { 4, "INVESTIGACIÓN", "c509b7ba-007d-4378-8f55-b0a7f1d0bb14" },
                    { 5, "APRENDIZ UNIVERSITARIO", "c5ca5bb6-6d9a-4018-a4c2-88a8b3914f89" }
                });

            migrationBuilder.InsertData(
                table: "tipo_identificacion",
                columns: new[] { "id", "id_tipo_identificacion", "tipo_identificacion" },
                values: new object[,]
                {
                    { 1, "b2bf5a02-91a3-4770-9491-5c3f665c3ebf", "C.C" },
                    { 2, "60f42a69-e1a7-45b8-bd6d-a8f52f0fceba", "T.I" }
                });

            migrationBuilder.CreateIndex(
                name: "id_carrera",
                table: "carrera",
                column: "id_carrera",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_estudiante",
                table: "empresa",
                column: "id_estudiante");

            migrationBuilder.CreateIndex(
                name: "id_tipo_convenio",
                table: "empresa",
                column: "id_tipo_convenio");

            migrationBuilder.CreateIndex(
                name: "id_estudiante1",
                table: "evaluacion",
                column: "id_estudiante");

            migrationBuilder.CreateIndex(
                name: "id_formulario",
                table: "formularios",
                column: "id_formulario",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_formulario_cargado",
                table: "formularios_cargados",
                column: "id_formulario_cargado",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_rol",
                table: "rol",
                column: "id_rol",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_tipo_convenio1",
                table: "tipo_convenio",
                column: "id_tipo_convenio",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_tipo_identificacion",
                table: "tipo_identificacion",
                column: "id_tipo_identificacion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "email",
                table: "usuario",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "id_carrera1",
                table: "usuario",
                column: "id_carrera");

            migrationBuilder.CreateIndex(
                name: "id_rol1",
                table: "usuario",
                column: "id_rol");

            migrationBuilder.CreateIndex(
                name: "id_tipo_documento",
                table: "usuario",
                column: "id_tipo_documento");

            migrationBuilder.CreateIndex(
                name: "id_usuario",
                table: "usuario",
                column: "id_usuario",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "empresa");

            migrationBuilder.DropTable(
                name: "evaluacion");

            migrationBuilder.DropTable(
                name: "formularios");

            migrationBuilder.DropTable(
                name: "formularios_cargados");

            migrationBuilder.DropTable(
                name: "tipo_convenio");

            migrationBuilder.DropTable(
                name: "usuario");

            migrationBuilder.DropTable(
                name: "rol");

            migrationBuilder.DropTable(
                name: "carrera");

            migrationBuilder.DropTable(
                name: "tipo_identificacion");
        }
    }
}
