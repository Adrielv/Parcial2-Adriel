using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_Adriel.Entidades
{
    public class Inscripcion
    {
        [Key]

        public int InscripcionId { get; set; }

        public DateTime Fecha { get; set; }

        public decimal Monto { get; set; }

        public decimal MontoTotal { get; set; }

        public virtual List<InscripcionDetalle> Asignaturas { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            MontoTotal = 0;
            Asignaturas = new List<InscripcionDetalle>();
        }
        public void CalcularMonto()
        {
            decimal total = 0;

            foreach (var item in Asignaturas)
            {
                total += item.SubTotal;
            }

            MontoTotal = total;
        }
    }
}
