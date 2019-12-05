using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class fixDbSet1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Cities_CityId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Districts_DistrictId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Adress_Geolocations_GeolocationId",
                table: "Adress");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Adress_AdressId",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adress",
                table: "Adress");

            migrationBuilder.RenameTable(
                name: "Adress",
                newName: "Adresses");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_GeolocationId",
                table: "Adresses",
                newName: "IX_Adresses_GeolocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_DistrictId",
                table: "Adresses",
                newName: "IX_Adresses_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_Adress_CityId",
                table: "Adresses",
                newName: "IX_Adresses_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses",
                column: "AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Districts_DistrictId",
                table: "Adresses",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Geolocations_GeolocationId",
                table: "Adresses",
                column: "GeolocationId",
                principalTable: "Geolocations",
                principalColumn: "GeolocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Adresses_AdressId",
                table: "Applications",
                column: "AdressId",
                principalTable: "Adresses",
                principalColumn: "AdressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Cities_CityId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Districts_DistrictId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Geolocations_GeolocationId",
                table: "Adresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Applications_Adresses_AdressId",
                table: "Applications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses");

            migrationBuilder.RenameTable(
                name: "Adresses",
                newName: "Adress");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_GeolocationId",
                table: "Adress",
                newName: "IX_Adress_GeolocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_DistrictId",
                table: "Adress",
                newName: "IX_Adress_DistrictId");

            migrationBuilder.RenameIndex(
                name: "IX_Adresses_CityId",
                table: "Adress",
                newName: "IX_Adress_CityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adress",
                table: "Adress",
                column: "AdressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Cities_CityId",
                table: "Adress",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Districts_DistrictId",
                table: "Adress",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "DistrictId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Adress_Geolocations_GeolocationId",
                table: "Adress",
                column: "GeolocationId",
                principalTable: "Geolocations",
                principalColumn: "GeolocationId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_Adress_AdressId",
                table: "Applications",
                column: "AdressId",
                principalTable: "Adress",
                principalColumn: "AdressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
