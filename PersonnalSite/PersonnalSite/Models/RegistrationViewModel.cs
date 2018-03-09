using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Validation.Web.Models
{
    public class RegistrationViewModel
    {
        [Required]
        [MaxLength(20, ErrorMessage = "Your name is too long.")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Your name is too long.")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [Compare("Email", ErrorMessage = "Email addresses don't match.")]
        public string ConfirmEmail { get; set; }

        [Required]
        [MinLength(8, ErrorMessage = "Password must be 8 characters or more.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date, ErrorMessage = "That's not a valid date.")]
        public DateTime Birthday { get; set; }

        [Required]
        [Range(1,10, ErrorMessage = "Only 1 - 10.")]
        public int NumberofTickets { get; set; }

    }
}