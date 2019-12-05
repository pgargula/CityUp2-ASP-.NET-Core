using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models.ViewModels
{
    public class AddApplication
    {
        [Required(ErrorMessage = "Wprowadź tytuł")]
        public string Title { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadź ulicę")]
        public string Street { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<IFormFile> Photos { get; set; }
        public int UserId { get; set; }
        public string JavaScriptToRun { get; set; }
    }
}
