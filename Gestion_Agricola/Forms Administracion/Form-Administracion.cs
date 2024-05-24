using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Agricola
{
    public partial class Form_Administracion : Form
    {
       
        public Form_Administracion()
        {
            InitializeComponent();
        }

        private void Salir_Nomina_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }

        Form formularioactivo = null;
        private void abrirformularios(Form formhijo)
        { 
            if (formularioactivo != null) 

              
              formularioactivo = formhijo;
              formhijo.TopLevel = false;
              formhijo.FormBorderStyle = FormBorderStyle.None;
              formhijo.Dock = DockStyle.Fill;
              formhijo.Controls.Add(formhijo);
              formhijo.Tag = formhijo;
              formhijo.BringToFront();
              formhijo.Show();

            



        }

        private void Crear_Nomina_Click(object sender, EventArgs e)
        {
            abrirformularios(new Crear_Nomina());
        }
    }
}
