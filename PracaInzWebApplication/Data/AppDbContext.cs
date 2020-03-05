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
        public DbSet<Category> Categories { get; set; }
        public DbSet<ApplicationPicture> ApplicationPictures { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentResponse> CommentResponses { get; set; }
        public DbSet<CensoredWord> CensoredWords { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagCategory> TagCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<TagCategory>().HasKey(x => new { x.TagId, x.CategoryId }); // many to many config
            
            modelBuilder.Entity<Geolocation>().HasData(
                new Geolocation { GeolocationId = 1, Latitude = 50.0647, Longitude = 19.945 },//Kraków coordinates
                new Geolocation { GeolocationId = 2, Latitude = 50.1647, Longitude = 19.945 },
                new Geolocation { GeolocationId = 3, Latitude = 50.0650, Longitude = 19.955 },
                new Geolocation { GeolocationId = 4, Latitude = 50.0677, Longitude = 19.965 },
                new Geolocation { GeolocationId = 5, Latitude = 50.0647, Longitude = 19.915 },
                new Geolocation { GeolocationId = 6, Latitude = 50.0547, Longitude = 19.900 },
                new Geolocation { GeolocationId = 7, Latitude = 50.0747, Longitude = 19.845 },
                new Geolocation { GeolocationId = 8, Latitude = 55.0547, Longitude = 18.900 },
                new Geolocation { GeolocationId = 9, Latitude = 53.0547, Longitude = 19.600 }
                );
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Login = "admin", Password = "admin", Email = "admin@test.pl", CityId = 1, Role = Roles.SystemAdministrator },
                new User { UserId = 2, Login = "user", Password = "user", Email = "user@test.pl", CityId = 1, Role = Roles.User },
                new User { UserId = 3, Login = "user2", Password = "user", Email = "user2@test.pl", CityId = 1, Role = Roles.User },
                new User { UserId = 4, Login = "cityadmin", Password = "cityadmin", Email = "cityadmin@test.pl", CityId = 1, Role = Roles.CityAdministrator },
                new User { UserId = 5, Login = "citymoderator", Password = "citymoderator", Email = "citymoderator@test.pl", CityId = 1, Role = Roles.CityModerator }
                );
            modelBuilder.Entity<City>().HasData(
                new City { CityId = 1, Name = "Kraków", GeolocationId=1 },
                new City { CityId = 2, Name = "Kurów", GeolocationId=8 },
                new City { CityId = 3, Name = "Warszawa", GeolocationId=9 }
                );
            modelBuilder.Entity<Adress>().HasData(
                new Adress { AdressId = 1, CityId = 1, Street = "Jagielońska", GeolocationId=5 },
                new Adress { AdressId = 2, CityId = 1, Street = "Kujawska", GeolocationId=4 },
                new Adress { AdressId = 3, CityId = 2, Street = "Tarnowska", GeolocationId=3 },
                new Adress { AdressId = 4, CityId = 1, Street = "Siemaszki", GeolocationId=2 }
                );
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 4, Name = "Inicjatywa" },
                new Category { CategoryId = 5, Name = "Inne" },
                new Category { CategoryId = 1, Name = "Zanieczyszczenie" },
                new Category { CategoryId = 2, Name = "Zagrożenie" },
                new Category { CategoryId = 3, Name = "Awaria" }
                );
            modelBuilder.Entity<Tag>().HasData(
                new Tag { TagId = 1, Name = "śmieć" },
                new Tag { TagId = 2, Name = "śmieci" },
                new Tag { TagId = 3, Name = "kosz" },
                new Tag { TagId = 4, Name = "brudno" },
                new Tag { TagId = 5, Name = "nieporządek" },
                new Tag { TagId = 6, Name = "mpo" },
                new Tag { TagId = 7, Name = "kosze" },
                new Tag { TagId = 8, Name = "odpadki" },
                new Tag { TagId = 9, Name = "zanieczyszczenie" },
                new Tag { TagId = 10, Name = "smog" },
                new Tag { TagId = 11, Name = "ulica" },
                new Tag { TagId = 12, Name = "zepsuta" },
                new Tag { TagId = 13, Name = "latarnia" },
                new Tag { TagId = 14, Name = "popsute" },
                new Tag { TagId = 15, Name = "zepsute" },
                new Tag { TagId = 16, Name = "naprawić" },
                new Tag { TagId = 17, Name = "poprawić" },
                new Tag { TagId = 18, Name = "awaria" },
                new Tag { TagId = 19, Name = "awarie" },
                new Tag { TagId = 20, Name = "uszkodzone" },
                new Tag { TagId = 21, Name = "działa" },
                new Tag { TagId = 22, Name = "działać" },
                new Tag { TagId = 23, Name = "źle" },
                new Tag { TagId = 24, Name = "niepoprawnie" },
                new Tag { TagId = 25, Name = "sygnalizacja" },
                new Tag { TagId = 26, Name = "niebezpieczne" },
                new Tag { TagId = 27, Name = "agresywne" },
                new Tag { TagId = 28, Name = "agresywny" },
                new Tag { TagId = 29, Name = "zagrożenie" },
                new Tag { TagId = 30, Name = "inicjatywa" },
                new Tag { TagId = 31, Name = "propozycja" },
                new Tag { TagId = 32, Name = "zaproponować" },
                new Tag { TagId = 33, Name = "zaplanować" },
                new Tag { TagId = 34, Name = "zrobić" },
                new Tag { TagId = 35, Name = "wybudować" },
                new Tag { TagId = 36, Name = "zbudować" },
                new Tag { TagId = 37, Name = "proponuje" },
                new Tag { TagId = 38, Name = "kosza" }
                );
            modelBuilder.Entity<TagCategory>().HasData(
                new TagCategory { TagCategoryId = 1, CategoryId = 1, TagId = 38 },
                new TagCategory { TagCategoryId = 2, CategoryId = 1, TagId = 1 },
                new TagCategory { TagCategoryId = 3, CategoryId = 1, TagId = 2 },
                new TagCategory { TagCategoryId = 4, CategoryId = 1, TagId = 3 },
                new TagCategory { TagCategoryId = 5, CategoryId = 1, TagId = 4 },
                new TagCategory { TagCategoryId = 6, CategoryId = 1, TagId = 5 },
                new TagCategory { TagCategoryId = 7, CategoryId = 1, TagId = 6 },
                new TagCategory { TagCategoryId = 8, CategoryId = 1, TagId = 7 },
                new TagCategory { TagCategoryId = 9, CategoryId = 1, TagId = 8 },
                new TagCategory { TagCategoryId = 10, CategoryId = 1, TagId = 9 },
                new TagCategory { TagCategoryId = 11, CategoryId = 1, TagId = 10 },
                new TagCategory { TagCategoryId = 12, CategoryId = 1, TagId = 11 },
                new TagCategory { TagCategoryId = 13, CategoryId = 3, TagId = 12 },
                new TagCategory { TagCategoryId = 14, CategoryId = 3, TagId = 13 },
                new TagCategory { TagCategoryId = 15, CategoryId = 3, TagId = 14 },
                new TagCategory { TagCategoryId = 16, CategoryId = 3, TagId = 15 },
                new TagCategory { TagCategoryId = 17, CategoryId = 3, TagId = 16 },
                new TagCategory { TagCategoryId = 18, CategoryId = 3, TagId = 17 },
                new TagCategory { TagCategoryId = 19, CategoryId = 3, TagId = 18 },
                new TagCategory { TagCategoryId = 20, CategoryId = 3, TagId = 19 },
                new TagCategory { TagCategoryId = 21, CategoryId = 3, TagId = 10 },
                new TagCategory { TagCategoryId = 22, CategoryId = 3, TagId = 21 },
                new TagCategory { TagCategoryId = 23, CategoryId = 3, TagId = 22 },
                new TagCategory { TagCategoryId = 24, CategoryId = 3, TagId = 23 },
                new TagCategory { TagCategoryId = 25, CategoryId = 3, TagId = 24 },
                new TagCategory { TagCategoryId = 26, CategoryId = 3, TagId = 25 },
                new TagCategory { TagCategoryId = 27, CategoryId = 3, TagId = 26 },
                new TagCategory { TagCategoryId = 28, CategoryId = 2, TagId = 26 },
                new TagCategory { TagCategoryId = 29, CategoryId = 2, TagId = 27 },
                new TagCategory { TagCategoryId = 30, CategoryId = 2, TagId = 28 },
                new TagCategory { TagCategoryId = 31, CategoryId = 2, TagId = 29 },
                new TagCategory { TagCategoryId = 32, CategoryId = 4, TagId = 30 },
                new TagCategory { TagCategoryId = 33, CategoryId = 4, TagId = 31 },
                new TagCategory { TagCategoryId = 34, CategoryId = 4, TagId = 32 },
                new TagCategory { TagCategoryId = 35, CategoryId = 4, TagId = 33 },
                new TagCategory { TagCategoryId = 36, CategoryId = 4, TagId = 34 },
                new TagCategory { TagCategoryId = 37, CategoryId = 4, TagId = 35 },
                new TagCategory { TagCategoryId = 38, CategoryId = 4, TagId = 36 },
                new TagCategory { TagCategoryId = 39, CategoryId = 4, TagId = 37 }
                );

            modelBuilder.Entity<Application>().HasData(
                new Application { ApplicationId = 1, AdressId = 1, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis mollis ex ipsum, sagittis malesuada ante volutpat et. Aenean accumsan, eros ac tristique semper, odio quam convallis sapien, eget fermentum tellus nibh et metus. Etiam rutrum consectetur pretium. Aenean dapibus luctus odio, at eleifend lacus porttitor condimentum. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis. ", StatusId = 1, UserId = 2, CategoryId=1, Title="Rozwalony śmietnk" },
                new Application { ApplicationId = 2, AdressId = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis mollis ex ipsum, sagittis malesuada ante volutpat et. Aenean accumsan, eros ac tristique semper, odio quam convallis sapien, eget fermentum tellus nibh et metus. Etiam rutrum consectetur pretium. Aenean dapibus luctus odio, at eleifend lacus porttitor condimentum. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis. ", StatusId = 2, UserId = 2, CategoryId=2, Title="Wrak na poboczu" },
                new Application { ApplicationId = 3, AdressId = 4, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis mollis ex ipsum, sagittis malesuada ante volutpat et. Aenean accumsan, eros ac tristique semper, odio quam convallis sapien, eget fermentum tellus nibh et metus. Etiam rutrum consectetur pretium. Aenean dapibus luctus odio, at eleifend lacus porttitor condimentum. Suspendisse potenti. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis. ", StatusId = 1, UserId = 3, CategoryId=3, Title= "Dzikie Psy" }
                );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId = 1, Label = "W oczekiwaniu" },
                new Status { StatusId = 2, Label = "W realizacji" },
                new Status { StatusId = 3, Label = "Zrealizowane" },
                new Status { StatusId = 4, Label = "Odzrucone" }
                
                );
            modelBuilder.Entity<ApplicationPicture>().HasData(
                new ApplicationPicture { ApplicationPictureId = 1, PicturePath = "https://mpi.krakow.pl/zalacznik/320782/4.jpg", ApplicationId = 1 },
                new ApplicationPicture { ApplicationPictureId = 2, PicturePath = "https://fajnepodroze.pl/wp-content/uploads/2018/01/krakow.jpg", ApplicationId = 2 },
                new ApplicationPicture { ApplicationPictureId = 3, PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-budynki.jpg", ApplicationId = 2 },
                new ApplicationPicture { ApplicationPictureId = 4, PicturePath = "https://czasnawywczas.pl/wp-content/uploads/krakow-runek-glowa.jpg", ApplicationId = 2 },             
                new ApplicationPicture { ApplicationPictureId = 5, PicturePath = "https://picsum.photos/500", ApplicationId = 1 },
                new ApplicationPicture { ApplicationPictureId = 6, PicturePath = "https://picsum.photos/500", ApplicationId = 1 },
                new ApplicationPicture { ApplicationPictureId = 7, PicturePath = "https://picsum.photos/500", ApplicationId = 1 },
                new ApplicationPicture { ApplicationPictureId = 8, PicturePath = "https://picsum.photos/500", ApplicationId = 3 },
                new ApplicationPicture { ApplicationPictureId = 9, PicturePath = "https://picsum.photos/500", ApplicationId = 3 },
                new ApplicationPicture { ApplicationPictureId = 10, PicturePath = "https://picsum.photos/500", ApplicationId = 3 },
                new ApplicationPicture { ApplicationPictureId = 11, PicturePath = "https://picsum.photos/500", ApplicationId = 3 }
            );
            modelBuilder.Entity<Comment>().HasData(
                new Comment { CommentId = 1, UserId =3, Text="fajne", Date=DateTime.Now, ApplicationId=1 },
                new Comment { CommentId = 2, UserId = 2, Text = "Smietnik jest rozwalony od 2 tygodni", Date = DateTime.Now.AddHours(2), ApplicationId = 1 },
                new Comment { CommentId = 3, UserId = 3, Text = "Smieci coraz więcej", Date = DateTime.Now, ApplicationId = 1 },
                new Comment { CommentId = 4, UserId = 2, Text = "Mam nadzieje że zostanie to szybko usunięte", Date = DateTime.Now.AddMinutes(4), ApplicationId = 1 },
                new Comment { CommentId = 5, UserId = 3, Text = "dobre pomarańczowe", Date = DateTime.Now.AddMinutes(11), ApplicationId = 1 }
                );
            modelBuilder.Entity<CommentResponse>().HasData(
                new CommentResponse {CommentResponseId=1, UserId=2, CommentId=1, Text="dzięki", Date=DateTime.Now.AddMinutes(2)},
                new CommentResponse { CommentResponseId = 2, UserId = 3, CommentId = 1, Text = "spoko", Date = DateTime.Now.AddMinutes(4) },
                new CommentResponse { CommentResponseId = 3, UserId = 2, CommentId = 2, Text = "lolo", Date = DateTime.Now.AddMinutes(6) },
                new CommentResponse { CommentResponseId = 4, UserId = 2, CommentId = 3, Text = "test", Date = DateTime.Now.AddMinutes(7) },
                new CommentResponse { CommentResponseId = 5, UserId = 2, CommentId = 4, Text = "test", Date = DateTime.Now.AddMinutes(8) }

                );
            List<string> words = new List<string>() { "chuj","chuja", "chujek", "chuju", "chujem", "chujnia","chujowy", "chujowa", "chujowe", "cipa", "cipę", "cipe", "cipą","cipie", "dojebać","dojebac", "dojebie", "dojebał", "dojebal","dojebała", "dojebala", "dojebałem", "dojebalem", "dojebałam",
                                                        "dojebalam", "dojebię", "dojebie", "dopieprzać", "dopieprzac","dopierdalać", "dopierdalac", "dopierdala", "dopierdalał","dopierdalal", "dopierdalała", "dopierdalala", "dopierdoli","dopierdolił", "dopierdolil", "dopierdolę", "dopierdole", "dopierdoli","dopierdalający", "dopierdalajacy", "dopierdolić", "dopierdolic",
                                                        "dupa", "dupie", "dupą", "dupcia", "dupeczka", "dupy", "dupe", "huj","hujek", "hujnia", "huja", "huje", "hujem", "huju", "jebać", "jebac","jebał", "jebal", "jebie", "jebią", "jebia", "jebak", "jebaka", "jebal","jebał", "jebany", "jebane", "jebanka", "jebanko", "jebankiem","jebanymi", "jebana", "jebanym", "jebanej", "jebaną", "jebana",
                                                        "jebani", "jebanych", "jebanymi", "jebcie", "jebiący", "jebiacy","jebiąca", "jebiaca", "jebiącego", "jebiacego", "jebiącej", "jebiacej","jebia", "jebią", "jebie", "jebię", "jebliwy", "jebnąć", "jebnac","jebnąc", "jebnać", "jebnął", "jebnal", "jebną", "jebna", "jebnęła","jebnela", "jebnie", "jebnij", "jebut", "koorwa", "kórwa", "kurestwo",
                                                        "kurew", "kurewski", "kurewska", "kurewskiej", "kurewską", "kurewska","kurewsko", "kurewstwo", "kurwa", "kurwaa", "kurwami", "kurwą", "kurwe","kurwę", "kurwie", "kurwiska", "kurwo", "kurwy", "kurwach", "kurwami","kurewski", "kurwiarz", "kurwiący", "kurwica", "kurwić", "kurwic","kurwidołek", "kurwik", "kurwiki", "kurwiszcze", "kurwiszon","kurwiszona", "kurwiszonem", "kurwiszony", "kutas", "kutasa", "kutasie",
                                                        "kutasem", "kutasy", "kutasów", "kutasow", "kutasach", "kutasami","matkojebca", "matkojebcy", "matkojebcą", "matkojebca", "matkojebcami","matkojebcach", "nabarłożyć", "najebać", "najebac", "najebał","najebal", "najebała", "najebala", "najebane", "najebany", "najebaną","najebana", "najebie", "najebią", "najebia", "naopierdalać",
                                                        "naopierdalac", "naopierdalał", "naopierdalal", "naopierdalała","naopierdalala", "naopierdalała", "napierdalać", "napierdalac","napierdalający", "napierdalajacy", "napierdolić", "napierdolic","nawpierdalać", "nawpierdalac", "nawpierdalał", "nawpierdalal","nawpierdalała", "nawpierdalala", "obsrywać", "obsrywac", "obsrywający","obsrywajacy", "odpieprzać", "odpieprzac", "odpieprzy", "odpieprzył",
                                                        "odpieprzyl", "odpieprzyła", "odpieprzyla", "odpierdalać","odpierdalac", "odpierdol", "odpierdolił", "odpierdolil","odpierdoliła", "odpierdolila", "odpierdoli", "odpierdalający","odpierdalajacy", "odpierdalająca", "odpierdalajaca", "odpierdolić","odpierdolic", "odpierdoli", "odpierdolił", "opieprzający",
                                                        "opierdalać", "opierdalac", "opierdala", "opierdalający","opierdalajacy", "opierdol", "opierdolić", "opierdolic", "opierdoli","opierdolą", "opierdola", "piczka", "pieprznięty", "pieprzniety","pieprzony", "pierdel", "pierdlu", "pierdolą", "pierdola", "pierdolący","pierdolacy", "pierdoląca", "pierdolaca", "pierdol", "pierdole",
                                                        "pierdolenie", "pierdoleniem", "pierdoleniu", "pierdolę", "pierdolec","pierdola", "pierdolą", "pierdolić", "pierdolicie", "pierdolic","pierdolił", "pierdolil", "pierdoliła", "pierdolila", "pierdoli","pierdolnięty", "pierdolniety", "pierdolisz", "pierdolnąć","pierdolnac", "pierdolnął", "pierdolnal", "pierdolnęła", "pierdolnela",
                                                        "pierdolnie", "pierdolnięty", "pierdolnij", "pierdolnik", "pierdolona","pierdolone", "pierdolony", "pierdołki", "pierdzący", "pierdzieć","pierdziec", "pizda", "pizdą", "pizde", "pizdę", "piździe", "pizdzie","pizdnąć", "pizdnac", "pizdu", "podpierdalać", "podpierdalac","podpierdala", "podpierdalający", "podpierdalajacy", "podpierdolić",
                                                        "podpierdolic", "podpierdoli", "pojeb", "pojeba", "pojebami","pojebani", "pojebanego", "pojebanemu", "pojebani", "pojebany","pojebanych", "pojebanym", "pojebanymi", "pojebem", "pojebać","pojebac", "pojebalo", "popierdala", "popierdalac", "popierdalać","popierdolić", "popierdolic", "popierdoli", "popierdolonego",
                                                        "popierdolonemu", "popierdolonym", "popierdolone", "popierdoleni","popierdolony", "porozpierdalać", "porozpierdala", "porozpierdalac","poruchac", "poruchać", "przejebać", "przejebane", "przejebac","przyjebali", "przepierdalać", "przepierdalac", "przepierdala","przepierdalający", "przepierdalajacy", "przepierdalająca",
                                                        "przepierdalajaca", "przepierdolić", "przepierdolic", "przyjebać","przyjebac", "przyjebie", "przyjebała", "przyjebala", "przyjebał","przyjebal", "przypieprzać", "przypieprzac", "przypieprzający","przypieprzajacy", "przypieprzająca", "przypieprzajaca","przypierdalać", "przypierdalac", "przypierdala", "przypierdoli",
                                                        "przypierdalający", "przypierdalajacy", "przypierdolić","przypierdolic", "qrwa", "rozjebać", "rozjebac", "rozjebie","rozjebała", "rozjebią", "rozpierdalać", "rozpierdalac", "rozpierdala","rozpierdolić", "rozpierdolic", "rozpierdole", "rozpierdoli","rozpierducha", "skurwić", "skurwiel", "skurwiela", "skurwielem",
                                                        "skurwielu", "skurwysyn", "skurwysynów", "skurwysynow", "skurwysyna","skurwysynem", "skurwysynu", "skurwysyny", "skurwysyński","skurwysynski", "skurwysyństwo", "skurwysynstwo", "spieprzać","spieprzac", "spieprza", "spieprzaj", "spieprzajcie", "spieprzają","spieprzaja", "spieprzający", "spieprzajacy", "spieprzająca",
                                                        "spieprzajaca", "spierdalać", "spierdalac", "spierdala", "spierdalał","spierdalała", "spierdalal", "spierdalalcie", "spierdalala","spierdalający", "spierdalajacy", "spierdolić", "spierdolic","spierdoli", "spierdoliła", "spierdoliło", "spierdolą", "spierdola","srać", "srac", "srający", "srajacy", "srając", "srajac", "sraj","sukinsyn", "sukinsyny", "sukinsynom", "sukinsynowi", "sukinsynów",
                                                        "sukinsynow", "śmierdziel", "udupić", "ujebać", "ujebac", "ujebał","ujebal", "ujebana", "ujebany", "ujebie", "ujebała", "ujebala","upierdalać", "upierdalac", "upierdala", "upierdoli", "upierdolić","upierdolic", "upierdoli", "upierdolą", "upierdola", "upierdoleni","wjebać", "wjebac", "wjebie", "wjebią", "wjebia", "wjebiemy",
                                                        "wjebiecie", "wkurwiać", "wkurwiac", "wkurwi", "wkurwia", "wkurwiał","wkurwial", "wkurwiający", "wkurwiajacy", "wkurwiająca", "wkurwiajaca","wkurwić", "wkurwic", "wkurwi", "wkurwiacie", "wkurwiają", "wkurwiali","wkurwią", "wkurwia", "wkurwimy", "wkurwicie", "wkurwiacie", "wkurwić","wkurwic", "wkurwia", "wpierdalać", "wpierdalac", "wpierdalający","wpierdalajacy", "wpierdol", "wpierdolić", "wpierdolic", "wpizdu",
                                                        "wyjebać", "wyjebac", "wyjebali", "wyjebał", "wyjebac", "wyjebała","wyjebały", "wyjebie", "wyjebią", "wyjebia", "wyjebiesz", "wyjebie","wyjebiecie", "wyjebiemy", "wypieprzać", "wypieprzac", "wypieprza","wypieprzał", "wypieprzal", "wypieprzała", "wypieprzala", "wypieprzy","wypieprzyła", "wypieprzyla", "wypieprzył", "wypieprzyl", "wypierdal","wypierdalać", "wypierdalac", "wypierdala", "wypierdalaj",
                                                        "wypierdalał", "wypierdalal", "wypierdalała", "wypierdalala","wypierdalać", "wypierdolić", "wypierdolic", "wypierdoli","wypierdolimy", "wypierdolicie", "wypierdolą", "wypierdola","wypierdolili", "wypierdolił", "wypierdolil", "wypierdoliła","wypierdolila", "zajebać", "zajebac", "zajebie", "zajebią", "zajebia","zajebiał", "zajebial", "zajebała", "zajebiala", "zajebali", "zajebana",
                                                        "zajebani", "zajebane", "zajebany", "zajebanych", "zajebanym","zajebanymi", "zajebiste", "zajebisty", "zajebistych", "zajebista","zajebistym", "zajebistymi", "zajebiście", "zajebiscie", "zapieprzyć","zapieprzyc", "zapieprzy", "zapieprzył", "zapieprzyl", "zapieprzyła","zapieprzyla", "zapieprzą", "zapieprza", "zapieprzy", "zapieprzymy","zapieprzycie", "zapieprzysz", "zapierdala", "zapierdalać",
                                                        "zapierdalac", "zapierdalaja", "zapierdalał", "zapierdalaj","zapierdalajcie", "zapierdalała", "zapierdalala", "zapierdalali","zapierdalający", "zapierdalajacy", "zapierdolić", "zapierdolic","zapierdoli", "zapierdolił", "zapierdolil", "zapierdoliła","zapierdolila", "zapierdolą", "zapierdola", "zapierniczać","zapierniczający", "zasrać", "zasranym", "zasrywać", "zasrywający","zesrywać", "zesrywający", "zjebać", "zjebac", "zjebał", "zjebal",
                                                        "zjebała", "zjebala", "zjebana", "zjebią", "zjebali", "zjeby" };
            int i = 1;
            foreach (var word in words)
            {
                modelBuilder.Entity<CensoredWord>().HasData(
                   new CensoredWord { CensoredWordId = i, Word = word }
                   
                );
                i++;
            }


        }
    }
}
