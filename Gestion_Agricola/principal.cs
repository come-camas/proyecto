
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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
            CustomizarDiseño();
        }

        private void principal_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        #region SubMenu

        public void CustomizarDiseño()
        {
            subPanelAlmacenes.Visible = false;
            subPanelAgendayCalendario.Visible = false;
            subPanelAnalisisDelClima.Visible = false;
            subPanelParcelas.Visible = false;
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

        private void btVerAlmacenes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VerAlmacenes());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btGestionarAlmacenes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Gestionar_Almacenes());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btAgendayCalendario_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(subPanelAgendayCalendario);
        }

        private void btTareasPendientes_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Tareas_Pendientes());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btRecordatorio_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Recordatorio());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btCalendario_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Calendario());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btAnalisisdelClima_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(subPanelAnalisisDelClima);

        }

        private void btAnalisisClimaHoy_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Analisis_Hoy());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btAnalisisClima15dias_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Analisis_15Dias());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btAnalisisClima30diass_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Analisis_30Dias());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btParcelas_Click(object sender, EventArgs e)
        {

            MostrarSubmenu(subPanelParcelas);
        }

        private void btVerParcelas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Ver_Parcelas());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btGestionarParcelas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Gestionar_Parcelas());
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            ocultar();
        }
        #endregion subMenu


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

        private void ChildrenForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
