using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage = "Username is required!")]
        [MinLength(5, ErrorMessage = "Username must be between 5 and 20 characters long!")]
        [MaxLength(20, ErrorMessage = "Username must be between 5 and 20 characters long!")]
        public string Username { get; set; }


        [Required(ErrorMessage = "Password is required!")]
        [MinLength(10, ErrorMessage = "Password must be between 10 and 50 characters!")]
        [MaxLength(50, ErrorMessage = "Password must be between 10 and 50 characters!")]
        public string Password { get; set; }
    }
}
