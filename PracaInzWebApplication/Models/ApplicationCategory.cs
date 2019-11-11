using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class ApplicationCategory
    {
        public int ApplicationId { get; set; }
        public Application Aplication { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
