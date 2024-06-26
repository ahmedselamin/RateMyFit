﻿using System.ComponentModel.DataAnnotations;

namespace RateMyFit.Shared
{
    public class UserRegister
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, StringLength(20, MinimumLength = 5)]
        public string Password { get; set; } = string.Empty;
        [Compare("Password", ErrorMessage = "The passwords do not match!")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
