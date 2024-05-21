using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Agricola
{
    public class Persona
    {
        private string Nombre, Apellido, Cedula, Direccion,Departamento;
        private DateTime Fecha_Nac;

        public Persona()
        {
        }

        public Persona(string nombre, string apellido, string cedula, string direccion, string departamento, DateTime fecha_Nac)
        {
            Nombre = nombre;
            Apellido = apellido;
            Cedula = cedula;
            Direccion = direccion;
            Departamento = departamento;
            Fecha_Nac = fecha_Nac;
        }
    }
}
