using Microsoft.EntityFrameworkCore;
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
        DbSet<User> Users { get; set; }
        DbSet<Application> Applications { get; set; }
        DbSet<City> Cities { get; set; }
        DbSet<District> Districts { get; set; }
        DbSet<Geolocation> Geolocations { get; set; }
        DbSet<Status> Statuses { get; set; }
     }
}
