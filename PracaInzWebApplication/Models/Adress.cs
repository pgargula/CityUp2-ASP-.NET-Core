using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class Adress
    {
        [Key]
        public int AdressId { get; set; }
        [Required]
        public City City { get; set; }
        public District? District { get; set; }
        public string Street { get; set; }
        Geolocation Geolocation { get; set; }
    }
}
