using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    [Serializable]
    public class Agencia
    {
        public List<Ticket> ListaAtendidos = new List<Ticket>();

        Queue<Cliente> nuevosClientes = new Queue<Cliente>();
        List<Vehiculo> listaVehiculo = new List<Vehiculo>();
        Queue<Denuncia> denuncias = new Queue<Denuncia>();

        //algo parecido a lo que agrego fili para ver trabajar con los vehiculos de la agencia 
        public Vehiculo VehiculosDeAgencia(string patente)
        {
            Vehiculo vehiculoRegistrado = new Vehiculo(patente, null);
            listaVehiculo.Sort();
            int idx = listaVehiculo.BinarySearch(vehiculoRegistrado);
            if (idx >= 0)
            {
                return listaVehiculo[idx];
            }
            return null;

        }

        public void AgregarTicket(Ticket turno)
        {

            if (turno != null)
            {
                if (turno is Denuncia)
                {


                    Denuncia denuncia = turno as Denuncia;
                    denuncias.Enqueue(denuncia);
                }
                else if (turno is Cliente)
                {
                    Cliente cliente = turno as Cliente;
                    nuevosClientes.Enqueue(cliente);

                }

            }

        }
        public Ticket AtenderTicket(int tipo)
        {

            Ticket atendido = null;

            if (tipo == 0)
            {
                if (denuncias.Count > 0)
                {
                    atendido = denuncias.Dequeue();

                }

            }
            else if (tipo == 1)
            {
                if (nuevosClientes.Count > 0)
                {

                    atendido = nuevosClientes.Dequeue();
                }

            }
            if (atendido != null)
            {
                ListaAtendidos.Add(atendido);
            }
            return atendido;
        }
        
        public void AgregarVehiculo(string nroPantente, int dniDueño)
        {
            Vehiculo nuevo = VehiculosDeAgencia(nroPantente);

            if (nuevo == null)
            {
                Cliente cliente = new Cliente(nroPantente);
                nuevo = new Vehiculo(nroPantente, cliente);
                listaVehiculo.Add(nuevo);
            }
        }


    }
}
