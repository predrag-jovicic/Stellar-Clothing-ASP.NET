using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_Web_App.ViewModels.Input
{
    public class LoginViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public String Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public String Password { get; set; }
    }
}
