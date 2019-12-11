﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracaInzWebApplication.Data;

namespace PracaInzWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PracaInzWebApplication.Models.Adress", b =>
                {
                    b.Property<int>("AdressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int?>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int?>("GeolocationId")
                        .HasColumnType("int");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdressId");

                    b.HasIndex("CityId");

                    b.HasIndex("DistrictId");

                    b.HasIndex("GeolocationId");

                    b.ToTable("Adresses");

                    b.HasData(
                        new
                        {
                            AdressId = 1,
                            CityId = 1,
                            GeolocationId = 5,
                            Street = "Jagielońska"
                        },
                        new
                        {
                            AdressId = 2,
                            CityId = 1,
                            GeolocationId = 4,
                            Street = "Kujawska"
                        },
                        new
                        {
                            AdressId = 3,
                            CityId = 2,
                            GeolocationId = 3,
                            Street = "Tarnowska"
                        },
                        new
                        {
                            AdressId = 4,
                            CityId = 1,
                            GeolocationId = 2,
                            Street = "Siemaszki"
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Application", b =>
                {
                    b.Property<int>("ApplicationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AdressId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ApplicationId");

                    b.HasIndex("AdressId");

                    b.HasIndex("CategoryId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Applications");

                    b.HasData(
                        new
                        {
                            ApplicationId = 1,
                            AdressId = 1,
                            CategoryId = 1,
                            Description = "fasfa",
                            StatusId = 1,
                            Title = "Rozwalony śmietnk",
                            UserId = 2
                        },
                        new
                        {
                            ApplicationId = 2,
                            AdressId = 2,
                            CategoryId = 2,
                            Description = "facascsfa",
                            StatusId = 2,
                            Title = "Wrak na poboczu",
                            UserId = 2
                        },
                        new
                        {
                            ApplicationId = 3,
                            AdressId = 4,
                            CategoryId = 3,
                            Description = "fasfasfqfasfa",
                            StatusId = 1,
                            Title = "Dzikie Psy",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.ApplicationPicture", b =>
                {
                    b.Property<int>("ApplicationPictureId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<string>("PicturePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ApplicationPictureId");

                    b.HasIndex("ApplicationId");

                    b.ToTable("ApplicationPictures");

                    b.HasData(
                        new
                        {
                            ApplicationPictureId = 1,
                            ApplicationId = 1,
                            PicturePath = "https://mpi.krakow.pl/zalacznik/320782/4.jpg"
                        },
                        new
                        {
                            ApplicationPictureId = 2,
                            ApplicationId = 2,
                            PicturePath = "https://fajnepodroze.pl/wp-content/uploads/2018/01/krakow.jpg"
                        },
                        new
                        {
                            ApplicationPictureId = 3,
                            ApplicationId = 2,
                            PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-budynki.jpg"
                        },
                        new
                        {
                            ApplicationPictureId = 4,
                            ApplicationId = 2,
                            PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg"
                        },
                        new
                        {
                            ApplicationPictureId = 5,
                            ApplicationId = 1,
                            PicturePath = "https://picsum.photos/500"
                        },
                        new
                        {
                            ApplicationPictureId = 6,
                            ApplicationId = 1,
                            PicturePath = "https://picsum.photos/500"
                        },
                        new
                        {
                            ApplicationPictureId = 7,
                            ApplicationId = 1,
                            PicturePath = "https://picsum.photos/500"
                        },
                        new
                        {
                            ApplicationPictureId = 8,
                            ApplicationId = 3,
                            PicturePath = "https://picsum.photos/500"
                        },
                        new
                        {
                            ApplicationPictureId = 9,
                            ApplicationId = 3,
                            PicturePath = "https://picsum.photos/500"
                        },
                        new
                        {
                            ApplicationPictureId = 10,
                            ApplicationId = 3,
                            PicturePath = "https://picsum.photos/500"
                        },
                        new
                        {
                            ApplicationPictureId = 11,
                            ApplicationId = 3,
                            PicturePath = "https://picsum.photos/500"
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            Name = "Zaniszczenie"
                        },
                        new
                        {
                            CategoryId = 2,
                            Name = "Inicjatywa"
                        },
                        new
                        {
                            CategoryId = 3,
                            Name = "Inne"
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GeolocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.HasIndex("GeolocationId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            GeolocationId = 1,
                            Name = "Kraków"
                        },
                        new
                        {
                            CityId = 2,
                            GeolocationId = 8,
                            Name = "Kurów"
                        },
                        new
                        {
                            CityId = 3,
                            GeolocationId = 9,
                            Name = "Warszawa"
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ApplicationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentId");

                    b.HasIndex("ApplicationId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            CommentId = 1,
                            ApplicationId = 1,
                            Date = new DateTime(2019, 12, 9, 20, 57, 51, 99, DateTimeKind.Local).AddTicks(2818),
                            Text = "fajne",
                            UserId = 3
                        },
                        new
                        {
                            CommentId = 2,
                            ApplicationId = 1,
                            Date = new DateTime(2019, 12, 9, 22, 57, 51, 102, DateTimeKind.Local).AddTicks(8466),
                            Text = "Lorem ipsum",
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 3,
                            ApplicationId = 1,
                            Date = new DateTime(2019, 12, 9, 20, 57, 51, 102, DateTimeKind.Local).AddTicks(8574),
                            Text = "Cracovia rządzi w krakowie",
                            UserId = 3
                        },
                        new
                        {
                            CommentId = 4,
                            ApplicationId = 1,
                            Date = new DateTime(2019, 12, 9, 21, 1, 51, 102, DateTimeKind.Local).AddTicks(8578),
                            Text = "Legia to stara...",
                            UserId = 2
                        },
                        new
                        {
                            CommentId = 5,
                            ApplicationId = 1,
                            Date = new DateTime(2019, 12, 9, 21, 8, 51, 102, DateTimeKind.Local).AddTicks(8602),
                            Text = "dobre pomarańczowe",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.CommentResponse", b =>
                {
                    b.Property<int>("CommentResponseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CommentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("CommentResponseId");

                    b.HasIndex("CommentId");

                    b.HasIndex("UserId");

                    b.ToTable("CommentResponses");

                    b.HasData(
                        new
                        {
                            CommentResponseId = 1,
                            CommentId = 1,
                            Date = new DateTime(2019, 12, 9, 20, 59, 51, 103, DateTimeKind.Local).AddTicks(2245),
                            Text = "dzięki",
                            UserId = 2
                        },
                        new
                        {
                            CommentResponseId = 2,
                            CommentId = 1,
                            Date = new DateTime(2019, 12, 9, 21, 1, 51, 103, DateTimeKind.Local).AddTicks(2945),
                            Text = "spoko",
                            UserId = 3
                        },
                        new
                        {
                            CommentResponseId = 3,
                            CommentId = 2,
                            Date = new DateTime(2019, 12, 9, 21, 3, 51, 103, DateTimeKind.Local).AddTicks(2973),
                            Text = "lolo",
                            UserId = 2
                        },
                        new
                        {
                            CommentResponseId = 4,
                            CommentId = 3,
                            Date = new DateTime(2019, 12, 9, 21, 4, 51, 103, DateTimeKind.Local).AddTicks(2977),
                            Text = "dasdasd",
                            UserId = 2
                        },
                        new
                        {
                            CommentResponseId = 5,
                            CommentId = 4,
                            Date = new DateTime(2019, 12, 9, 21, 5, 51, 103, DateTimeKind.Local).AddTicks(2982),
                            Text = "afafasfa",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Geolocation", b =>
                {
                    b.Property<int>("GeolocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.HasKey("GeolocationId");

                    b.ToTable("Geolocations");

                    b.HasData(
                        new
                        {
                            GeolocationId = 1,
                            Latitude = 50.064700000000002,
                            Longitude = 19.945
                        },
                        new
                        {
                            GeolocationId = 2,
                            Latitude = 50.164700000000003,
                            Longitude = 19.945
                        },
                        new
                        {
                            GeolocationId = 3,
                            Latitude = 50.064999999999998,
                            Longitude = 19.954999999999998
                        },
                        new
                        {
                            GeolocationId = 4,
                            Latitude = 50.067700000000002,
                            Longitude = 19.965
                        },
                        new
                        {
                            GeolocationId = 5,
                            Latitude = 50.064700000000002,
                            Longitude = 19.914999999999999
                        },
                        new
                        {
                            GeolocationId = 6,
                            Latitude = 50.054699999999997,
                            Longitude = 19.899999999999999
                        },
                        new
                        {
                            GeolocationId = 7,
                            Latitude = 50.0747,
                            Longitude = 19.844999999999999
                        },
                        new
                        {
                            GeolocationId = 8,
                            Latitude = 55.054699999999997,
                            Longitude = 18.899999999999999
                        },
                        new
                        {
                            GeolocationId = 9,
                            Latitude = 53.054699999999997,
                            Longitude = 19.600000000000001
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Status", b =>
                {
                    b.Property<int>("StatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StatusId");

                    b.ToTable("Statuses");

                    b.HasData(
                        new
                        {
                            StatusId = 1,
                            Label = "1"
                        },
                        new
                        {
                            StatusId = 2,
                            Label = "2"
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("CityId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            CityId = 1,
                            Email = "admin@test.pl",
                            Login = "admin",
                            Password = "admin",
                            Role = "SystemAdministrator"
                        },
                        new
                        {
                            UserId = 2,
                            CityId = 1,
                            Email = "user@test.pl",
                            Login = "user",
                            Password = "user",
                            Role = "User"
                        },
                        new
                        {
                            UserId = 3,
                            CityId = 1,
                            Email = "user2@test.pl",
                            Login = "user2",
                            Password = "user",
                            Role = "User"
                        },
                        new
                        {
                            UserId = 4,
                            CityId = 1,
                            Email = "cityadmin@test.pl",
                            Login = "cityadmin",
                            Password = "cityadmin",
                            Role = "CityAdministrator"
                        },
                        new
                        {
                            UserId = 5,
                            CityId = 1,
                            Email = "citymoderator@test.pl",
                            Login = "citymoderator",
                            Password = "citymoderator",
                            Role = "CityModerator"
                        });
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Adress", b =>
                {
                    b.HasOne("PracaInzWebApplication.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracaInzWebApplication.Models.District", "District")
                        .WithMany()
                        .HasForeignKey("DistrictId");

                    b.HasOne("PracaInzWebApplication.Models.Geolocation", "Geolocation")
                        .WithMany()
                        .HasForeignKey("GeolocationId");
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Application", b =>
                {
                    b.HasOne("PracaInzWebApplication.Models.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracaInzWebApplication.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracaInzWebApplication.Models.Status", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracaInzWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.ApplicationPicture", b =>
                {
                    b.HasOne("PracaInzWebApplication.Models.Application", null)
                        .WithMany("ApplicationPictures")
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.City", b =>
                {
                    b.HasOne("PracaInzWebApplication.Models.Geolocation", "Geolocation")
                        .WithMany()
                        .HasForeignKey("GeolocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.Comment", b =>
                {
                    b.HasOne("PracaInzWebApplication.Models.Application", "Application")
                        .WithMany()
                        .HasForeignKey("ApplicationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracaInzWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.CommentResponse", b =>
                {
                    b.HasOne("PracaInzWebApplication.Models.Comment", null)
                        .WithMany("CommentResponses")
                        .HasForeignKey("CommentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PracaInzWebApplication.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PracaInzWebApplication.Models.User", b =>
                {
                    b.HasOne("PracaInzWebApplication.Models.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
