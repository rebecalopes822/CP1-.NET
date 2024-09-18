﻿using System.ComponentModel.DataAnnotations;

namespace CP1_.NET.Models.DTOs
{
    public class loginDTO
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
    }
}