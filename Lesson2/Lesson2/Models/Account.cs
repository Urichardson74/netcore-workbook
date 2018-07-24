using System.ComponentModel.DataAnnotations;
using System;

namespace Lesson2.Model
{
    public class Account
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

    }
}
