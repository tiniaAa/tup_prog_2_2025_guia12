using Ejercicio2.Models;
using System.Reflection;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Sistema sistema = new Sistema();
        int nroCamion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearCamion_Click(object sender, EventArgs e)
        {
            int Capacidad = Convert.ToInt32(tbCapacidad.Text);
            DateTime fecha = dtpFecha.Value;
            nroCamion = sistema.GenerarCamion(fecha, Capacidad);



        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Auto autoACargar = lbxListaDeAutos.SelectedItem as Auto;

            if (autoACargar != null)
            {
                sistema.CargarCamion(nroCamion, autoACargar);
                lbxListaDeAutos.Items.Remove(autoACargar);
                lbxListaDeAutos.SelectedItem = null;
            }
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            Auto descargado = sistema.DescargarCamion(nroCamion);
            lbxListaDeAutos.Items.Add(descargado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                saveFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;

                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("nroRegistro;modelo");

                    Camion camion = sistema.VerCamion(nroCamion);

                    foreach (string linea in camion.VerCarga())
                    {
                        sw.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                }
            }


        }

        private void btnRecibirCamion_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    String path = openFileDialog1.FileName;
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    sr.ReadLine();//leo el encabezado 

                    while (!sr.EndOfStream)
                    {
                        //formato
                        //nroRegistro; modelo; precio

                        string linea = sr.ReadLine();
                        string[] campos = linea.Split(';');
                        int nroRegistro = Convert.ToInt32(campos[0]);
                        string modelo = campos[1];
                        double precio = Convert.ToDouble(campos[2]);

                        Auto autoDeAgencia = new Auto(nroRegistro, modelo);
                        autoDeAgencia.Precio = precio;

                        lbxListaDeRecibos.Items.Add(autoDeAgencia);
                    }

                    Camion camionDeFabrica = new Camion(DateTime.Now, lbxListaDeRecibos.Items.Count);

                    sistema.RecibirCamion(camionDeFabrica);

                    foreach (Auto a in lbxListaDeRecibos.Items)
                    {
                        sistema.CargarCamion(camionDeFabrica.NroRegistro, a);

                    }
                    nroCamion = camionDeFabrica.NroRegistro;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (sr != null) { sr.Close(); } if (fs != null) { fs.Close(); } }
        }

        private void btnDescargarCamion_Click(object sender, EventArgs e)
        {
           
            if (nroCamion!=0)
            {
                Auto auto = sistema.DescargarCamion(nroCamion);

                lbxListaDeRecibos.Items.Remove(auto);
                lbxListaDeAutos.Items.Add(auto);


            }


        }
    }
}
