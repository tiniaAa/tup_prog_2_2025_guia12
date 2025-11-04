using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Auto
    {
        int numeroRegistro;
        string modelo;
        public double Precio { get; set; }

        public Auto(int registro, string modelo)
        {
            this.numeroRegistro = registro;
            this.modelo = modelo;
        }
        public int nroRegistro()
        {
            return numeroRegistro;
        }
        public override string ToString()
        {
            return $"{numeroRegistro};{modelo}";
        }
    }
}
