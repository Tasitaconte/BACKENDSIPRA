using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPRA_FESC.Migrations
{
    /// <inheritdoc />
    public partial class segunda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NumeroIdentificacion",
                table: "usuario",
                type: "longtext",
                nullable: false);

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 1,
                column: "id_carrera",
                value: "ae465a62-55d4-4ab1-b0bb-1ad6aff4fc39");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 2,
                column: "id_carrera",
                value: "bef32009-6779-45ed-bc21-9a13dc2fb618");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 3,
                column: "id_carrera",
                value: "ef4065cc-1dec-4ee6-b40d-4e3ac5b4d530");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 4,
                column: "id_carrera",
                value: "24b61819-0079-4f43-ae32-9aba463c06e7");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 5,
                column: "id_carrera",
                value: "097fa766-3a7f-4c1a-aab7-322eab18404f");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 6,
                column: "id_carrera",
                value: "0c59814c-9e15-4f64-94d5-e991a919c51a");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 7,
                column: "id_carrera",
                value: "d445ba51-7798-49a9-be0b-226a16f98d27");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "id_rol",
                value: "29554c30-9b1f-45cb-8348-7620133d08f1");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "id_rol",
                value: "df3cd461-7224-42a4-bd94-8488ab71c295");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "id_rol",
                value: "433f0e85-27e7-4b4a-82fa-02ef1cf60b02");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_convenio",
                value: "842f5de7-ec6d-4acf-919e-ad7c92e77b50");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_convenio",
                value: "ab2669bf-cd7b-48ec-bb9c-080596683d71");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 3,
                column: "id_tipo_convenio",
                value: "999a36b0-c812-410a-9276-186bf0b268cb");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 4,
                column: "id_tipo_convenio",
                value: "36dffec5-81d7-49fb-ba71-0f503c58e1f7");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 5,
                column: "id_tipo_convenio",
                value: "99513b56-1af7-43c5-b913-077e198b57a5");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_identificacion",
                value: "ceb6edf7-6fc1-4810-832f-d114914723fe");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_identificacion",
                value: "d9bbe8c3-490e-4cb9-9f51-c4b8fb7b3dbe");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumeroIdentificacion",
                table: "usuario");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 1,
                column: "id_carrera",
                value: "98296008-3386-4c9d-8040-91959d1852d4");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 2,
                column: "id_carrera",
                value: "b4d17cfe-223d-4478-8314-2f72e8fc9c90");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 3,
                column: "id_carrera",
                value: "9a8ef9ae-9ae3-4a7e-8b5a-adb5195b66e3");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 4,
                column: "id_carrera",
                value: "a0de7fa1-62dc-4840-924d-d326464ce83e");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 5,
                column: "id_carrera",
                value: "1d0200f0-a109-420d-a69f-dc55c5ec6361");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 6,
                column: "id_carrera",
                value: "26c5ecd8-73f5-4703-9da1-7bcc8ab052f0");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 7,
                column: "id_carrera",
                value: "720357c1-d3e7-46ac-a60f-1c7019dfd055");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "id_rol",
                value: "e0ddde3c-8694-44c2-94c0-a6212dcb894a");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "id_rol",
                value: "1a7e0223-4723-47b7-bb3e-41216667447e");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "id_rol",
                value: "09549090-5a33-4d93-8065-b0fd38d41ed5");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_convenio",
                value: "b74bcbe4-93de-4f07-a688-f7681e883695");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_convenio",
                value: "e6243cb5-b456-4285-9e21-bdfa019c7947");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 3,
                column: "id_tipo_convenio",
                value: "aa3c6c0a-1c44-4d3b-a370-f84b6b6e441b");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 4,
                column: "id_tipo_convenio",
                value: "38c1ebc6-8a59-4462-be1f-56dee8d5acb9");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 5,
                column: "id_tipo_convenio",
                value: "182bfc4d-a7ca-4261-8f04-a2e4573118e2");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_identificacion",
                value: "c7a96a81-9eb3-4fb4-8606-25d7d55676f6");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_identificacion",
                value: "2ae058b0-40fa-4a54-9671-3bd4aa33f1a3");
        }
    }
}
