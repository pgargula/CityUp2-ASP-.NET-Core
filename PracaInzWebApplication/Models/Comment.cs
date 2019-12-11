using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public int  ApplicationId { get; set; }
        public Application Application { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<CommentResponse> CommentResponses { get; set; }
    }
}
