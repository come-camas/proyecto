using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Agricola.Clases
{
    public class Empleado : Persona
    {
        private string Codigo, Cargo, Telefono, Email;
        private DateTime Fecha_Ingreso;
        private double Salario;

        public Empleado()
        {
        }

        public Empleado(string codigo, string cedula, string nombre, string apellido, string telefono, string direccion, string email, string departamento, string cargo, DateTime fecha_nac, DateTime fecha_ingreso) : base(nombre, apellido, cedula, direccion, departamento, fecha_nac)
        {
            Codigo = codigo;
            Cargo = cargo;
            Telefono = telefono;
            Email = email;
            Fecha_Ingreso = fecha_ingreso;
            Salario = determinarsalario(cargo);

        }

        public string codigoE { get; }
        public string cedulaE { get; }
        public string nombreE { get; set; }
        public string apellidoE { get; set; }
        public string telefonoE { get; set; }
        public string direccionE { get; set; }
        public string emailE { get; set; }
        public string departamentoE { get; set; }
        public string cargoE { get; set; }
        public DateTime fecha_nacE { get; }
        public DateTime fecha_IngresoE { get; }

        private double determinarsalario(string cargo)
        {
            double sal = 0.0;

            var Salarios = new Dictionary<string, double>()
            {
                {"Gerente", 1000 },{ "Administrativo",2000},{"Agricultor",2000 }

            };

            foreach (string clave in Salarios.Keys)
            {
                if (cargo.Equals(clave))
                {

                    sal = Salarios[clave];
                }


            }

            return sal;

        }
    }
}
