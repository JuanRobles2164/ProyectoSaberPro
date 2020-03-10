using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoSaberPro.Models
{
    public class LoginViewModels
    {
        public InputModel Input { get; set; }
        public string ErrorMessage { get; set; }
        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }
             
            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }


        }
    }
}