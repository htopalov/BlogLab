using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {

        [MinLength(10, ErrorMessage = "Fullname must be between 5 and 20 characters long!")]
        [MaxLength(30, ErrorMessage = "Fullname must be between 5 and 20 characters long!")]
        public string Fullname { get; set; }


        [Required(ErrorMessage = "Email is required!")]
        [MaxLength(30, ErrorMessage = "Email can be 30 characters long!")]
        [EmailAddress(ErrorMessage = "Invalid email format!")]
        public string Email { get; set; }
    }
}
