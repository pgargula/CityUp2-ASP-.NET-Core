using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class Status
    {
        [Key]
        public int StatusId { get; set; }
        public string Label { get; set; }
    }
}
