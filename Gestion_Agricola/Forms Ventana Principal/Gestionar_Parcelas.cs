using Sistema_Nomina.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_Agricola
{
    public partial class Gestionar_Parcelas : Form
    {
        public ConexionBD coneccion=new ConexionBD();   
        public Gestionar_Parcelas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void crearparcelas_Click(object sender, EventArgs e)
        {
            string query = "insert into Parcelas(Codigo,Cultivo,Fecha_abono,Limpieza,Fumigacion,Tiempo_Cosecha)" +
                "values(@_Codigo,@_Cultivo,@fecha_Abono,@_Limpieza,@_Fumigacion,@_Tiempo_Cosecha)";
            SqlCommand sqlcommand;

            try
            {
                sqlcommand = new SqlCommand(query,coneccion.conex);
                sqlcommand.Parameters.AddWithValue("@_Codigo",crearcodigo());
                sqlcommand.Parameters.AddWithValue("@_Cultivo",txtCultivo.Text);
                sqlcommand.Parameters.AddWithValue("@fecha_Abono", Convert.ToDateTime(datefechaabono.Text));
                sqlcommand.Parameters.AddWithValue("@_Limpieza",combolimpieza.Text);
                sqlcommand.Parameters.AddWithValue("@_Fumigacion", combofumigacion.Text);
                sqlcommand.Parameters.AddWithValue("@_Tiempo_Cosecha", combotiempocosecha.Text);
                sqlcommand.ExecuteNonQuery();

            }
            catch (IOException ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private string crearcodigo()
        {
            string cod = "001-cod";

            return cod ;
        }
    }
}
