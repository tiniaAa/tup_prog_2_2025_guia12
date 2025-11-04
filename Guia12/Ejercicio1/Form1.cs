using Ejercicio1.Models;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {

        Agencia agencia;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            FileStream fs = null;
            string path = "agencia.dat";
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
#pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                agencia = bf.Deserialize(fs) as Agencia;

#pragma warning disable SYSLIB0011



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                agencia = null;
            }
            finally { if (fs != null) { fs.Close(); } }

            if (agencia == null)
            {
                agencia = new Agencia();

                agencia.AgregarVehiculo("ABC123", 45312756);
                agencia.AgregarVehiculo("ABC345", 35122536);
                agencia.AgregarVehiculo("AAA111", 33666336);

            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            try
            {

                Ticket ticket = null;
                string dni = tbDNI.Text;


                if (rdbtDenuncia.Checked)
                {
                    string patente = tbDenuncia.Text;
                    Vehiculo asegurado = agencia.VehiculosDeAgencia(patente);
                    if (asegurado != null)
                    {
                        ticket = new Denuncia(asegurado);
                        agencia.AgregarTicket(ticket);

                        lbTurnos.Items.Add(ticket);
                    }
                    else { MessageBox.Show("Vehiculo no está registrado en la agenica"); }
                }
                if (rdbtNuevoCliente.Checked)
                {
                    int tipo = cbTipo.SelectedIndex + 1;
                    ticket = new Cliente(dni);
                    ((Cliente)ticket).TipoVehiculo = tipo;

                    agencia.AgregarTicket(ticket);
                    lbTurnos.Items.Add(ticket);
                }
                rdbtDenuncia.Checked = false;
                rdbtNuevoCliente.Checked = false;
            }
            catch (FormatoDniNoValidoException ex) { MessageBox.Show(ex.Message, "DNI no valido"); }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { }


        }

        private void btnAtenderDenuncias_Click(object sender, EventArgs e)
        {
            Ticket ticket = agencia.AtenderTicket(0);
            if (ticket != null)
            {
                lbTurnos.Items.Remove(ticket);
            }
        }

        private void btnAtenderCliente_Click(object sender, EventArgs e)
        {
            Ticket ticket = agencia.AtenderTicket(1);

            if (ticket != null)
            {
                lbTurnos.Items.Remove(ticket);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            FileStream fs = null;
            string path = "agencia.dat";
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);
#pragma warning disable SYSLIB0011
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, agencia);

#pragma warning disable SYSLIB0011
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (fs != null) { fs.Close(); } }


        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FileStream fs = null;
            StreamReader sr = null;
            openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = openFileDialog1.FileName;
                    fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                    sr = new StreamReader(fs);

                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        //Formay
                        //patente;dni

                        string linea = sr.ReadLine();

                        string[] campos = linea.Split(';');

                        string patente = campos[0];
                        int dni = Convert.ToInt32(campos[1]);

                        agencia.AgregarVehiculo(patente, dni);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { if (fs != null) { fs.Close(); } if (sr != null) { sr.Close(); } }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FileStream fs=null;
            StreamWriter sw = null;
            try
            {
                saveFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string path = saveFileDialog1.FileName;

                    fs = new FileStream(path, FileMode.Open, FileAccess.Write);
                    sw = new StreamWriter(fs);

                    sw.WriteLine("TIPO:DENUNCIA;NroTicket;Fecha;Patente");
                    sw.WriteLine("TIPO:CLIENTE;NroTicket;Fecha;DNI");

                    foreach (Ticket t in agencia.ListaAtendidos)
                    {
                        sw.WriteLine(t.ToString());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { if (fs!=null) { fs.Close(); } if (sw!=null){ sw.Close();}}
        }
    }
}
