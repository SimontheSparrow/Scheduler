﻿using System.ComponentModel.DataAnnotations;

namespace Scheduler.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [Display(Name ="Remember me?")]
        public bool RememberMe { get; set; }
    }
}
