using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PracaInzWebApplication.Migrations
{
    public partial class create : Migration
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
                name: "CensoredWords",
                columns: table => new
                {
                    CensoredWordId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Word = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CensoredWords", x => x.CensoredWordId);
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
                name: "Tags",
                columns: table => new
                {
                    TagId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    GeolocationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Geolocations_GeolocationId",
                        column: x => x.GeolocationId,
                        principalTable: "Geolocations",
                        principalColumn: "GeolocationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TagCategories",
                columns: table => new
                {
                    TagCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TagCategories", x => x.TagCategoryId);
                    table.ForeignKey(
                        name: "FK_TagCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TagCategories_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "TagId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Adresses",
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
                    table.PrimaryKey("PK_Adresses", x => x.AdressId);
                    table.ForeignKey(
                        name: "FK_Adresses_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Adresses_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Adresses_Geolocations_GeolocationId",
                        column: x => x.GeolocationId,
                        principalTable: "Geolocations",
                        principalColumn: "GeolocationId",
                        onDelete: ReferentialAction.Restrict);
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
                name: "Applications",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    AdressId = table.Column<int>(nullable: false),
                    StatusId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Applications", x => x.ApplicationId);
                    table.ForeignKey(
                        name: "FK_Applications_Adresses_AdressId",
                        column: x => x.AdressId,
                        principalTable: "Adresses",
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
                name: "ApplicationPictures",
                columns: table => new
                {
                    ApplicationPictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PicturePath = table.Column<string>(nullable: true),
                    ApplicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationPictures", x => x.ApplicationPictureId);
                    table.ForeignKey(
                        name: "FK_ApplicationPictures_Applications_ApplicationId",
                        column: x => x.ApplicationId,
                        principalTable: "Applications",
                        principalColumn: "ApplicationId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[,]
                {
                    { 4, "Inicjatywa" },
                    { 5, "Inne" },
                    { 1, "Zanieczyszczenie" },
                    { 2, "Zagrożenie" },
                    { 3, "Awaria" }
                });

            migrationBuilder.InsertData(
                table: "CensoredWords",
                columns: new[] { "CensoredWordId", "Word" },
                values: new object[,]
                {
                    { 414, "spierdalała" },
                    { 415, "spierdalal" },
                    { 416, "spierdalalcie" },
                    { 417, "spierdalala" },
                    { 418, "spierdalający" },
                    { 419, "spierdalajacy" },
                    { 420, "spierdolić" },
                    { 423, "spierdoliła" },
                    { 422, "spierdoli" },
                    { 413, "spierdalał" },
                    { 424, "spierdoliło" },
                    { 425, "spierdolą" },
                    { 426, "spierdola" },
                    { 427, "srać" },
                    { 428, "srac" },
                    { 421, "spierdolic" },
                    { 412, "spierdala" },
                    { 409, "spieprzajaca" },
                    { 410, "spierdalać" },
                    { 394, "skurwysyny" },
                    { 395, "skurwysyński" },
                    { 396, "skurwysynski" },
                    { 397, "skurwysyństwo" },
                    { 398, "skurwysynstwo" },
                    { 399, "spieprzać" },
                    { 400, "spieprzac" },
                    { 411, "spierdalac" },
                    { 401, "spieprza" },
                    { 403, "spieprzajcie" },
                    { 404, "spieprzają" },
                    { 405, "spieprzaja" },
                    { 406, "spieprzający" },
                    { 407, "spieprzajacy" },
                    { 408, "spieprzająca" },
                    { 429, "srający" },
                    { 402, "spieprzaj" },
                    { 430, "srajacy" },
                    { 432, "srajac" },
                    { 393, "skurwysynu" },
                    { 453, "upierdala" },
                    { 454, "upierdoli" },
                    { 455, "upierdolić" },
                    { 456, "upierdolic" },
                    { 457, "upierdoli" },
                    { 458, "upierdolą" },
                    { 459, "upierdola" },
                    { 460, "upierdoleni" },
                    { 461, "wjebać" },
                    { 462, "wjebac" },
                    { 463, "wjebie" },
                    { 464, "wjebią" },
                    { 465, "wjebia" },
                    { 466, "wjebiemy" },
                    { 467, "wjebiecie" },
                    { 452, "upierdalac" },
                    { 451, "upierdalać" },
                    { 450, "ujebala" },
                    { 449, "ujebała" },
                    { 433, "sraj" },
                    { 434, "sukinsyn" },
                    { 435, "sukinsyny" },
                    { 436, "sukinsynom" },
                    { 437, "sukinsynowi" },
                    { 438, "sukinsynów" },
                    { 439, "sukinsynow" },
                    { 431, "srając" },
                    { 440, "śmierdziel" },
                    { 442, "ujebać" },
                    { 443, "ujebac" },
                    { 444, "ujebał" },
                    { 445, "ujebal" },
                    { 446, "ujebana" },
                    { 447, "ujebany" },
                    { 448, "ujebie" },
                    { 441, "udupić" },
                    { 392, "skurwysynem" },
                    { 390, "skurwysynow" },
                    { 468, "wkurwiać" },
                    { 336, "przejebane" },
                    { 337, "przejebac" },
                    { 338, "przyjebali" },
                    { 339, "przepierdalać" },
                    { 340, "przepierdalac" },
                    { 341, "przepierdala" },
                    { 342, "przepierdalający" },
                    { 343, "przepierdalajacy" },
                    { 344, "przepierdalająca" },
                    { 345, "przepierdalajaca" },
                    { 346, "przepierdolić" },
                    { 347, "przepierdolic" },
                    { 348, "przyjebać" },
                    { 349, "przyjebac" },
                    { 350, "przyjebie" },
                    { 334, "poruchać" },
                    { 333, "poruchac" },
                    { 332, "porozpierdalac" },
                    { 331, "porozpierdala" },
                    { 315, "pojebać" },
                    { 316, "pojebac" },
                    { 317, "pojebalo" },
                    { 318, "popierdala" },
                    { 319, "popierdalac" },
                    { 320, "popierdalać" },
                    { 321, "popierdolić" },
                    { 351, "przyjebała" },
                    { 322, "popierdolic" },
                    { 324, "popierdolonego" },
                    { 325, "popierdolonemu" },
                    { 326, "popierdolonym" },
                    { 327, "popierdolone" },
                    { 328, "popierdoleni" },
                    { 329, "popierdolony" },
                    { 330, "porozpierdalać" },
                    { 323, "popierdoli" },
                    { 391, "skurwysyna" },
                    { 352, "przyjebala" },
                    { 354, "przyjebal" },
                    { 375, "rozpierdalać" },
                    { 376, "rozpierdalac" },
                    { 377, "rozpierdala" },
                    { 378, "rozpierdolić" },
                    { 379, "rozpierdolic" },
                    { 380, "rozpierdole" },
                    { 381, "rozpierdoli" },
                    { 382, "rozpierducha" },
                    { 383, "skurwić" },
                    { 384, "skurwiel" },
                    { 385, "skurwiela" },
                    { 386, "skurwielem" },
                    { 387, "skurwielu" },
                    { 388, "skurwysyn" },
                    { 389, "skurwysynów" },
                    { 374, "rozjebią" },
                    { 373, "rozjebała" },
                    { 372, "rozjebie" },
                    { 371, "rozjebac" },
                    { 355, "przypieprzać" },
                    { 356, "przypieprzac" },
                    { 357, "przypieprzający" },
                    { 358, "przypieprzajacy" },
                    { 359, "przypieprzająca" },
                    { 360, "przypieprzajaca" },
                    { 361, "przypierdalać" },
                    { 353, "przyjebał" },
                    { 362, "przypierdalac" },
                    { 364, "przypierdoli" },
                    { 365, "przypierdalający" },
                    { 366, "przypierdalajacy" },
                    { 367, "przypierdolić" },
                    { 368, "przypierdolic" },
                    { 369, "qrwa" },
                    { 370, "rozjebać" },
                    { 363, "przypierdala" },
                    { 469, "wkurwiac" },
                    { 472, "wkurwiał" },
                    { 471, "wkurwia" },
                    { 571, "zajebiście" },
                    { 572, "zajebiscie" },
                    { 573, "zapieprzyć" },
                    { 574, "zapieprzyc" },
                    { 575, "zapieprzy" },
                    { 576, "zapieprzył" },
                    { 577, "zapieprzyl" },
                    { 578, "zapieprzyła" },
                    { 579, "zapieprzyla" },
                    { 580, "zapieprzą" },
                    { 581, "zapieprza" },
                    { 582, "zapieprzy" },
                    { 583, "zapieprzymy" },
                    { 584, "zapieprzycie" },
                    { 585, "zapieprzysz" },
                    { 570, "zajebistymi" },
                    { 569, "zajebistym" },
                    { 568, "zajebista" },
                    { 567, "zajebistych" },
                    { 551, "zajebią" },
                    { 552, "zajebia" },
                    { 553, "zajebiał" },
                    { 554, "zajebial" },
                    { 555, "zajebała" },
                    { 556, "zajebiala" },
                    { 557, "zajebali" },
                    { 586, "zapierdala" },
                    { 558, "zajebana" },
                    { 560, "zajebane" },
                    { 561, "zajebany" },
                    { 562, "zajebanych" },
                    { 563, "zajebanym" },
                    { 564, "zajebanymi" },
                    { 565, "zajebiste" },
                    { 566, "zajebisty" },
                    { 559, "zajebani" },
                    { 550, "zajebie" },
                    { 587, "zapierdalać" },
                    { 589, "zapierdalaja" },
                    { 610, "zasranym" },
                    { 611, "zasrywać" },
                    { 612, "zasrywający" },
                    { 613, "zesrywać" },
                    { 614, "zesrywający" },
                    { 615, "zjebać" },
                    { 616, "zjebac" },
                    { 617, "zjebał" },
                    { 618, "zjebal" },
                    { 619, "zjebała" },
                    { 620, "zjebala" },
                    { 621, "zjebana" },
                    { 622, "zjebią" },
                    { 623, "zjebali" },
                    { 624, "zjeby" },
                    { 609, "zasrać" },
                    { 608, "zapierniczający" },
                    { 607, "zapierniczać" },
                    { 606, "zapierdola" },
                    { 590, "zapierdalał" },
                    { 591, "zapierdalaj" },
                    { 592, "zapierdalajcie" },
                    { 593, "zapierdalała" },
                    { 594, "zapierdalala" },
                    { 595, "zapierdalali" },
                    { 596, "zapierdalający" },
                    { 588, "zapierdalac" },
                    { 597, "zapierdalajacy" },
                    { 599, "zapierdolic" },
                    { 600, "zapierdoli" },
                    { 601, "zapierdolił" },
                    { 602, "zapierdolil" },
                    { 603, "zapierdoliła" },
                    { 604, "zapierdolila" },
                    { 605, "zapierdolą" },
                    { 598, "zapierdolić" },
                    { 549, "zajebac" },
                    { 548, "zajebać" },
                    { 547, "wypierdolila" },
                    { 492, "wpierdalać" },
                    { 493, "wpierdalac" },
                    { 494, "wpierdalający" },
                    { 495, "wpierdalajacy" },
                    { 496, "wpierdol" },
                    { 497, "wpierdolić" },
                    { 498, "wpierdolic" },
                    { 499, "wpizdu" },
                    { 500, "wyjebać" },
                    { 501, "wyjebac" },
                    { 502, "wyjebali" },
                    { 503, "wyjebał" },
                    { 504, "wyjebac" },
                    { 505, "wyjebała" },
                    { 506, "wyjebały" },
                    { 491, "wkurwia" },
                    { 490, "wkurwic" },
                    { 489, "wkurwić" },
                    { 488, "wkurwiacie" },
                    { 314, "pojebem" },
                    { 473, "wkurwial" },
                    { 474, "wkurwiający" },
                    { 475, "wkurwiajacy" },
                    { 476, "wkurwiająca" },
                    { 477, "wkurwiajaca" },
                    { 478, "wkurwić" },
                    { 507, "wyjebie" },
                    { 479, "wkurwic" },
                    { 481, "wkurwiacie" },
                    { 482, "wkurwiają" },
                    { 483, "wkurwiali" },
                    { 484, "wkurwią" },
                    { 485, "wkurwia" },
                    { 486, "wkurwimy" },
                    { 487, "wkurwicie" },
                    { 480, "wkurwi" },
                    { 508, "wyjebią" },
                    { 509, "wyjebia" },
                    { 510, "wyjebiesz" },
                    { 531, "wypierdalał" },
                    { 532, "wypierdalal" },
                    { 533, "wypierdalała" },
                    { 534, "wypierdalala" },
                    { 535, "wypierdalać" },
                    { 536, "wypierdolić" },
                    { 537, "wypierdolic" },
                    { 530, "wypierdalaj" },
                    { 538, "wypierdoli" },
                    { 540, "wypierdolicie" },
                    { 541, "wypierdolą" },
                    { 542, "wypierdola" },
                    { 543, "wypierdolili" },
                    { 544, "wypierdolił" },
                    { 545, "wypierdolil" },
                    { 546, "wypierdoliła" },
                    { 539, "wypierdolimy" },
                    { 470, "wkurwi" },
                    { 529, "wypierdala" },
                    { 527, "wypierdalać" },
                    { 511, "wyjebie" },
                    { 512, "wyjebiecie" },
                    { 513, "wyjebiemy" },
                    { 514, "wypieprzać" },
                    { 515, "wypieprzac" },
                    { 516, "wypieprza" },
                    { 517, "wypieprzał" },
                    { 528, "wypierdalac" },
                    { 518, "wypieprzal" },
                    { 520, "wypieprzala" },
                    { 521, "wypieprzy" },
                    { 522, "wypieprzyła" },
                    { 523, "wypieprzyla" },
                    { 524, "wypieprzył" },
                    { 525, "wypieprzyl" },
                    { 526, "wypierdal" },
                    { 519, "wypieprzała" },
                    { 313, "pojebanymi" },
                    { 335, "przejebać" },
                    { 311, "pojebanych" },
                    { 100, "jebnąć" },
                    { 101, "jebnac" },
                    { 102, "jebnąc" },
                    { 103, "jebnać" },
                    { 104, "jebnął" },
                    { 105, "jebnal" },
                    { 106, "jebną" },
                    { 107, "jebna" },
                    { 108, "jebnęła" },
                    { 109, "jebnela" },
                    { 110, "jebnie" },
                    { 111, "jebnij" },
                    { 112, "jebut" },
                    { 113, "koorwa" },
                    { 114, "kórwa" },
                    { 99, "jebliwy" },
                    { 98, "jebię" },
                    { 97, "jebie" },
                    { 96, "jebią" },
                    { 80, "jebanej" },
                    { 81, "jebaną" },
                    { 82, "jebana" },
                    { 83, "jebani" },
                    { 84, "jebanych" },
                    { 85, "jebanymi" },
                    { 86, "jebcie" },
                    { 115, "kurestwo" },
                    { 87, "jebiący" },
                    { 89, "jebiąca" },
                    { 90, "jebiaca" },
                    { 91, "jebiącego" },
                    { 92, "jebiacego" },
                    { 93, "jebiącej" },
                    { 94, "jebiacej" },
                    { 95, "jebia" },
                    { 88, "jebiacy" },
                    { 79, "jebanym" },
                    { 116, "kurew" },
                    { 118, "kurewska" },
                    { 139, "kurwica" },
                    { 140, "kurwić" },
                    { 141, "kurwic" },
                    { 142, "kurwidołek" },
                    { 143, "kurwik" },
                    { 144, "kurwiki" },
                    { 145, "kurwiszcze" },
                    { 146, "kurwiszon" },
                    { 147, "kurwiszona" },
                    { 148, "kurwiszonem" },
                    { 149, "kurwiszony" },
                    { 150, "kutas" },
                    { 151, "kutasa" },
                    { 152, "kutasie" },
                    { 153, "kutasem" },
                    { 138, "kurwiący" },
                    { 137, "kurwiarz" },
                    { 136, "kurewski" },
                    { 135, "kurwami" },
                    { 119, "kurewskiej" },
                    { 120, "kurewską" },
                    { 121, "kurewska" },
                    { 122, "kurewsko" },
                    { 123, "kurewstwo" },
                    { 124, "kurwa" },
                    { 125, "kurwaa" },
                    { 117, "kurewski" },
                    { 126, "kurwami" },
                    { 128, "kurwe" },
                    { 129, "kurwę" },
                    { 130, "kurwie" },
                    { 131, "kurwiska" },
                    { 312, "pojebanym" },
                    { 133, "kurwy" },
                    { 134, "kurwach" },
                    { 127, "kurwą" },
                    { 78, "jebana" },
                    { 77, "jebanymi" },
                    { 76, "jebankiem" },
                    { 21, "dojebala" },
                    { 22, "dojebałem" },
                    { 23, "dojebalem" },
                    { 24, "dojebałam" },
                    { 25, "dojebalam" },
                    { 26, "dojebię" },
                    { 27, "dojebie" },
                    { 28, "dopieprzać" },
                    { 29, "dopieprzac" },
                    { 30, "dopierdalać" },
                    { 31, "dopierdalac" },
                    { 32, "dopierdala" },
                    { 33, "dopierdalał" },
                    { 34, "dopierdalal" },
                    { 35, "dopierdalała" },
                    { 20, "dojebała" },
                    { 19, "dojebal" },
                    { 18, "dojebał" },
                    { 17, "dojebie" },
                    { 1, "chuj" },
                    { 2, "chuja" },
                    { 3, "chujek" },
                    { 4, "chuju" },
                    { 5, "chujem" },
                    { 6, "chujnia" },
                    { 7, "chujowy" },
                    { 36, "dopierdalala" },
                    { 8, "chujowa" },
                    { 10, "cipa" },
                    { 11, "cipę" },
                    { 12, "cipe" },
                    { 13, "cipą" },
                    { 14, "cipie" },
                    { 15, "dojebać" },
                    { 16, "dojebac" },
                    { 9, "chujowe" },
                    { 37, "dopierdoli" },
                    { 38, "dopierdolił" },
                    { 39, "dopierdolil" },
                    { 60, "huju" },
                    { 61, "jebać" },
                    { 62, "jebac" },
                    { 63, "jebał" },
                    { 64, "jebal" },
                    { 65, "jebie" },
                    { 66, "jebią" },
                    { 59, "hujem" },
                    { 67, "jebia" },
                    { 69, "jebaka" },
                    { 70, "jebal" },
                    { 71, "jebał" },
                    { 72, "jebany" },
                    { 73, "jebane" },
                    { 74, "jebanka" },
                    { 75, "jebanko" },
                    { 68, "jebak" },
                    { 154, "kutasy" },
                    { 58, "huje" },
                    { 56, "hujnia" },
                    { 40, "dopierdolę" },
                    { 41, "dopierdole" },
                    { 42, "dopierdoli" },
                    { 43, "dopierdalający" },
                    { 44, "dopierdalajacy" },
                    { 45, "dopierdolić" },
                    { 46, "dopierdolic" },
                    { 57, "huja" },
                    { 47, "dupa" },
                    { 49, "dupą" },
                    { 50, "dupcia" },
                    { 51, "dupeczka" },
                    { 52, "dupy" },
                    { 53, "dupe" },
                    { 54, "huj" },
                    { 55, "hujek" },
                    { 48, "dupie" },
                    { 155, "kutasów" },
                    { 132, "kurwo" },
                    { 157, "kutasach" },
                    { 257, "pierdolą" },
                    { 258, "pierdolić" },
                    { 156, "kutasow" },
                    { 260, "pierdolic" },
                    { 261, "pierdolił" },
                    { 262, "pierdolil" },
                    { 263, "pierdoliła" },
                    { 264, "pierdolila" },
                    { 265, "pierdoli" },
                    { 266, "pierdolnięty" },
                    { 267, "pierdolniety" },
                    { 268, "pierdolisz" },
                    { 269, "pierdolnąć" },
                    { 270, "pierdolnac" },
                    { 271, "pierdolnął" },
                    { 256, "pierdola" },
                    { 255, "pierdolec" },
                    { 254, "pierdolę" },
                    { 253, "pierdoleniu" },
                    { 237, "piczka" },
                    { 238, "pieprznięty" },
                    { 239, "pieprzniety" },
                    { 240, "pieprzony" },
                    { 241, "pierdel" },
                    { 242, "pierdlu" },
                    { 243, "pierdolą" },
                    { 272, "pierdolnal" },
                    { 244, "pierdola" },
                    { 246, "pierdolacy" },
                    { 247, "pierdoląca" },
                    { 248, "pierdolaca" },
                    { 249, "pierdol" },
                    { 250, "pierdole" },
                    { 251, "pierdolenie" },
                    { 252, "pierdoleniem" },
                    { 245, "pierdolący" },
                    { 236, "opierdola" },
                    { 273, "pierdolnęła" },
                    { 275, "pierdolnie" },
                    { 296, "podpierdalac" },
                    { 297, "podpierdala" },
                    { 298, "podpierdalający" },
                    { 299, "podpierdalajacy" },
                    { 300, "podpierdolić" },
                    { 301, "podpierdolic" },
                    { 302, "podpierdoli" },
                    { 303, "pojeb" },
                    { 304, "pojeba" },
                    { 305, "pojebami" },
                    { 306, "pojebani" },
                    { 307, "pojebanego" },
                    { 308, "pojebanemu" },
                    { 309, "pojebani" },
                    { 310, "pojebany" },
                    { 295, "podpierdalać" },
                    { 294, "pizdu" },
                    { 293, "pizdnac" },
                    { 292, "pizdnąć" },
                    { 276, "pierdolnięty" },
                    { 277, "pierdolnij" },
                    { 278, "pierdolnik" },
                    { 279, "pierdolona" },
                    { 280, "pierdolone" },
                    { 281, "pierdolony" },
                    { 282, "pierdołki" },
                    { 274, "pierdolnela" },
                    { 283, "pierdzący" },
                    { 285, "pierdziec" },
                    { 286, "pizda" },
                    { 287, "pizdą" },
                    { 288, "pizde" },
                    { 289, "pizdę" },
                    { 290, "piździe" },
                    { 291, "pizdzie" },
                    { 284, "pierdzieć" },
                    { 235, "opierdolą" },
                    { 259, "pierdolicie" },
                    { 233, "opierdolic" },
                    { 178, "najebia" },
                    { 179, "naopierdalać" },
                    { 180, "naopierdalac" },
                    { 181, "naopierdalał" },
                    { 182, "naopierdalal" },
                    { 183, "naopierdalała" },
                    { 184, "naopierdalala" },
                    { 185, "naopierdalała" },
                    { 186, "napierdalać" },
                    { 187, "napierdalac" },
                    { 188, "napierdalający" },
                    { 189, "napierdalajacy" },
                    { 190, "napierdolić" },
                    { 191, "napierdolic" },
                    { 192, "nawpierdalać" },
                    { 177, "najebią" },
                    { 176, "najebie" },
                    { 175, "najebana" },
                    { 174, "najebaną" },
                    { 158, "kutasami" },
                    { 159, "matkojebca" },
                    { 160, "matkojebcy" },
                    { 161, "matkojebcą" },
                    { 162, "matkojebca" },
                    { 163, "matkojebcami" },
                    { 164, "matkojebcach" },
                    { 193, "nawpierdalac" },
                    { 165, "nabarłożyć" },
                    { 167, "najebac" },
                    { 168, "najebał" },
                    { 169, "najebal" },
                    { 170, "najebała" },
                    { 234, "opierdoli" },
                    { 172, "najebane" },
                    { 173, "najebany" },
                    { 166, "najebać" },
                    { 194, "nawpierdalał" },
                    { 171, "najebala" },
                    { 196, "nawpierdalała" },
                    { 217, "odpierdalający" },
                    { 218, "odpierdalajacy" },
                    { 219, "odpierdalająca" },
                    { 220, "odpierdalajaca" },
                    { 221, "odpierdolić" },
                    { 222, "odpierdolic" },
                    { 223, "odpierdoli" },
                    { 216, "odpierdoli" },
                    { 224, "odpierdolił" },
                    { 226, "opierdalać" },
                    { 227, "opierdalac" },
                    { 228, "opierdala" },
                    { 229, "opierdalający" },
                    { 230, "opierdalajacy" },
                    { 231, "opierdol" },
                    { 232, "opierdolić" },
                    { 225, "opieprzający" },
                    { 195, "nawpierdalal" },
                    { 215, "odpierdolila" },
                    { 213, "odpierdolil" },
                    { 197, "nawpierdalala" },
                    { 198, "obsrywać" },
                    { 199, "obsrywac" },
                    { 200, "obsrywający" },
                    { 201, "obsrywajacy" },
                    { 202, "odpieprzać" },
                    { 203, "odpieprzac" },
                    { 214, "odpierdoliła" },
                    { 204, "odpieprzy" },
                    { 206, "odpieprzyl" },
                    { 207, "odpieprzyła" },
                    { 208, "odpieprzyla" },
                    { 209, "odpierdalać" },
                    { 210, "odpierdalac" },
                    { 211, "odpierdol" },
                    { 212, "odpierdolił" },
                    { 205, "odpieprzył" }
                });

            migrationBuilder.InsertData(
                table: "Geolocations",
                columns: new[] { "GeolocationId", "Latitude", "Longitude" },
                values: new object[,]
                {
                    { 9, 53.054699999999997, 19.600000000000001 },
                    { 8, 55.054699999999997, 18.899999999999999 },
                    { 7, 50.0747, 19.844999999999999 },
                    { 5, 50.064700000000002, 19.914999999999999 },
                    { 6, 50.054699999999997, 19.899999999999999 },
                    { 3, 50.064999999999998, 19.954999999999998 },
                    { 2, 50.164700000000003, 19.945 },
                    { 1, 50.064700000000002, 19.945 },
                    { 4, 50.067700000000002, 19.965 }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "StatusId", "Label" },
                values: new object[,]
                {
                    { 1, "W oczekiwaniu" },
                    { 2, "W realizacji" },
                    { 3, "Zrealizowane" },
                    { 4, "Odzrucone" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "TagId", "Name" },
                values: new object[,]
                {
                    { 21, "działa" },
                    { 22, "działać" },
                    { 23, "źle" },
                    { 24, "niepoprawnie" },
                    { 25, "sygnalizacja" },
                    { 26, "niebezpieczne" },
                    { 27, "agresyne" },
                    { 30, "inicjatywa" },
                    { 29, "zagrożenie" },
                    { 20, "uszkodzone" },
                    { 31, "propozycja" },
                    { 32, "zaproponować" },
                    { 33, "zaplanować" },
                    { 34, "zrobić" },
                    { 35, "wybudować" },
                    { 28, "agresyny" },
                    { 19, "awarie" },
                    { 15, "zepsute" },
                    { 17, "poprawić" },
                    { 36, "zbudować" },
                    { 1, "śmieć" },
                    { 2, "śmieci" },
                    { 3, "kosz" },
                    { 4, "brudno" },
                    { 5, "nieporządek" },
                    { 6, "mpo" },
                    { 18, "awaria" },
                    { 7, "kosze" },
                    { 9, "zanieczyszczenie" },
                    { 10, "smog" },
                    { 11, "ulica" },
                    { 12, "zepsuta" },
                    { 13, "latarnia" },
                    { 14, "popsute" },
                    { 16, "naprawić" },
                    { 8, "odpadki" },
                    { 37, "proponuje" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "GeolocationId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Kraków" },
                    { 2, 8, "Kurów" },
                    { 3, 9, "Warszawa" }
                });

            migrationBuilder.InsertData(
                table: "TagCategories",
                columns: new[] { "TagCategoryId", "CategoryId", "TagId" },
                values: new object[,]
                {
                    { 22, 3, 21 },
                    { 23, 3, 22 },
                    { 24, 3, 23 },
                    { 25, 3, 24 },
                    { 26, 3, 25 },
                    { 27, 3, 26 },
                    { 28, 2, 26 },
                    { 29, 2, 27 },
                    { 30, 2, 28 },
                    { 31, 2, 29 },
                    { 32, 4, 30 },
                    { 33, 4, 31 },
                    { 34, 4, 32 },
                    { 35, 4, 33 },
                    { 36, 4, 34 },
                    { 37, 4, 35 },
                    { 20, 3, 19 },
                    { 19, 3, 18 },
                    { 17, 3, 16 },
                    { 38, 4, 36 },
                    { 1, 1, 1 },
                    { 2, 1, 1 },
                    { 3, 1, 2 },
                    { 4, 1, 3 },
                    { 5, 1, 4 },
                    { 6, 1, 5 },
                    { 7, 1, 6 },
                    { 8, 1, 7 },
                    { 9, 1, 8 },
                    { 10, 1, 9 },
                    { 11, 1, 10 },
                    { 21, 3, 10 },
                    { 12, 1, 11 },
                    { 13, 3, 12 },
                    { 14, 3, 13 },
                    { 15, 3, 14 },
                    { 16, 3, 15 },
                    { 18, 3, 17 },
                    { 39, 4, 37 }
                });

            migrationBuilder.InsertData(
                table: "Adresses",
                columns: new[] { "AdressId", "CityId", "DistrictId", "GeolocationId", "Street" },
                values: new object[,]
                {
                    { 1, 1, null, 5, "Jagielońska" },
                    { 2, 1, null, 4, "Kujawska" },
                    { 4, 1, null, 2, "Siemaszki" },
                    { 3, 2, null, 3, "Tarnowska" }
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
                columns: new[] { "ApplicationId", "AdressId", "CategoryId", "Description", "StatusId", "Title", "UserId" },
                values: new object[] { 1, 1, 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis mollis ex ipsum, sagittis malesuada ante volutpat et. Aenean accumsan, eros ac tristique semper, odio quam convallis sapien, eget fermentum tellus nibh et metus. Etiam rutrum consectetur pretium. Aenean dapibus luctus odio, at eleifend lacus porttitor condimentum. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis. ", 1, "Rozwalony śmietnk", 2 });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "AdressId", "CategoryId", "Description", "StatusId", "Title", "UserId" },
                values: new object[] { 2, 2, 2, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis mollis ex ipsum, sagittis malesuada ante volutpat et. Aenean accumsan, eros ac tristique semper, odio quam convallis sapien, eget fermentum tellus nibh et metus. Etiam rutrum consectetur pretium. Aenean dapibus luctus odio, at eleifend lacus porttitor condimentum. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis. ", 2, "Wrak na poboczu", 2 });

            migrationBuilder.InsertData(
                table: "Applications",
                columns: new[] { "ApplicationId", "AdressId", "CategoryId", "Description", "StatusId", "Title", "UserId" },
                values: new object[] { 3, 4, 3, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis mollis ex ipsum, sagittis malesuada ante volutpat et. Aenean accumsan, eros ac tristique semper, odio quam convallis sapien, eget fermentum tellus nibh et metus. Etiam rutrum consectetur pretium. Aenean dapibus luctus odio, at eleifend lacus porttitor condimentum. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis. ", 1, "Dzikie Psy", 3 });

            migrationBuilder.InsertData(
                table: "ApplicationPictures",
                columns: new[] { "ApplicationPictureId", "ApplicationId", "PicturePath" },
                values: new object[,]
                {
                    { 1, 1, "https://mpi.krakow.pl/zalacznik/320782/4.jpg" },
                    { 5, 1, "https://picsum.photos/500" },
                    { 6, 1, "https://picsum.photos/500" },
                    { 7, 1, "https://picsum.photos/500" },
                    { 2, 2, "https://fajnepodroze.pl/wp-content/uploads/2018/01/krakow.jpg" },
                    { 3, 2, "https://czasnawywczas.pl/wp-content/uploads/krakow-budynki.jpg" },
                    { 4, 2, "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg" },
                    { 8, 3, "https://picsum.photos/500" },
                    { 9, 3, "https://picsum.photos/500" },
                    { 10, 3, "https://picsum.photos/500" },
                    { 11, 3, "https://picsum.photos/500" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "ApplicationId", "Date", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 12, 11, 23, 8, 11, 70, DateTimeKind.Local).AddTicks(7530), "fajne", 3 },
                    { 2, 1, new DateTime(2019, 12, 12, 1, 8, 11, 74, DateTimeKind.Local).AddTicks(3756), "Smietnik jest rozwalony od 2 tygodni", 2 },
                    { 3, 1, new DateTime(2019, 12, 11, 23, 8, 11, 74, DateTimeKind.Local).AddTicks(3840), "Smieci coraz więcej", 3 },
                    { 4, 1, new DateTime(2019, 12, 11, 23, 12, 11, 74, DateTimeKind.Local).AddTicks(3849), "Mam nadzieje że zostanie to szybko usunięte", 2 },
                    { 5, 1, new DateTime(2019, 12, 11, 23, 19, 11, 74, DateTimeKind.Local).AddTicks(3868), "dobre pomarańczowe", 3 }
                });

            migrationBuilder.InsertData(
                table: "CommentResponses",
                columns: new[] { "CommentResponseId", "CommentId", "Date", "Text", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 12, 11, 23, 10, 11, 74, DateTimeKind.Local).AddTicks(7558), "dzięki", 2 },
                    { 2, 1, new DateTime(2019, 12, 11, 23, 12, 11, 74, DateTimeKind.Local).AddTicks(8319), "spoko", 3 },
                    { 3, 2, new DateTime(2019, 12, 11, 23, 14, 11, 74, DateTimeKind.Local).AddTicks(8342), "lolo", 2 },
                    { 4, 3, new DateTime(2019, 12, 11, 23, 15, 11, 74, DateTimeKind.Local).AddTicks(8347), "test", 2 },
                    { 5, 4, new DateTime(2019, 12, 11, 23, 16, 11, 74, DateTimeKind.Local).AddTicks(8352), "test", 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_CityId",
                table: "Adresses",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_DistrictId",
                table: "Adresses",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_GeolocationId",
                table: "Adresses",
                column: "GeolocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationPictures_ApplicationId",
                table: "ApplicationPictures",
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
                name: "IX_Cities_GeolocationId",
                table: "Cities",
                column: "GeolocationId");

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

            migrationBuilder.CreateIndex(
                name: "IX_TagCategories_CategoryId",
                table: "TagCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_TagCategories_TagId",
                table: "TagCategories",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CityId",
                table: "Users",
                column: "CityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationPictures");

            migrationBuilder.DropTable(
                name: "CensoredWords");

            migrationBuilder.DropTable(
                name: "CommentResponses");

            migrationBuilder.DropTable(
                name: "TagCategories");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Applications");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Geolocations");
        }
    }
}
