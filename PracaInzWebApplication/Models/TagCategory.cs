using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class TagCategory
    {
        [Key]
        public int TagCategoryId { get; set; }
        public int TagId { get; set; }
        public Tag Tag { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
