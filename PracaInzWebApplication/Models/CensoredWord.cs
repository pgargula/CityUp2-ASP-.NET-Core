using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class CensoredWord
    {
        [Key]
        public int CensoredWordId { get; set; }
        [Required]
        public string Word { get; set; }
    }
}
