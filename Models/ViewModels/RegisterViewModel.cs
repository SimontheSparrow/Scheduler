﻿using System.ComponentModel.DataAnnotations;

namespace Scheduler.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(100, ErrorMessage ="The {0} must be at least {2} characters long", MinimumLength = 6)]
        public string Password { get; set; }
        [Required]
        [Display(Name ="Confirm password")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
        [Required]
        [Display(Name ="Role name")]
        public string RoleName { get; set; }
    }
}
