using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Cliente:Ticket
    {
        long dni { get; set; }
        static int numero { get; set; }
        public int TipoVehiculo { get; set; }
        public Cliente(string dni):base()
        {

            nroOrden = ++numero;

            bool verificador;
            if (dni.Length>0)
            {
                verificador = true;

                for (int n =0; n<dni.Length && verificador ==true;n++)
                {
                    bool num = char.IsNumber(dni[n]);
                    if (num==false)
                    {
                        verificador=false;
                    }
                }
                if (verificador!=true)
                {
                    throw new FormatoDniNoValidoException("Se ingresaron Caracteres no numericos");
                }
                this.dni = long.Parse(dni);
                if (this.dni < 5000000)
                {

                    throw new FormatoDniNoValidoException("Dni no valido, se debe ingresar dni mayor a 5000000");
                }

            }
            else
            {
                throw new FormatoDniNoValidoException("Dni ingresado sin numeros"); 
            }

        }
        public override string ToString()
        {
            return $"Cliente;{base.ToString};{dni}";
        }
    }
}
