using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class fixApliationModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Titlle",
                table: "Applications");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Applications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "Applications");

            migrationBuilder.AddColumn<string>(
                name: "Titlle",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
