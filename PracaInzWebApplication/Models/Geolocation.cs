using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class Geolocation
    {
        [Key]
        public int GeolocationId { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
