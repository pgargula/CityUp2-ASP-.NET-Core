using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models.DTO
{
    public class UserLoginDTO
    {
        [Required(ErrorMessage = "Wprowadź login")]
        public string Login { get; set; }
        [Required(ErrorMessage ="Wprowadź hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
