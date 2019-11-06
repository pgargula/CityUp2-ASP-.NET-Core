﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class Application
    {
        [Key]
        public int ApplicationId { get; set; }

        public int UsertId { get; set; }
        public User User { get; set; }

       // public ICollection<ApplicationPicture> AppplicationPictures { get; set; }

       // public int GeolocationId { get; set; }
        public Adress Adress { get; set; }

        public int StatusId { get; set; }
        public Status Status { get; set; }

        public string Description { get; set; }
    }
}
