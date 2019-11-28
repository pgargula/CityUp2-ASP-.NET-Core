using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class updateModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "Geolocations",
                columns: table => new
                {
                    GeolocationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geolocations", x => x.GeolocationId);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    StatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.StatusId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adress",
                columns: table => new
                {
                    AdressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityId = table.Column<int>(nullable: false),
                    DistrictId = table.Column<int>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    GeolocationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adress", x => x.AdressId);
                    table.ForeignKey(
                        name: "FK_Adress_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adress_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adress_Geolocations_GeolocationId",
                        column: x => x.GeolocationId,
                        principalTable: "Geolocations",
                        principalColumn: "GeolocationId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    AdressId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Titlle = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Adress_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Adress",
                        principalColumn: "AdressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "StatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Applications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationPicture",
                columns: table => new
                {
                    ApplicationPictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PicturePath = table.Column<string>(nullable: true),
                    ApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPicture", x => x.ApplicationPictureId);
                    table.ForeignKey(
                        name: "FK_ApplicationPicture_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 1, "Zaniszczenie" },
                    { 2, "Inicjatywa" },
                    { 3, "Inne" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "Name" },
                values: new object[,]
                {
                    { 1, "Kraków" },
                    { 2, "Kurów" },
                    { 3, "Warszawa" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Label" },
                values: new object[,]
                {
                    { 1, "1" },
                    { 2, "2" }
                });

            migrationBuilder.InsertData(
                table: "Adress",
                columns: new[] { "AdressId", "CityId", "DistrictId", "GeolocationId", "Street" },
                values: new object[,]
                {
                    { 1, 1, null, null, "Jagielońska" },
                    { 2, 1, null, null, "Kujawska" },
                    { 4, 1, null, null, "Siemaszki" },
                    { 3, 2, null, null, "Tarnowska" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CityId", "Email", "Login", "Password", "Role" },
                values: new object[,]
                {
                    { 1, 1, "admin@test.pl", "admin", "admin", "SystemAdministrator" },
                    { 2, 1, "user@test.pl", "user", "user", "User" },
                    { 3, 1, "user2@test.pl", "user2", "user", "User" },
                    { 4, 1, "cityadmin@test.pl", "cityadmin", "cityadmin", "CityAdministrator" },
                    { 5, 1, "citymoderator@test.pl", "citymoderator", "citymoderator", "CityModerator" }
                });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "AdressId", "CategoryId", "Description", "StatusId", "Titlle", "UserId" },
                values: new object[] { 1, 1, 1, "fasfa", 1, null, 2 });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "AdressId", "CategoryId", "Description", "StatusId", "Titlle", "UserId" },
                values: new object[] { 2, 2, 2, "facascsfa", 2, null, 2 });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "AdressId", "CategoryId", "Description", "StatusId", "Titlle", "UserId" },
                values: new object[] { 3, 4, 3, "fasfasfqfasfa", 1, null, 3 });

            migrationBuilder.InsertData(
                table: "ApplicationPicture",
                columns: new[] { "ApplicationPictureId", "ApplicationId", "PicturePath" },
                values: new object[,]
                {
                    { 1, 1, "https://mpi.krakow.pl/zalacznik/320782/4.jpg" },
                    { 2, 2, "https://fajnepodroze.pl/wp-content/uploads/2018/01/krakow.jpg" },
                    { 3, 2, "https://czasnawywczas.pl/wp-content/uploads/krakow-budynki.jpg" },
                    { 4, 3, "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adress_CityId",
                table: "Adress",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Adress_DistrictId",
                table: "Adress",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Adress_GeolocationId",
                table: "Adress",
                column: "GeolocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPicture_ApplicationId",
                table: "ApplicationPicture",
                column: "ApplicationId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_AdressId",
                table: "Applications",
                column: "AdressId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_CategoryId",
                table: "Applications",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_StatusId",
                table: "Applications",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Applications_UserId",
                table: "Applications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationPicture");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Adress");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Geolocations");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
