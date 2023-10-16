using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPRA_FESC.Migrations
{
    /// <inheritdoc />
    public partial class addCampoPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "usuario",
                type: "longtext",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 1,
                column: "id_carrera",
                value: "e6ce6313-d653-4fe1-aa2e-285ab0c7bd35");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 2,
                column: "id_carrera",
                value: "55559c64-cedc-4e4a-a9c2-f9496b42028b");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 3,
                column: "id_carrera",
                value: "22be452f-0a21-49cf-be11-05c2179a5065");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 4,
                column: "id_carrera",
                value: "c8829702-0b25-4e96-8cd1-b1eab4cb516c");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 5,
                column: "id_carrera",
                value: "0b864717-c2ca-4730-bf11-be14c799515d");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 6,
                column: "id_carrera",
                value: "05ce4ce3-5afd-4f56-879f-cebde2e3e1db");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 7,
                column: "id_carrera",
                value: "f2aa2900-7300-4a00-8933-84b9a5b8c9f1");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "id_rol",
                value: "20316fda-c712-4534-834d-f28e09c7752e");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "id_rol",
                value: "a5a61748-d30b-4852-8f92-4ad303dbdc2f");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "id_rol",
                value: "35fbdee7-272f-469a-a004-b49b332876dd");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_convenio",
                value: "7aef4583-8f03-4cf4-8eef-1afc2e58a7e5");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_convenio",
                value: "ece2e070-5c7c-485d-9a5a-cfb65a13831c");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 3,
                column: "id_tipo_convenio",
                value: "62fc5550-188b-48f1-bd82-e7507cf2d7a9");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 4,
                column: "id_tipo_convenio",
                value: "d4105488-bc13-4839-a4c5-b67d4a3672c7");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 5,
                column: "id_tipo_convenio",
                value: "a5b44323-fbdf-41b0-b498-1cb74e886b43");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_identificacion",
                value: "6b46599d-9e27-4ad2-98cd-cd39c75b612a");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_identificacion",
                value: "f266373a-d3ec-49fc-99c0-32bfb02b74d1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "usuario");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 1,
                column: "id_carrera",
                value: "34ec1ba1-666b-43cd-b1a0-074ebb2f980d");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 2,
                column: "id_carrera",
                value: "5342eb64-ae4d-4284-a985-50a2e815f7fa");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 3,
                column: "id_carrera",
                value: "87f6ee04-c732-4ac9-a7c5-ec9e84106774");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 4,
                column: "id_carrera",
                value: "45107200-15df-4706-9b1a-224e8ff2c133");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 5,
                column: "id_carrera",
                value: "a49961fe-889e-4aa6-97d2-bf9fc5ea0abc");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 6,
                column: "id_carrera",
                value: "12ccc31a-dcb7-444a-8022-8b765e79eed5");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 7,
                column: "id_carrera",
                value: "dc396fba-141f-4f6e-b672-7d78985e1aed");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "id_rol",
                value: "7f5f385f-e4ef-45f6-a9b3-38d70ff13450");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "id_rol",
                value: "085bb635-553c-46da-a1bb-f2bd1c72e975");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "id_rol",
                value: "34e9a774-8aea-42f3-a062-a7ab61b74177");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_convenio",
                value: "d2f78570-e21f-48bd-8b89-e1387fc78980");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_convenio",
                value: "461fac44-0ea9-4100-99a3-d4058034cc82");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 3,
                column: "id_tipo_convenio",
                value: "5ff27100-dbaf-4cc0-812e-2b6adda70c9c");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 4,
                column: "id_tipo_convenio",
                value: "c509b7ba-007d-4378-8f55-b0a7f1d0bb14");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 5,
                column: "id_tipo_convenio",
                value: "c5ca5bb6-6d9a-4018-a4c2-88a8b3914f89");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_identificacion",
                value: "b2bf5a02-91a3-4770-9491-5c3f665c3ebf");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_identificacion",
                value: "60f42a69-e1a7-45b8-bd6d-a8f52f0fceba");
        }
    }
}
