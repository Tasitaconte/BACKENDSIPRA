using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIPRA_FESC.Migrations
{
    /// <inheritdoc />
    public partial class segundaVersionn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "numero_identificacion",
                table: "usuario");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 1,
                column: "id_carrera",
                value: "c0d7472e-81a5-437f-9a08-91a8f419dc1c");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 2,
                column: "id_carrera",
                value: "f0a46a3b-f1fe-4c66-b7d9-aaba878e3b56");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 3,
                column: "id_carrera",
                value: "d8fa7f36-0959-419c-ba44-0a548b803973");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 4,
                column: "id_carrera",
                value: "3b72e843-946b-4fd1-afa2-a42951895931");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 5,
                column: "id_carrera",
                value: "16a280d1-f2ba-4130-b8c1-3c0f92b7e42c");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 6,
                column: "id_carrera",
                value: "2f73c3ab-9834-4a26-bc21-9e5b805bd48a");

            migrationBuilder.UpdateData(
                table: "carrera",
                keyColumn: "id",
                keyValue: 7,
                column: "id_carrera",
                value: "0329c423-54d7-49e3-8e18-b29b829641a6");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 1,
                column: "id_rol",
                value: "6ba1432b-fcab-4344-9cff-4ab46f2c1069");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 2,
                column: "id_rol",
                value: "2afa4408-505f-4aa0-9dc9-8764fe41edbd");

            migrationBuilder.UpdateData(
                table: "rol",
                keyColumn: "id",
                keyValue: 3,
                column: "id_rol",
                value: "50843a37-c57c-4836-9db3-1f371e35c380");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_convenio",
                value: "367a87ca-25fb-4703-89c9-7bcebbc4c25f");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_convenio",
                value: "9bfba821-0206-4128-95fd-e4dc43c3960e");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 3,
                column: "id_tipo_convenio",
                value: "85990258-7c96-43b1-9a8e-6ad8a1d9a0f4");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 4,
                column: "id_tipo_convenio",
                value: "2bde822b-50c4-4137-b38f-0e367f3f37be");

            migrationBuilder.UpdateData(
                table: "tipo_convenio",
                keyColumn: "id",
                keyValue: 5,
                column: "id_tipo_convenio",
                value: "85b3efea-ae16-42c6-a762-bf5d961c7910");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 1,
                column: "id_tipo_identificacion",
                value: "05da7ea4-9523-425f-b8fd-b32475144fd9");

            migrationBuilder.UpdateData(
                table: "tipo_identificacion",
                keyColumn: "id",
                keyValue: 2,
                column: "id_tipo_identificacion",
                value: "e25a28e3-99f7-4498-8e53-546b95d92489");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
