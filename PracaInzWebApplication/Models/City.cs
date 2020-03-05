using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        //[Required]
        public string Name { get; set; }
        public int GeolocationId { get; set; }
        public Geolocation Geolocation { get; set; }
    }
}
