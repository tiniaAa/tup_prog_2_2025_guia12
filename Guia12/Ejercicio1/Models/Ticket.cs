using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public abstract class Ticket
    {
        protected int nroOrden { get; set; }
        DateTime fechaHora { get; set;  }

        public Ticket() 
        {
            fechaHora = DateTime.Now;
        }
        public int VerNro()
        {
            return nroOrden ;
        }
        public DateTime VerFechaHora()
        {
            return fechaHora;
        }
        public override string ToString()
        {
            return $"{VerNro}{VerFechaHora():dd/MM/yyyy}";
        }

    }
}
