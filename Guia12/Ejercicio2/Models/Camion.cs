using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Camion:IComparable
    {
        DateTime fecha;
        int cantidad;
        double valorAsegurado;
        public int NroRegistro { get; set; }
        Stack<Auto>transporte = new Stack<Auto>();


        public Camion(DateTime fecha, int cantidad)
        {
            this.fecha = fecha;
            this.cantidad = cantidad;

        }
        public Camion(int nroRegistro)//agregado para poder buscarlo por su numero de registro (no aparece en el uml pero fili agrega cosas parecidads en el uml)
        {
            this.NroRegistro = nroRegistro;
        }
        public void CargarVehiculo(Auto unAuto)
        {
            if (cantidad>transporte.Count)
            {
                transporte.Push(unAuto);

            }

        }
        public Auto RetirarVehiculo()
        {
            Auto autoRetirado = null;

            if (transporte.Count>0)
            {
                autoRetirado= transporte.Pop();

                return autoRetirado;
            }

            return autoRetirado;
        }
        public string[] VerCarga()
        {
            string[] listaCarga = new string[transporte.Count];
            int n = 0;
            foreach (Auto a in transporte)
            {
                listaCarga[n++] = a.ToString();

            }
            return listaCarga;
        }
        public string ToString()
        {
            return $"{NroRegistro}-{fecha:yyyyMMdd}";
        }
        public double ValorAsegurado()
        {
            return valorAsegurado;
        }
        public int CantidadVehiculos()
        {
            int cantidad = transporte.Count;
            return  cantidad; 
        }

        public int CompareTo(object? obj)
        {
            Camion camion = obj as Camion;

            if (camion!=null)
            {
                return NroRegistro.CompareTo(camion.NroRegistro);
            }

            return -1;
        }
    }
}
