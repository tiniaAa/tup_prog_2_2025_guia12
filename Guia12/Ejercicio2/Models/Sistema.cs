using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    public class Sistema
    {
        int numero;
        public int NroOrden { get { return numero++; } }
        List<Auto> listaAuto = new List<Auto>();
        List<Camion> listaCamiones = new List<Camion>();

        public void RecibirCamion(Camion unCamion)
        {
            listaCamiones.Add(unCamion);
            unCamion.NroRegistro = NroOrden;
        }
        public Auto DescargarCamion(int nroOrden)
        {
            Camion Buscado = VerCamion(nroOrden);
            Auto Retirado = null;
            if (Buscado != null)
            {
                Retirado=Buscado.RetirarVehiculo();
                listaAuto.Add(Retirado);

                return Retirado;
            }
            return null;
        }
        public int GenerarCamion(DateTime fecha,int capacidad)
        {
            Camion camion = new Camion(fecha,capacidad);
            listaCamiones.Add (camion);
            camion.NroRegistro= NroOrden;


            return camion.NroRegistro;

        }
        public void CargarCamion(int nroOrden,Auto unAuto)
        {
            Camion buscado = VerCamion(nroOrden);

            if (buscado!=null)
            {
                buscado.CargarVehiculo(unAuto);
            }
        }
        public Camion VerCamion(int nroOrden)
        {
            Camion camion = new Camion(nroOrden);

            listaCamiones.Sort();

            int idx = listaCamiones.BinarySearch(camion);

            if (idx>=0)
            {
                Camion buscado = listaCamiones[idx];
                return buscado;
            }
            return null;
        }

    }
}
