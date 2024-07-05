using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Nomina.Clases
{
    public class ConexionBD
    {
        
        public string CodConex = "Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=proyectoE; Integrated Security=true";
        public SqlConnection conex;
        public SqlCommand comsql;
        public SqlDataReader data;

        public ConexionBD()
        {
            try
            {
                conex = new SqlConnection(CodConex);
                conex.Open();
                MessageBox.Show("Conexion Exitosa.");

            }
            catch (IOException ex)
            {
                MessageBox.Show("Ocurrio un error "+ex.Message);
                throw;
            }
           
        }
        
        public void InsertarDatos(string codComm)
        {
            try
            {
                comsql = new SqlCommand(codComm, conex);
                comsql.ExecuteNonQuery();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error "+ex.Message);
                throw;  
            }

        }
        public void readDataFromDataBase(DataGridView tablaForm, string table)
        {
            conex.Close();

            try
            {
                conex.Open();
                string query = $"select * from {table}";
                comsql = new SqlCommand(query, conex);
                SqlDataReader lector = comsql.ExecuteReader();
                string[] regist = new string[lector.FieldCount];
                while (lector.Read())
                {
                    for (int i = 0; i < lector.FieldCount; i++)
                    {
                        regist[i] = lector[i].ToString();
                    }
                    tablaForm.Rows.Add(regist);
                }
                conex.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Ha ocurrido un error" + ex.ToString());
            }
        }

    }
}
