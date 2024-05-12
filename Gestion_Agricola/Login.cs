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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Datos_login_Click(object sender, EventArgs e)
        {
            if (usuario_login.Text == "usuario" && contraseña_login.Text == "123")
            {
                Ventana_Gerente gt = new Ventana_Gerente();
                this.Hide();
                gt.Show();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña es incorrecto");
                usuario_login.Clear();
                contraseña_login.Clear();

            }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            usuario_login.Clear();
            contraseña_login.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
