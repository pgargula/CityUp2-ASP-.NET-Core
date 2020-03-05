using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models.ViewModels
{
    public class UserDetails
    {
        public string Login { get; set;}
        public string Email { get; set; }        
        public string City { get; set; }
        public int AppNumber { get; set; }
        public int DangerAppNumber { get; set; }
        public int DirtAppNumber { get; set; }
        public int DamageAppNumber { get; set; }
        public int InitiativeAppnumber { get; set; }
        public int OtherAppNumber { get; set; }
        public int CommentNumber { get; set; }
        public int VoteNumber { get; set; }

    }
}
