using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class fixDbSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationPicture_Applications_ApplicationId",
                table: "ApplicationPicture");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationPicture",
                table: "ApplicationPicture");

            migrationBuilder.RenameTable(
                name: "ApplicationPicture",
                newName: "ApplicationPictures");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationPicture_ApplicationId",
                table: "ApplicationPictures",
                newName: "IX_ApplicationPictures_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationPictures",
                table: "ApplicationPictures",
                column: "ApplicationPictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationPictures_Applications_ApplicationId",
                table: "ApplicationPictures",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApplicationPictures_Applications_ApplicationId",
                table: "ApplicationPictures");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationPictures",
                table: "ApplicationPictures");

            migrationBuilder.RenameTable(
                name: "ApplicationPictures",
                newName: "ApplicationPicture");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationPictures_ApplicationId",
                table: "ApplicationPicture",
                newName: "IX_ApplicationPicture_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationPicture",
                table: "ApplicationPicture",
                column: "ApplicationPictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_ApplicationPicture_Applications_ApplicationId",
                table: "ApplicationPicture",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
