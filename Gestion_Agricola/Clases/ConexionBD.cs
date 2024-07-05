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
        public string CodConex = "Data Source=LAPTOP\\SQLEXPRESS;Initial Catalog=GestionAgricola; Integrated Security=true";
        public SqlConnection conex;
        public SqlCommand comsql;
        public SqlDataReader data;

        public ConexionBD()
        {
            try
            {
                conex = new SqlConnection(CodConex);
                conex.Open();
                
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

        
/* create database GestionAgricola

use GestionAgricola
go
create table Parcelas(Codigo varchar(20),Cultivo varchar(20),Fecha_abono varchar(20),Limpieza varchar(20),Fumigacion varchar(20),Tiempo_Cosecha varchar(20))

create table producto(ID varchar(10), producto varchar(15), cantidad int, fechaMod varchar(12))

*/
    }
}
