using Sistema_Nomina.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Agricola
{
    public partial class Tareas_Pendientes : Form
    {
        public ConexionBD conex;
        public Tareas_Pendientes()
        {
            InitializeComponent();
            ShowData();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Tareas_Pendientes_Crears s = new Tareas_Pendientes_Crears();

            s.ShowDialog();
        }

        private void Tareas_Pendientes_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public void ShowData()
        {
            conex = new ConexionBD();
            conex.conex.Close();
            string query = "select * from Tar_PenN where estadoTar='P'";
            try
            {
                conex.conex.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, conex.conex);
                DataTable dt1 = new DataTable();
                adapter.Fill(dt1);
                dataGridView1.DataSource = dt1;
                conex.conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){}

        private void btnAHoy_Click(object sender, EventArgs e)
        {
            
            string fecha_emision;
            string nivel_p;
            string nom_tarea;
            string fecha_Cancel;

            fecha_emision = dataGridView1.SelectedCells[1].Value.ToString();
            nivel_p = dataGridView1.SelectedCells[2].Value.ToString();
            nom_tarea = dataGridView1.SelectedCells[3].Value.ToString();
            fecha_Cancel = dataGridView1.SelectedCells[5].Value.ToString();
            MessageBox.Show(fecha_emision + " " + nivel_p + " " + nom_tarea  + " " + fecha_Cancel);
            string query = $"Update Tar_PenN set estadoTar = 'C' where nivel_p = '{nivel_p}' and nom_tarea = '{nom_tarea}' ";

            conex = new ConexionBD();
            conex.conex.Close();
            try
            {
                conex.conex.Open();
                SqlCommand comando = new SqlCommand(query, conex.conex);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cambio realizado correctamente");
                conex.conex.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.ToString());
            }
            ShowData();
        }
    }
}
