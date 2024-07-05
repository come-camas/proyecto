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
            cmbxColor.Text = "Oscuro";
            cerrar();
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
            if (subPanelParcelas.Visible == true)
            {
                subPanelParcelas.Visible = false;
            }
        }
        public void MostrarSubmenu(Panel SubMenu)
        {

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
            MessageBox.Show("Este proceso no se ha terminado...");
            //AbrirFormHijo(new Analisis_Hoy());
        }

        private void btParcelas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(subPanelParcelas);
        }
        public void cerrar()
        {
            subPanelAlmacenes.Visible = false;
            subPanelParcelas.Visible = false;
            subPanelAgendayCalendario.Visible = false;
            subPanelParcelas.Visible = false;
        }

        private void btVerAlmacenes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VerAlmacenes());
            ocultar();
        }

        private void btGestionarAlmacenes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Gestionar_Almacenes());
            ocultar();
        }

        private void btTareasPendientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Tareas_Pendientes());
            ocultar();
        }

        private void btRecordatorio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Recordatorio());
            ocultar();
        }

        private void btCalendario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este proceso no se ha terminado...");
            //AbrirFormHijo(new Calendario());
            //ocultar();
        }

        private void btAnalisisClimaHoy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este proceso no se ha terminado...");
            //AbrirFormHijo(new Analisis_Hoy());
            //ocultar();
        }

        private void btAnalisisClima15dias_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new Analisis_15Dias());
            //ocultar();
        }

        private void btAnalisisClima30diass_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new Analisis_30Dias());
            //ocultar();
        }

        private void btVerParcelas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Este proceso no se ha terminado...");
            //AbrirFormHijo(new Ver_Parcelas());
            //ocultar();
        }

        private void btGestionarParcelas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Gestionar_Parcelas());
            ocultar();
        }

        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            ocultar();
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToLongTimeString();
            lbfecha.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ChildrenForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Informacion s = new Informacion();
            //s.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CambiarColor();
        }
        public void CambiarColor()
        {
            
            if (cmbxColor.Text == "Verde")
            {
                panel1.BackColor = Color.Teal;

                btAlmacenes.BackColor = Color.DarkCyan;
                btAgendayCalendario.BackColor = Color.DarkCyan;
                btAnalisisdelClima.BackColor = Color.DarkCyan;
                btParcelas.BackColor = Color.DarkCyan;
                btCerrarSesion.BackColor = Color.DarkCyan;
                pictureBox4.BackColor = Color.CadetBlue;
                panel3.BackColor = Color.CadetBlue;
                subPanelAlmacenes.BackColor = Color.CadetBlue;
                subPanelAgendayCalendario.BackColor = Color.CadetBlue;
                subPanelParcelas.BackColor = Color.CadetBlue;
                panel2.BackColor = Color.CadetBlue;
                ChildrenForm.BackColor = Color.DarkSlateGray;

                btVerAlmacenes.BackColor = Color.CadetBlue;
                btGestionarAlmacenes.BackColor = Color.CadetBlue;
                btTareasPendientes.BackColor = Color.CadetBlue;
                btRecordatorio.BackColor = Color.CadetBlue;
                btCalendario.BackColor = Color.CadetBlue;
                btVerParcelas.BackColor = Color.CadetBlue;
                btGestionarParcelas.BackColor = Color.CadetBlue;
            }
            else if (cmbxColor.Text == "Oscuro")
            {

                panel1.BackColor = Color.FromArgb(64, 64, 64);
                btAlmacenes.BackColor = Color.DimGray;
                btAgendayCalendario.BackColor = Color.DimGray;
                btAnalisisdelClima.BackColor = Color.DimGray;
                btParcelas.BackColor = Color.DimGray;
                btCerrarSesion.BackColor = Color.DimGray;
                pictureBox4.BackColor = Color.Silver;
                subPanelAlmacenes.BackColor = Color.Silver;
                subPanelAgendayCalendario.BackColor = Color.Silver;
                subPanelParcelas.BackColor = Color.Silver;
                panel2.BackColor = Color.Silver;
                ChildrenForm.BackColor = Color.DimGray;

                btVerAlmacenes.BackColor = Color.Silver;
                btGestionarAlmacenes.BackColor = Color.Silver;
                btTareasPendientes.BackColor = Color.Silver;
                btRecordatorio.BackColor = Color.Silver;
                btCalendario.BackColor = Color.Silver;
                btVerParcelas.BackColor = Color.Silver;
                btGestionarParcelas.BackColor = Color.Silver;
            }
            else if (cmbxColor.Text == "Morado")
            {

                panel1.BackColor = Color.Indigo;
                btAlmacenes.BackColor = Color.Indigo;
                btAgendayCalendario.BackColor = Color.Indigo;
                btAnalisisdelClima.BackColor = Color.Indigo;
                btParcelas.BackColor = Color.Indigo;
                btCerrarSesion.BackColor = Color.Indigo;
                pictureBox4.BackColor = Color.MediumPurple;
                subPanelAlmacenes.BackColor = Color.MediumPurple;
                subPanelAgendayCalendario.BackColor = Color.MediumPurple;
                subPanelParcelas.BackColor = Color.MediumPurple;
                panel2.BackColor = Color.MediumPurple;
                ChildrenForm.BackColor = Color.BlueViolet;

                btVerAlmacenes.BackColor = Color.MediumPurple;
                btGestionarAlmacenes.BackColor = Color.MediumPurple;
                btTareasPendientes.BackColor = Color.MediumPurple;
                btRecordatorio.BackColor = Color.MediumPurple;
                btCalendario.BackColor = Color.MediumPurple;
                btVerParcelas.BackColor = Color.MediumPurple;
                btGestionarParcelas.BackColor = Color.MediumPurple;
            }
            else if (cmbxColor.Text == "Rosa")
            {

                panel1.BackColor = Color.MediumVioletRed;
                btAlmacenes.BackColor = Color.MediumVioletRed;
                btAgendayCalendario.BackColor = Color.MediumVioletRed;
                btAnalisisdelClima.BackColor = Color.MediumVioletRed;
                btParcelas.BackColor = Color.MediumVioletRed;
                btCerrarSesion.BackColor = Color.MediumVioletRed;
                pictureBox4.BackColor = Color.HotPink;
                subPanelAlmacenes.BackColor = Color.HotPink;
                subPanelAgendayCalendario.BackColor = Color.HotPink;
                subPanelParcelas.BackColor = Color.HotPink;
                panel2.BackColor = Color.HotPink;
                ChildrenForm.BackColor = Color.Plum;

                btVerAlmacenes.BackColor = Color.HotPink;
                btGestionarAlmacenes.BackColor = Color.HotPink;
                btTareasPendientes.BackColor = Color.HotPink;
                btRecordatorio.BackColor = Color.HotPink;
                btCalendario.BackColor = Color.HotPink;
                btVerParcelas.BackColor = Color.HotPink;
                btGestionarParcelas.BackColor = Color.HotPink;
            }
        }

        private void lbhora_Click(object sender, EventArgs e)
        {

        }
    }
}
