using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class addApplicationFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdminMsg",
                table: "Applications",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Applications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                columns: new[] { "AdminMsg", "Score" },
                values: new object[] { "brak wiadomości", 22 });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                columns: new[] { "AdminMsg", "Score" },
                values: new object[] { "brak wiadomości", 12 });

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                columns: new[] { "AdminMsg", "Score" },
                values: new object[] { "brak wiadomości", 24 });

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 20, 0, 594, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 22, 0, 594, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 24, 0, 594, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 25, 0, 594, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 26, 0, 594, DateTimeKind.Local).AddTicks(5613));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 18, 0, 590, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 17, 17, 18, 0, 593, DateTimeKind.Local).AddTicks(9436));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 18, 0, 593, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 22, 0, 593, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 17, 15, 29, 0, 593, DateTimeKind.Local).AddTicks(9823));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdminMsg",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Applications");

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
    }
}
