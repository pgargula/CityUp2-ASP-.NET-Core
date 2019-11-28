using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class District
    {
        [Key]
        public int DistrictId { get; set; }
        //[Required]
        public string Name { get; set; }
    }
}
