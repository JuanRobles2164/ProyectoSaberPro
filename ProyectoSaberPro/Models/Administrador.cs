﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoSaberPro.Models
{
    public class Administrador
    {
        public int ID { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string Nombres { get; set; }
        public string Username { get; set; }
    }
}