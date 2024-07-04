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
    public partial class VerAlmacenes : Form
    {
        ConexionBD conex2 = new ConexionBD();
        public string ruta = Directory.GetCurrentDirectory();
        public VerAlmacenes()
        {
            InitializeComponent();
            MostrarTablaSQL();
        }

        private void VerAlmacenes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MostrarTablaSQL()
        {
            conex2.conex.Close();
            string query = "Select * From producto";
            try
            {
                conex2.conex.Open();
                SqlCommand com = new SqlCommand(query, conex2.conex);
                SqlDataReader red = com.ExecuteReader();
                string[] fila = new string[red.FieldCount];
                while (red.Read())
                {
                    for (int i = 0; i < red.FieldCount; i++)
                    {
                        fila[i] = red[i].ToString();
                    }
                    dtgAlmacenes.Rows.Add(fila);
                }
                conex2.conex.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }
    }
}
