using MaterialSkin;
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
    public partial class principal : MaterialSkin.Controls.MaterialForm
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
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btGestionarAlmacenes_Click(object sender, EventArgs e)
        {
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
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btRecordatorio_Click(object sender, EventArgs e)
        {
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btCalendario_Click(object sender, EventArgs e)
        {
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
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btAnalisisClima15dias_Click(object sender, EventArgs e)
        {
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btAnalisisClima30diass_Click(object sender, EventArgs e)
        {
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
            // Lineas de codigo
            //
            //
            ocultar();
        }

        private void btGestionarParcelas_Click(object sender, EventArgs e)
        {
            // Lineas de codigo
            //
            //
            ocultar();
        }
    }
}
