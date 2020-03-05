using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoSaberPro.Models
{
    public class ClaseContexto : DbContext
    {
        public ClaseContexto() : base("Conexion2")
        {

        }
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
    }
}