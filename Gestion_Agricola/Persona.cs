using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Agricola
{
    public class Persona
    {
        private string Nombre, Apellido, Direccion, Cedula,Departamento;
        private DateTime Fecha_Nac;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, string direccion, string cedula,string departamento,DateTime fecha_nac)
        {
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Cedula = cedula;
            Fecha_Nac = fecha_nac;
            Departamento = departamento;


        }

 
    }
}
