using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class addSalttoUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Salt",
                table: "Users",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 45, 51, 783, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 47, 51, 783, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 49, 51, 783, DateTimeKind.Local).AddTicks(9202));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 50, 51, 783, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 51, 51, 783, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 43, 51, 780, DateTimeKind.Local).AddTicks(8308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 12, 20, 43, 51, 783, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 43, 51, 783, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 47, 51, 783, DateTimeKind.Local).AddTicks(5208));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 12, 18, 54, 51, 783, DateTimeKind.Local).AddTicks(5227));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salt",
                table: "Users");

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
        }
    }
}
