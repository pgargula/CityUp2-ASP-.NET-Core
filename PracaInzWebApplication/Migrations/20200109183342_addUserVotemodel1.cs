using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class addUserVotemodel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserVote_Applications_ApplicationId",
                table: "UserVote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserVote",
                table: "UserVote");

            migrationBuilder.RenameTable(
                name: "UserVote",
                newName: "userVotes");

            migrationBuilder.RenameIndex(
                name: "IX_UserVote_ApplicationId",
                table: "userVotes",
                newName: "IX_userVotes_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userVotes",
                table: "userVotes",
                column: "UserVoteId");

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 35, 40, 703, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 37, 40, 703, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 39, 40, 703, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 40, 40, 703, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "CommentResponses",
                keyColumn: "CommentResponseId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 41, 40, 703, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 33, 40, 700, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2020, 1, 9, 21, 33, 40, 703, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 33, 40, 703, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 37, 40, 703, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 5,
                column: "Date",
                value: new DateTime(2020, 1, 9, 19, 44, 40, 703, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.AddForeignKey(
                name: "FK_userVotes_Applications_ApplicationId",
                table: "userVotes",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userVotes_Applications_ApplicationId",
                table: "userVotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userVotes",
                table: "userVotes");

            migrationBuilder.RenameTable(
                name: "userVotes",
                newName: "UserVote");

            migrationBuilder.RenameIndex(
                name: "IX_userVotes_ApplicationId",
                table: "UserVote",
                newName: "IX_UserVote_ApplicationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserVote",
                table: "UserVote",
                column: "UserVoteId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_UserVote_Applications_ApplicationId",
                table: "UserVote",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "ApplicationId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
