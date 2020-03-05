using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class UserVote
    {
        [Key]
        public int UserVoteId { get; set; }
        public int ApplicationId { get; set; }
        public Application Application { get; set; }
        public int UserId { get; set; }
    }
}
