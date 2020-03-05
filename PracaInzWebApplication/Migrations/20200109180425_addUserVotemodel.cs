using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class addUserVotemodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Score",
                table: "Applications");

            migrationBuilder.CreateTable(
                name: "UserVote",
                columns: table => new
                {
                    UserVoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserVote", x => x.UserVoteId);
                    table.ForeignKey(
                        name: "FK_UserVote_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 6, 22, 840, DateTimeKind.Local).AddTicks(2062));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 8, 22, 840, DateTimeKind.Local).AddTicks(3103));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 10, 22, 840, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 11, 22, 840, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 12, 22, 840, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 4, 22, 820, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 9, 21, 4, 22, 839, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 4, 22, 839, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 8, 22, 839, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 15, 22, 839, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.InsertData(
                table: "UserVote",
                columns: new[] { "UserVoteId", "ApplicationId", "UserId" },
                values: new object[,]
                {
                    { 21, 6, 5 },
                    { 20, 6, 4 },
                    { 19, 6, 3 },
                    { 18, 6, 2 },
                    { 17, 6, 1 },
                    { 16, 5, 2 },
                    { 14, 4, 3 },
                    { 13, 4, 2 },
                    { 12, 4, 1 },
                    { 11, 3, 4 },
                    { 10, 3, 3 },
                    { 9, 3, 2 },
                    { 8, 3, 1 },
                    { 7, 2, 3 },
                    { 6, 2, 2 },
                    { 5, 1, 5 },
                    { 4, 1, 4 },
                    { 3, 1, 3 },
                    { 2, 1, 2 },
                    { 15, 5, 1 },
                    { 1, 1, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserVote_ApplicationId",
                table: "UserVote",
                column: "ApplicationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserVote");

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 1,
                column: "Score",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 2,
                column: "Score",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Applications",
                keyColumn: "ApplicationId",
                keyValue: 3,
                column: "Score",
                value: 24);

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
    }
}
