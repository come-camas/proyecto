using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Agricola
{
    public class Empleadocs:Persona
    {
        private string Codigo, Telefono, Email,Cargo;
        private double Salario;
        private DateTime Fecha_Ingreso;

        public Empleadocs()
        {
        }

        public Empleadocs(string codigo,string cedula,string nombre,string apellido,string departamento,string direccion, string telefono, string email, string cargo, DateTime fecha_Ingreso,DateTime fecha_nac):base(nombre,apellido,direccion,cedula,departamento,fecha_nac)
        {
            Codigo = codigo;
            Telefono = telefono;
            Email = email;
            Salario = SalarioEmple(cargo);
            Cargo = cargo;
            Fecha_Ingreso = fecha_Ingreso;
        }

        private double SalarioEmple(string cargo)
        {
            double sal = 0.0;

            var salarios = new Dictionary<string, double>() {
                {"Gerente",3000 },{"Administracion",1000},{"Chambeador",1500 }
            
            };

            foreach (string s in salarios.Keys) {
                if (s.Equals(cargo)){
                    sal = salarios[s];
                }
            }

            return sal;

        }

        public string codigoE {  get; set; }
        public string cedulaE { get;}
        public string nombreE { get;set; }
        public string apellidoE { get; set; }
        public string direccionE {  get; set; }
        public string departamentoE { get; private set; }
        public string telefonoE { get;set; }
        public string emailE { get; set; }
        public double salarioE { get;set; }
        public string cargoE { get; set; }  
        public DateTime fecha_Ingreso { get;}
        public DateTime fecha_nac { get;}


        





    }
}
