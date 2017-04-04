using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FisaPostului.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password{ get; set; }
        [Display(Name = "Confirm Password")]
        [Required]
        public string ConfirmPassword { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string FirstName{ get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}