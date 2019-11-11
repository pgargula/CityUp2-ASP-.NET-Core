﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public IEnumerable<ApplicationCategory> ApplicationCategories { get; set; }
       // public IEnumerable<CategoryTag> CategoryTags { get; set; }
    }
}
