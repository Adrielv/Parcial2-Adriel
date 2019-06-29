using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Adriel.Entidades
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }

        public DateTime FechaIngresos { get; set; }
        public string Nombres { get; set; }

        public decimal Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            FechaIngresos = DateTime.Now;
            Nombres = string.Empty;
            Balance = 0;
        }
    }
}
