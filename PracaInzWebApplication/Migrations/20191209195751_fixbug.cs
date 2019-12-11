using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class fixbug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 9, 20, 59, 51, 103, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 9, 21, 1, 51, 103, DateTimeKind.Local).AddTicks(2945));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 9, 21, 3, 51, 103, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 9, 21, 4, 51, 103, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 9, 21, 5, 51, 103, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 9, 20, 57, 51, 99, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 9, 22, 57, 51, 102, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 9, 20, 57, 51, 102, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 9, 21, 1, 51, 102, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 9, 21, 8, 51, 102, DateTimeKind.Local).AddTicks(8602));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 18, 21, 684, DateTimeKind.Local).AddTicks(2266));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 20, 21, 684, DateTimeKind.Local).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 22, 21, 684, DateTimeKind.Local).AddTicks(3218));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 23, 21, 684, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 24, 21, 684, DateTimeKind.Local).AddTicks(3227));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 16, 21, 679, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2019, 12, 7, 4, 16, 21, 683, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 16, 21, 683, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 20, 21, 683, DateTimeKind.Local).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2019, 12, 7, 2, 27, 21, 683, DateTimeKind.Local).AddTicks(7106));
        }
    }
}
