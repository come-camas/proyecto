using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            FileStream fs = new FileStream("Tarea_Pendiente_ " + ruta + ".txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write("Descripcion: " + txtDescripcion.Text + " Fecha de Vencimiento: " + dtpkFechaVencimiento.Text + " Prioridad: " + cmbxPrioridad.Text + " Notas: " + txtNotas.Text);
            sw.Close();
            MessageBox.Show("Se creo correctamente");
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
