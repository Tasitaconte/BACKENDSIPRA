using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SIPRA_FESC.Migrations
{
    /// <inheritdoc />
    public partial class firstMigration : Migration
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
                    { 1, "Ingenieria de Software", "98296008-3386-4c9d-8040-91959d1852d4" },
                    { 2, "Diseño y Administración de Modas", "b4d17cfe-223d-4478-8314-2f72e8fc9c90" },
                    { 3, "Diseño Grafico", "9a8ef9ae-9ae3-4a7e-8b5a-adb5195b66e3" },
                    { 4, "Gestión Logistica Empresarial", "a0de7fa1-62dc-4840-924d-d326464ce83e" },
                    { 5, "Administración Turística y Hotelera", "1d0200f0-a109-420d-a69f-dc55c5ec6361" },
                    { 6, "Administración Negocios Internacionales", "26c5ecd8-73f5-4703-9da1-7bcc8ab052f0" },
                    { 7, "Administración financiera", "720357c1-d3e7-46ac-a60f-1c7019dfd055" }
                });

            migrationBuilder.InsertData(
                table: "rol",
                columns: new[] { "id", "id_rol", "rol" },
                values: new object[,]
                {
                    { 1, "e0ddde3c-8694-44c2-94c0-a6212dcb894a", "Extension" },
                    { 2, "1a7e0223-4723-47b7-bb3e-41216667447e", "Docente" },
                    { 3, "09549090-5a33-4d93-8065-b0fd38d41ed5", "Estudiante" }
                });

            migrationBuilder.InsertData(
                table: "tipo_convenio",
                columns: new[] { "id", "convenio", "id_tipo_convenio" },
                values: new object[,]
                {
                    { 1, "CONVENIO", "b74bcbe4-93de-4f07-a688-f7681e883695" },
                    { 2, "TRABAJA CON EMPRESA", "e6243cb5-b456-4285-9e21-bdfa019c7947" },
                    { 3, "EMPRESA PROPIA", "aa3c6c0a-1c44-4d3b-a370-f84b6b6e441b" },
                    { 4, "INVESTIGACIÓN", "38c1ebc6-8a59-4462-be1f-56dee8d5acb9" },
                    { 5, "APRENDIZ UNIVERSITARIO", "182bfc4d-a7ca-4261-8f04-a2e4573118e2" }
                });

            migrationBuilder.InsertData(
                table: "tipo_identificacion",
                columns: new[] { "id", "id_tipo_identificacion", "tipo_identificacion" },
                values: new object[,]
                {
                    { 1, "c7a96a81-9eb3-4fb4-8606-25d7d55676f6", "C.C" },
                    { 2, "2ae058b0-40fa-4a54-9671-3bd4aa33f1a3", "T.I" }
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
