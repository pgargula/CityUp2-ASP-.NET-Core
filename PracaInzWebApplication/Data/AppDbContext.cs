using Microsoft.EntityFrameworkCore;
using PracaInzWebApplication.Helpers;
using PracaInzWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
       public DbSet<User> Users { get; set; }
       public DbSet<Application> Applications { get; set; }
       public DbSet<City> Cities { get; set; }
       public DbSet<District> Districts { get; set; }
       public DbSet<Geolocation> Geolocations { get; set; }
       public DbSet<Status> Statuses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationCategory>().HasKey(sc => new { sc.ApplicationId, sc.CategoryId });
            
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Login = "admin", Password = "admin", Email = "admin@test.pl", CityId = 1, Role = Roles.SystemAdministrator },
                new User { UserId = 2, Login = "user", Password = "user", Email = "user@test.pl", CityId = 1, Role = Roles.User },
                new User { UserId = 3, Login = "user2", Password = "user", Email = "user2@test.pl", CityId = 1, Role = Roles.User },
                new User { UserId = 4, Login = "cityadmin", Password = "cityadmin", Email = "cityadmin@test.pl", CityId = 1, Role = Roles.CityAdministrator },
                new User { UserId = 5, Login = "citymoderator", Password = "citymoderator", Email = "citymoderator@test.pl", CityId = 1, Role = Roles.CityModerator }
                );
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, Name = "Kraków" },
                new City { CityId = 2, Name = "Kurów" },
                new City { CityId = 3, Name = "Warszawa" }
                );
            modelBuilder.Entity<Adress>().HasData(
                new Adress { AdressId = 1, CityId = 1, Street = "Jagielońska" },
                new Adress { AdressId = 2, CityId = 1, Street = "Kujawska" },
                new Adress { AdressId = 3, CityId = 2, Street = "Tarnowska" },
                new Adress { AdressId = 4, CityId = 1, Street = "Siemaszki" }
                );
            modelBuilder.Entity<Application>().HasData(
                new Application { ApplicationId = 1, AdressId = 1, Description = "fasfa", StatusId = 1, UserId = 2 },
                new Application { ApplicationId = 2, AdressId = 2, Description = "facascsfa", StatusId = 2, UserId = 2 },
                new Application { ApplicationId = 3, AdressId = 4, Description = "fasfasfqfasfa", StatusId = 1, UserId = 3 }
                );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, Label = "1" },
                new Status { StatusId = 2, Label = "2" }
                );
            modelBuilder.Entity<ApplicationPicture>().HasData(
                new ApplicationPicture { ApplicationPictureId = 1, PicturePath = "https://mpi.krakow.pl/zalacznik/320782/4.jpg", ApplicationId = 1 },
                new ApplicationPicture { ApplicationPictureId = 2, PicturePath = "https://fajnepodroze.pl/wp-content/uploads/2018/01/krakow.jpg", ApplicationId = 2 },
                new ApplicationPicture { ApplicationPictureId = 3, PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-budynki.jpg", ApplicationId = 2 },
                new ApplicationPicture { ApplicationPictureId = 4, PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg", ApplicationId = 3 }
            );
        }
    
    }
}
