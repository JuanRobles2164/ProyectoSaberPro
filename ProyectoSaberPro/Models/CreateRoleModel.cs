using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoSaberPro.Models
{
    public class CreateRoleModel
    {
        public CreateRoleModel(){}
        [Required]
        public string RoleName { get; set; }
        
    }
}