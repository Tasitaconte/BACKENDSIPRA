using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPRA_FESC.Migrations
{
    /// <inheritdoc />
    public partial class segundaVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NumeroIdentificacion",
                table: "usuario",
                newName: "numero_identificacion");

            migrationBuilder.AlterColumn<string>(
                name: "numero_identificacion",
                table: "usuario",
                type: "varchar(90)",
                maxLength: 90,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 1,
                column: "id_carrera",
                value: "2d453abb-9e0b-47da-b38b-d56056f0e901");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 2,
                column: "id_carrera",
                value: "380e4513-dadf-40d2-ad41-b82794620543");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 3,
                column: "id_carrera",
                value: "13e3bddf-0685-46ac-bf6d-f69add51bda3");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 4,
                column: "id_carrera",
                value: "a3916a38-2e33-4a4c-9d2c-867dbf60304d");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 5,
                column: "id_carrera",
                value: "3bd0a050-8f98-46d3-a4c7-e0a2cd158b84");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 6,
                column: "id_carrera",
                value: "446e639f-dbeb-49a8-ba41-c21f58563aae");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 7,
                column: "id_carrera",
                value: "84d4a817-51f2-40ed-804a-dfd91ef2b564");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "id_rol",
                value: "3fe158bc-4434-4407-a242-718180e850c6");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "id_rol",
                value: "eab476e0-a947-4d75-9efd-0f1ea5f4d804");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "id_rol",
                value: "69c36bc3-0813-4bf2-8b0c-c9804722d2db");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_convenio",
                value: "6d1e7981-29d8-4de0-ac4a-1440bf5829ae");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_convenio",
                value: "9b4c0bf7-efc6-4c9a-bfa2-c5be25ed53e5");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 3,
                column: "id_tipo_convenio",
                value: "2f16ef44-0faf-414c-aab0-a22c94862e0f");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 4,
                column: "id_tipo_convenio",
                value: "4e6a705a-81c6-4637-9e82-df3e0a7ccb78");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 5,
                column: "id_tipo_convenio",
                value: "36908fd4-95cd-4f93-8542-0f3035dcc692");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_identificacion",
                value: "02261570-85f8-4d66-8d92-2ca96496df4a");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_identificacion",
                value: "663dfd62-7f99-4157-98ac-ea2b7641afef");

            migrationBuilder.CreateIndex(
                name: "numero_identificacion",
                table: "usuario",
                column: "numero_identificacion");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "numero_identificacion",
                table: "usuario");

            migrationBuilder.RenameColumn(
                name: "numero_identificacion",
                table: "usuario",
                newName: "NumeroIdentificacion");

            migrationBuilder.AlterColumn<string>(
                name: "NumeroIdentificacion",
                table: "usuario",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(90)",
                oldMaxLength: 90);

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
    }
}
