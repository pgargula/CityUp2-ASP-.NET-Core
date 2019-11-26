using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 4,
                column: "ApplicationId",
                value: 2);

            migrationBuilder.InsertData(
                table: "ApplicationPicture",
                columns: new[] { "ApplicationPictureId", "ApplicationId", "PicturePath" },
                values: new object[,]
                {
                    { 5, 1, "https://picsum.photos/500" },
                    { 6, 1, "https://picsum.photos/500" },
                    { 7, 1, "https://picsum.photos/500" },
                    { 8, 3, "https://picsum.photos/500" },
                    { 9, 3, "https://picsum.photos/500" },
                    { 10, 3, "https://picsum.photos/500" },
                    { 11, 3, "https://picsum.photos/500" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "ApplicationPicture",
                keyColumn: "ApplicationPictureId",
                keyValue: 4,
                column: "ApplicationId",
                value: 3);
        }
    }
}
