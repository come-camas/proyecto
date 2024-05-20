using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Agricola
{
    public partial class Tareas_Pendientes_Crears : Form
    {
        static public string ruta=Directory.GetCurrentDirectory().Replace("\\net7.0-windows","");
        public string Fichero_TareaPendiente = "Tareas_Pendientes "+ruta+".txt";
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
            FileStream fs = new FileStream("Tarea_Pendiente_ "+ruta+".txt",FileMode.Create,FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            sw.Write("Descripcion: "+txtDescripcion.Text+" Fecha de Vencimiento: "+dtpkFechaVencimiento.Text+" Prioridad: "+cmbxPrioridad.Text+" Notas: "+txtNotas.Text);
            sw.Close();
            MessageBox.Show("Se creo correctamente");
            this.Close();
        }
    }
}
