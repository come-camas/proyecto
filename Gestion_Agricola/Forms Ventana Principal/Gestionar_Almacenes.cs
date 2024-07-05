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
    public partial class Gestionar_Almacenes : Form
    {
        string contador;
        ConexionBD conex2 = new ConexionBD();
        public string fecha = DateTime.Now.ToString();
        public Gestionar_Almacenes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Insertar_Datos();
        }
        public void Insertar_Datos()
        {
            try
            {
                conex2.conex.Close();
                conex2.conex.Open();
                SqlCommand com;
                string ID = txtID.Text;
                string producto = cmbxProducto.Text;
                int cantidad = Convert.ToInt32(txtCantidad.Text);
                string cadsql = "insert into producto(ID, producto, cantidad, fechaMod) " +
                    "values(@ID,@producto,@cantidad,@fecha)";
                com = new SqlCommand(cadsql, conex2.conex);
                com.Parameters.AddWithValue("@ID", ID);
                com.Parameters.AddWithValue("@producto", producto);
                com.Parameters.AddWithValue("@cantidad", cantidad);
                com.Parameters.AddWithValue("@fecha", fecha);
                com.ExecuteNonQuery();
                conex2.conex.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                throw;
            }

        }

        private void cmbxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxProducto.Text == "arroz")
            {
                txtID.Text = crearCodigo(contador);
            }
            else if (cmbxProducto.Text == "zanahorias")
            {
                txtID.Text = crearCodigo(contador);
            }
            else if (cmbxProducto.Text == "papas")
            {
                txtID.Text = crearCodigo(contador);
            }
            else if (cmbxProducto.Text == "frijol")
            {
                txtID.Text = crearCodigo(contador);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public string crearCodigo(string contador)
        {
            contador = DateTime.Now.ToShortTimeString();
            string cod = cmbxProducto.Text.Substring(0, 2);
            string cod2= contador.Substring(3,2);
            return cod + "-" + cod2;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
