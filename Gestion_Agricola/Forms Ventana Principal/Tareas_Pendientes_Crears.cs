using Sistema_Nomina.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Agricola
{
    public partial class Tareas_Pendientes_Crears : Form
    {
        ConexionBD conex;
        public static DateTime fechaActual;
        public DateTime _fechaActual
        {
            get { return fechaActual; }
            set { fechaActual = value; }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        static public string ruta = Directory.GetCurrentDirectory().Replace("\\net7.0-windows", "");
        public string Fichero_TareaPendiente = "Tareas_Pendientes " + ruta + ".txt";
        public Tareas_Pendientes_Crears()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            conex = new ConexionBD();
            conex.conex.Close();

            
            //Insertando Datos en la Base de Datos: 
            
            string fecha_emision = DateTime.Now.ToString();
            string nivel_p = cmbxPrioridad.Text;
            string nom_tarea = txtDescripcion.Text;
            string detalleTar = txtNotas.Text;
            string fecha_Cancel = dtpkFechaVencimiento.Text;
            string estadoTar = "P";
            string query = "insert into Tar_PenN(estadoTar, fecha_emision, nivel_p, nom_tarea, detalleTar, fecha_Cancel) " +
                "values (@estadoTar, @fecha_emision, @nivel_p, @nom_tarea, @detalleTar, @fecha_Cancel) ";

            try
            {
                conex.conex.Open();
                SqlCommand sqlcom = new SqlCommand(query, conex.conex);
                sqlcom.Parameters.AddWithValue("@estadoTar", estadoTar);
                sqlcom.Parameters.AddWithValue("@fecha_emision", @fecha_emision);
                sqlcom.Parameters.AddWithValue("@nivel_p", nivel_p);
                sqlcom.Parameters.AddWithValue("@nom_tarea", nom_tarea);
                sqlcom.Parameters.AddWithValue("@detalleTar", detalleTar);
                sqlcom.Parameters.AddWithValue("@fecha_Cancel", fecha_Cancel);
                sqlcom.ExecuteNonQuery();
                conex.conex.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: "+ ex.ToString());
            }

            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
