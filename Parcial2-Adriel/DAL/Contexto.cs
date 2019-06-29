using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial2_Adriel.Entidades;

namespace Parcial2_Adriel.DAL
{
    public class Contexto : DbContext 
    {
        public DbSet<Inscripcion> inscripcions { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }

        public DbSet<Asignaturas> Asignaturas { get; set; }

        
        public Contexto() : base("ConStr")
        {

        }
    }
}
