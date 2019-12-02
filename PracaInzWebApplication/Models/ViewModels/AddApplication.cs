using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models.ViewModels
{
    public class AddApplication
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CityId { get; set; }
        public int CategoryId { get; set; }
        public string Street { get; set; }
    }
}
