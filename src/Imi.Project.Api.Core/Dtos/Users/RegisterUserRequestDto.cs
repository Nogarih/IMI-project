using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Imi.Project.Api.Core.Dtos.Users
{
    public class RegisterUserRequestDto : BaseDto
    {
        [Required]
        public string UserName { get; set; }

        [Required] 
        [DataType(DataType.EmailAddress)] 
        public string Email { get; set; }

        [Required] 
        [DataType(DataType.Password)] 
        public string Password { get; set; }

        [DataType(DataType.Password)] 
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")] 
        public string ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }

        [Required]
        public bool AcceptTermsAndConditions { get; set; }
    }
}