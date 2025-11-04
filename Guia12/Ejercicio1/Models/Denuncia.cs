using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Denuncia:Ticket
    {
        Vehiculo dominio { get; set; }
        static int numero { get; set; }

        public Denuncia(Vehiculo asegurado):base()
        {   
            this.dominio = asegurado;
            nroOrden=++numero;
   
        }
        public override string ToString()
        {
            return $"DENUNCIA;{base.ToString()};{dominio.ToString()}";
        }
    }
}
