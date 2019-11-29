using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class User
    {
        public int UserId { get; set; }

        [Remote(action: "VerifyLogin", controller: "Users")]
        [Required]
        [MaxLength(50, ErrorMessage = "Login cannot exceed 50 characters")]
        public string Login { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password ,ust contain at least 8 characters")]
        [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
        public string Password { get; set; }
    }
}
