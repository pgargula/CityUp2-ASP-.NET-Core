using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models
{
    public class ApplicationPicture
    {
        [Key]
        public int ApplicationPictureId { get; set; }
        //[Required]
        public string PicturePath { get; set; }
        //[Required]
        public int ApplicationId { get; set; }
       // public Application Application { get; set; }
    }
}
