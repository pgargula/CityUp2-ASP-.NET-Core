using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PracaInzWebApplication.Models.DTO
{
    public class UserRegisterDTO
    {
        [Required(ErrorMessage = "Wprowadź login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Wprowadź Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Wprowadź hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage ="Hasła nie są identyczne")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Wybierz miasto")]
        public int City { get; set; }
    }
}
