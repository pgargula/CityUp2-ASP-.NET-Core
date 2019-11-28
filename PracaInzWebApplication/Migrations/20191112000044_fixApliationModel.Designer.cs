﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PracaInzWebApplication.Data;

namespace PracaInzWebApplication.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20191112000044_fixApliationModel")]
    partial class fixApliationModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.ToTable("Adress");

                    b.HasData(
                        new
                        {
                            AdressId = 1,
                            CityId = 1,
                            Street = "Jagielońska"
                        },
                        new
                        {
                            AdressId = 2,
                            CityId = 1,
                            Street = "Kujawska"
                        },
                        new
                        {
                            AdressId = 3,
                            CityId = 2,
                            Street = "Tarnowska"
                        },
                        new
                        {
                            AdressId = 4,
                            CityId = 1,
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
                            UserId = 2
                        },
                        new
                        {
                            ApplicationId = 2,
                            AdressId = 2,
                            CategoryId = 2,
                            Description = "facascsfa",
                            StatusId = 2,
                            UserId = 2
                        },
                        new
                        {
                            ApplicationId = 3,
                            AdressId = 4,
                            CategoryId = 3,
                            Description = "fasfasfqfasfa",
                            StatusId = 1,
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

                    b.ToTable("ApplicationPicture");

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
                            ApplicationId = 3,
                            PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg"
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

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityId");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityId = 1,
                            Name = "Kraków"
                        },
                        new
                        {
                            CityId = 2,
                            Name = "Kurów"
                        },
                        new
                        {
                            CityId = 3,
                            Name = "Warszawa"
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
                        .WithMany("AppplicationPictures")
                        .HasForeignKey("ApplicationId")
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
