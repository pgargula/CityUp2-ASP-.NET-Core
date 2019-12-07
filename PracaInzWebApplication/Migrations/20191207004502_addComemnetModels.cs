using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class addComemnetModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApplicationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CommentResponses",
                columns: table => new
                {
                    CommentResponseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommentResponses", x => x.CommentResponseId);
                    table.ForeignKey(
                        name: "FK_CommentResponses_Comments_CommentId",
                        column: x => x.CommentId,
                        principalTable: "Comments",
                        principalColumn: "CommentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommentResponses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "ApplicationId", "Date", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 12, 7, 1, 45, 1, 544, DateTimeKind.Local).AddTicks(3585), "fajne", 3 },
                    { 2, 1, new DateTime(2019, 12, 7, 3, 45, 1, 548, DateTimeKind.Local).AddTicks(5591), "Lorem ipsum", 2 },
                    { 3, 1, new DateTime(2019, 12, 7, 1, 45, 1, 548, DateTimeKind.Local).AddTicks(5727), "Cracovia rządzi w krakowie", 3 },
                    { 4, 1, new DateTime(2019, 12, 7, 1, 49, 1, 548, DateTimeKind.Local).AddTicks(5736), "Legia to stara...", 2 },
                    { 5, 1, new DateTime(2019, 12, 7, 1, 56, 1, 548, DateTimeKind.Local).AddTicks(5769), "dobre pomarańczowe", 3 }
                });

            migrationBuilder.InsertData(
                table: "CommentResponses",
                columns: new[] { "CommentResponseId", "CommentId", "Date", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 12, 7, 1, 47, 1, 549, DateTimeKind.Local).AddTicks(672), "dzięki", 2 },
                    { 2, 1, new DateTime(2019, 12, 7, 1, 49, 1, 549, DateTimeKind.Local).AddTicks(1633), "spoko", 3 },
                    { 3, 2, new DateTime(2019, 12, 7, 1, 51, 1, 549, DateTimeKind.Local).AddTicks(1670), "lolo", 2 },
                    { 4, 3, new DateTime(2019, 12, 7, 1, 52, 1, 549, DateTimeKind.Local).AddTicks(1680), "dasdasd", 2 },
                    { 5, 4, new DateTime(2019, 12, 7, 1, 53, 1, 549, DateTimeKind.Local).AddTicks(1684), "afafasfa", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommentResponses_CommentId",
                table: "CommentResponses",
                column: "CommentId");

            migrationBuilder.CreateIndex(
                name: "IX_CommentResponses_UserId",
                table: "CommentResponses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ApplicationId",
                table: "Comments",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommentResponses");

            migrationBuilder.DropTable(
                name: "Comments");
        }
    }
}
