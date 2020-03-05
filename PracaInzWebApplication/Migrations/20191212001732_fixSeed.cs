using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class fixSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 19, 31, 587, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 21, 31, 587, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 23, 31, 587, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 24, 31, 587, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 25, 31, 587, DateTimeKind.Local).AddTicks(4235));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 17, 31, 583, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 12, 3, 17, 31, 586, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 17, 31, 586, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 21, 31, 586, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 28, 31, 586, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 27,
                column: "Name",
                value: "agresywne");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 28,
                column: "Name",
                value: "agresywny");

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[] { 38, "kosza" });

            migrationBuilder.UpdateData(
                table: "TagCategories",
                keyColumn: "TagCategoryId",
                keyValue: 1,
                column: "TagId",
                value: 38);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TagCategories",
                keyColumn: "TagCategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 38);

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 10, 11, 74, DateTimeKind.Local).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 12, 11, 74, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 14, 11, 74, DateTimeKind.Local).AddTicks(8342));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 15, 11, 74, DateTimeKind.Local).AddTicks(8347));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 16, 11, 74, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 8, 11, 70, DateTimeKind.Local).AddTicks(7530));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 12, 1, 8, 11, 74, DateTimeKind.Local).AddTicks(3756));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 8, 11, 74, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 12, 11, 74, DateTimeKind.Local).AddTicks(3849));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 11, 23, 19, 11, 74, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.InsertData(
                table: "TagCategories",
                columns: new[] { "TagCategoryId", "CategoryId", "TagId" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 27,
                column: "Name",
                value: "agresyne");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "TagId",
                keyValue: 28,
                column: "Name",
                value: "agresyny");
        }
    }
}
