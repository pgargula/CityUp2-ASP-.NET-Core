using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models.ViewModels
{
    public class ApplicationDetails
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string User { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public List<ApplicationPicture>  Pictures { get; set; }
    }
}
