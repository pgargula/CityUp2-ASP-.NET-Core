using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class seedGeolocationData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GeolocationId",
                table: "Cities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Geolocations",
                columns: new[] { "GeolocationId", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 1, 50.064700000000002, 19.945 },
                    { 2, 50.164700000000003, 19.945 },
                    { 3, 50.064999999999998, 19.954999999999998 },
                    { 4, 50.067700000000002, 19.965 },
                    { 5, 50.064700000000002, 19.914999999999999 },
                    { 6, 50.054699999999997, 19.899999999999999 },
                    { 7, 50.0747, 19.844999999999999 },
                    { 8, 55.054699999999997, 18.899999999999999 },
                    { 9, 53.054699999999997, 19.600000000000001 }
                });

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 1,
                column: "GeolocationId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 2,
                column: "GeolocationId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 3,
                column: "GeolocationId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 4,
                column: "GeolocationId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "GeolocationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "GeolocationId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "GeolocationId",
                value: 9);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_GeolocationId",
                table: "Cities",
                column: "GeolocationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Geolocations_GeolocationId",
                table: "Cities",
                column: "GeolocationId",
                principalTable: "Geolocations",
                principalColumn: "GeolocationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Geolocations_GeolocationId",
                table: "Cities");

            migrationBuilder.DropIndex(
                name: "IX_Cities_GeolocationId",
                table: "Cities");

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Geolocations",
                keyColumn: "GeolocationId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "GeolocationId",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 1,
                column: "GeolocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 2,
                column: "GeolocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 3,
                column: "GeolocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 4,
                column: "GeolocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 1,
                column: "GeolocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 2,
                column: "GeolocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 3,
                column: "GeolocationId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Adress",
                keyColumn: "AdressId",
                keyValue: 4,
                column: "GeolocationId",
                value: null);
        }
    }
}
