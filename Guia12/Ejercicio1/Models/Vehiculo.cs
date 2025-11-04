using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Vehiculo:IComparable
    {
        string nroPatente { get; set; }
        Cliente dueño { get; set; }

        public Vehiculo(string patente, Cliente cliente)
        {
            this.nroPatente = patente;
            this.dueño = cliente;

        }
        public Cliente VerDueño()
        {

            return dueño;
        }
        string VerPatente()
        {

            return nroPatente;
        }

        public override string ToString()
        {
            return $"{nroPatente}";
        }
        public int CompareTo(object? obj)
        {
            Vehiculo vehiculo = obj as Vehiculo;

            if (vehiculo != null)
            {
                return nroPatente.CompareTo(vehiculo.nroPatente);
            }
            return -1;
        }
    }
}
