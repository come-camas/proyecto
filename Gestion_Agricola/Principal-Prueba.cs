using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.DirectoryServices;
using System.Transactions;

namespace Gestion_Agricola
{
    public partial class Principal_Prueba : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Principal_Prueba()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private Form activeForm = null;
        private void AbrirFormHijo(Form hijo)
        {
            if (activeForm != null)

                activeForm.Close();
            activeForm = hijo;
            hijo.TopLevel = false;
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.Dock = DockStyle.Fill;
            ChildrenForm.Controls.Add(hijo);
            ChildrenForm.Tag = hijo;
            hijo.BringToFront();
            hijo.Show();

        }
        public void ocultar()
        {
            if (subPanelAlmacenes.Visible == true)
            {
                subPanelAlmacenes.Visible = false;
            }
            if (subPanelAgendayCalendario.Visible == true)
            {
                subPanelAgendayCalendario.Visible = false;
            }
            if (subPanelAnalisisDelClima.Visible == true)
            {
                subPanelAnalisisDelClima.Visible = false;
            }
            if (subPanelParcelas.Visible == true)
            {
                subPanelParcelas.Visible = false;
            }
        }
        public void MostrarSubmenu(Panel SubMenu)
        {
            cerrar();
            if (SubMenu.Visible == false)
            {
                ocultar();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void btAlmacenes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(subPanelAlmacenes);
        }

        private void btAgendayCalendario_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(subPanelAgendayCalendario);

        }

        private void btAnalisisdelClima_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(subPanelAnalisisDelClima);
        }

        private void btParcelas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(subPanelParcelas);
        }
        public void cerrar()
        {
            subPanelParcelas.Visible = false;
            subPanelAgendayCalendario.Visible = false;
            subPanelAnalisisDelClima.Visible = false;
            subPanelParcelas.Visible=false;

        }
    }
}
