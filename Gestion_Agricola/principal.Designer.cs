namespace Gestion_Agricola
{
    partial class principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btAlmacenes = new Button();
            panel3 = new Panel();
            btVerAlmacenes = new Button();
            btGestionarAlmacenes = new Button();
            btAgendayCalendario = new Button();
            panel4 = new Panel();
            btRecordatorio = new Button();
            btTareasPendientes = new Button();
            btCalendario = new Button();
            btAnalisisdelClima = new Button();
            panel5 = new Panel();
            btAnalisisClima30diass = new Button();
            btAnalisisClima15dias = new Button();
            btAnalisisClimaHoy = new Button();
            btParcelas = new Button();
            panel6 = new Panel();
            btGestionarParcelas = new Button();
            btVerParcelas = new Button();
            btCerrarSesion = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btCerrarSesion);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btParcelas);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btAnalisisdelClima);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btAgendayCalendario);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btAlmacenes);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 992);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 125);
            panel2.TabIndex = 1;
            // 
            // btAlmacenes
            // 
            btAlmacenes.BackColor = Color.FromArgb(192, 255, 192);
            btAlmacenes.Dock = DockStyle.Top;
            btAlmacenes.FlatAppearance.BorderSize = 0;
            btAlmacenes.FlatStyle = FlatStyle.Flat;
            btAlmacenes.Location = new Point(0, 125);
            btAlmacenes.Name = "btAlmacenes";
            btAlmacenes.Padding = new Padding(10, 0, 0, 0);
            btAlmacenes.Size = new Size(250, 40);
            btAlmacenes.TabIndex = 1;
            btAlmacenes.Text = "Almacenes";
            btAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btAlmacenes.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(btGestionarAlmacenes);
            panel3.Controls.Add(btVerAlmacenes);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 80);
            panel3.TabIndex = 1;
            // 
            // btVerAlmacenes
            // 
            btVerAlmacenes.BackColor = Color.Green;
            btVerAlmacenes.Dock = DockStyle.Top;
            btVerAlmacenes.FlatAppearance.BorderSize = 0;
            btVerAlmacenes.FlatStyle = FlatStyle.Flat;
            btVerAlmacenes.ForeColor = SystemColors.ButtonHighlight;
            btVerAlmacenes.Location = new Point(0, 0);
            btVerAlmacenes.Name = "btVerAlmacenes";
            btVerAlmacenes.Padding = new Padding(35, 0, 0, 0);
            btVerAlmacenes.Size = new Size(250, 35);
            btVerAlmacenes.TabIndex = 1;
            btVerAlmacenes.Text = "Ver Almacenes";
            btVerAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btVerAlmacenes.UseVisualStyleBackColor = false;
            // 
            // btGestionarAlmacenes
            // 
            btGestionarAlmacenes.BackColor = Color.Green;
            btGestionarAlmacenes.Dock = DockStyle.Top;
            btGestionarAlmacenes.FlatAppearance.BorderSize = 0;
            btGestionarAlmacenes.FlatStyle = FlatStyle.Flat;
            btGestionarAlmacenes.ForeColor = SystemColors.ButtonHighlight;
            btGestionarAlmacenes.Location = new Point(0, 35);
            btGestionarAlmacenes.Name = "btGestionarAlmacenes";
            btGestionarAlmacenes.Padding = new Padding(35, 0, 0, 0);
            btGestionarAlmacenes.Size = new Size(250, 35);
            btGestionarAlmacenes.TabIndex = 2;
            btGestionarAlmacenes.Text = "Gestionar Almacenes";
            btGestionarAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btGestionarAlmacenes.UseVisualStyleBackColor = false;
            // 
            // btAgendayCalendario
            // 
            btAgendayCalendario.BackColor = Color.FromArgb(192, 255, 192);
            btAgendayCalendario.Dock = DockStyle.Top;
            btAgendayCalendario.FlatAppearance.BorderSize = 0;
            btAgendayCalendario.FlatStyle = FlatStyle.Flat;
            btAgendayCalendario.Location = new Point(0, 245);
            btAgendayCalendario.Name = "btAgendayCalendario";
            btAgendayCalendario.Padding = new Padding(10, 0, 0, 0);
            btAgendayCalendario.Size = new Size(250, 40);
            btAgendayCalendario.TabIndex = 2;
            btAgendayCalendario.Text = "Agenda y Calendario";
            btAgendayCalendario.TextAlign = ContentAlignment.MiddleLeft;
            btAgendayCalendario.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(btCalendario);
            panel4.Controls.Add(btRecordatorio);
            panel4.Controls.Add(btTareasPendientes);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 285);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 112);
            panel4.TabIndex = 3;
            // 
            // btRecordatorio
            // 
            btRecordatorio.BackColor = Color.Green;
            btRecordatorio.Dock = DockStyle.Top;
            btRecordatorio.FlatAppearance.BorderSize = 0;
            btRecordatorio.FlatStyle = FlatStyle.Flat;
            btRecordatorio.ForeColor = SystemColors.ButtonHighlight;
            btRecordatorio.Location = new Point(0, 35);
            btRecordatorio.Name = "btRecordatorio";
            btRecordatorio.Padding = new Padding(35, 0, 0, 0);
            btRecordatorio.Size = new Size(250, 35);
            btRecordatorio.TabIndex = 2;
            btRecordatorio.Text = "Recordatorio";
            btRecordatorio.TextAlign = ContentAlignment.MiddleLeft;
            btRecordatorio.UseVisualStyleBackColor = false;
            // 
            // btTareasPendientes
            // 
            btTareasPendientes.BackColor = Color.Green;
            btTareasPendientes.Dock = DockStyle.Top;
            btTareasPendientes.FlatAppearance.BorderSize = 0;
            btTareasPendientes.FlatStyle = FlatStyle.Flat;
            btTareasPendientes.ForeColor = SystemColors.ButtonHighlight;
            btTareasPendientes.Location = new Point(0, 0);
            btTareasPendientes.Name = "btTareasPendientes";
            btTareasPendientes.Padding = new Padding(35, 0, 0, 0);
            btTareasPendientes.Size = new Size(250, 35);
            btTareasPendientes.TabIndex = 1;
            btTareasPendientes.Text = "Tareas Pendientes";
            btTareasPendientes.TextAlign = ContentAlignment.MiddleLeft;
            btTareasPendientes.UseVisualStyleBackColor = false;
            // 
            // btCalendario
            // 
            btCalendario.BackColor = Color.Green;
            btCalendario.Dock = DockStyle.Top;
            btCalendario.FlatAppearance.BorderSize = 0;
            btCalendario.FlatStyle = FlatStyle.Flat;
            btCalendario.ForeColor = SystemColors.ButtonHighlight;
            btCalendario.Location = new Point(0, 70);
            btCalendario.Name = "btCalendario";
            btCalendario.Padding = new Padding(35, 0, 0, 0);
            btCalendario.Size = new Size(250, 35);
            btCalendario.TabIndex = 3;
            btCalendario.Text = "Calendario";
            btCalendario.TextAlign = ContentAlignment.MiddleLeft;
            btCalendario.UseVisualStyleBackColor = false;
            // 
            // btAnalisisdelClima
            // 
            btAnalisisdelClima.BackColor = Color.FromArgb(192, 255, 192);
            btAnalisisdelClima.Dock = DockStyle.Top;
            btAnalisisdelClima.FlatAppearance.BorderSize = 0;
            btAnalisisdelClima.FlatStyle = FlatStyle.Flat;
            btAnalisisdelClima.Location = new Point(0, 397);
            btAnalisisdelClima.Name = "btAnalisisdelClima";
            btAnalisisdelClima.Padding = new Padding(10, 0, 0, 0);
            btAnalisisdelClima.Size = new Size(250, 40);
            btAnalisisdelClima.TabIndex = 4;
            btAnalisisdelClima.Text = "Analisis Del Clima";
            btAnalisisdelClima.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisdelClima.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Controls.Add(btAnalisisClima30diass);
            panel5.Controls.Add(btAnalisisClima15dias);
            panel5.Controls.Add(btAnalisisClimaHoy);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 437);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 112);
            panel5.TabIndex = 5;
            // 
            // btAnalisisClima30diass
            // 
            btAnalisisClima30diass.BackColor = Color.Green;
            btAnalisisClima30diass.Dock = DockStyle.Top;
            btAnalisisClima30diass.FlatAppearance.BorderSize = 0;
            btAnalisisClima30diass.FlatStyle = FlatStyle.Flat;
            btAnalisisClima30diass.ForeColor = SystemColors.ButtonHighlight;
            btAnalisisClima30diass.Location = new Point(0, 70);
            btAnalisisClima30diass.Name = "btAnalisisClima30diass";
            btAnalisisClima30diass.Padding = new Padding(35, 0, 0, 0);
            btAnalisisClima30diass.Size = new Size(250, 35);
            btAnalisisClima30diass.TabIndex = 3;
            btAnalisisClima30diass.Text = "Analisis  en 30 dias";
            btAnalisisClima30diass.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisClima30diass.UseVisualStyleBackColor = false;
            // 
            // btAnalisisClima15dias
            // 
            btAnalisisClima15dias.BackColor = Color.Green;
            btAnalisisClima15dias.Dock = DockStyle.Top;
            btAnalisisClima15dias.FlatAppearance.BorderSize = 0;
            btAnalisisClima15dias.FlatStyle = FlatStyle.Flat;
            btAnalisisClima15dias.ForeColor = SystemColors.ButtonHighlight;
            btAnalisisClima15dias.Location = new Point(0, 35);
            btAnalisisClima15dias.Name = "btAnalisisClima15dias";
            btAnalisisClima15dias.Padding = new Padding(35, 0, 0, 0);
            btAnalisisClima15dias.Size = new Size(250, 35);
            btAnalisisClima15dias.TabIndex = 2;
            btAnalisisClima15dias.Text = "Analisis en 15 dias";
            btAnalisisClima15dias.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisClima15dias.UseVisualStyleBackColor = false;
            // 
            // btAnalisisClimaHoy
            // 
            btAnalisisClimaHoy.BackColor = Color.Green;
            btAnalisisClimaHoy.Dock = DockStyle.Top;
            btAnalisisClimaHoy.FlatAppearance.BorderSize = 0;
            btAnalisisClimaHoy.FlatStyle = FlatStyle.Flat;
            btAnalisisClimaHoy.ForeColor = SystemColors.ButtonHighlight;
            btAnalisisClimaHoy.Location = new Point(0, 0);
            btAnalisisClimaHoy.Name = "btAnalisisClimaHoy";
            btAnalisisClimaHoy.Padding = new Padding(35, 0, 0, 0);
            btAnalisisClimaHoy.Size = new Size(250, 35);
            btAnalisisClimaHoy.TabIndex = 1;
            btAnalisisClimaHoy.Text = "Analisis de hoy";
            btAnalisisClimaHoy.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisClimaHoy.UseVisualStyleBackColor = false;
            // 
            // btParcelas
            // 
            btParcelas.BackColor = Color.FromArgb(192, 255, 192);
            btParcelas.Dock = DockStyle.Top;
            btParcelas.FlatAppearance.BorderSize = 0;
            btParcelas.FlatStyle = FlatStyle.Flat;
            btParcelas.Location = new Point(0, 549);
            btParcelas.Name = "btParcelas";
            btParcelas.Padding = new Padding(10, 0, 0, 0);
            btParcelas.Size = new Size(250, 40);
            btParcelas.TabIndex = 6;
            btParcelas.Text = "Parcelas";
            btParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btParcelas.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Silver;
            panel6.Controls.Add(btGestionarParcelas);
            panel6.Controls.Add(btVerParcelas);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 589);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 74);
            panel6.TabIndex = 7;
            // 
            // btGestionarParcelas
            // 
            btGestionarParcelas.BackColor = Color.Green;
            btGestionarParcelas.Dock = DockStyle.Top;
            btGestionarParcelas.FlatAppearance.BorderSize = 0;
            btGestionarParcelas.FlatStyle = FlatStyle.Flat;
            btGestionarParcelas.ForeColor = SystemColors.ButtonHighlight;
            btGestionarParcelas.Location = new Point(0, 35);
            btGestionarParcelas.Name = "btGestionarParcelas";
            btGestionarParcelas.Padding = new Padding(35, 0, 0, 0);
            btGestionarParcelas.Size = new Size(250, 35);
            btGestionarParcelas.TabIndex = 2;
            btGestionarParcelas.Text = "Gestionar Parcelas";
            btGestionarParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btGestionarParcelas.UseVisualStyleBackColor = false;
            // 
            // btVerParcelas
            // 
            btVerParcelas.BackColor = Color.Green;
            btVerParcelas.Dock = DockStyle.Top;
            btVerParcelas.FlatAppearance.BorderSize = 0;
            btVerParcelas.FlatStyle = FlatStyle.Flat;
            btVerParcelas.ForeColor = SystemColors.ButtonHighlight;
            btVerParcelas.Location = new Point(0, 0);
            btVerParcelas.Name = "btVerParcelas";
            btVerParcelas.Padding = new Padding(35, 0, 0, 0);
            btVerParcelas.Size = new Size(250, 35);
            btVerParcelas.TabIndex = 1;
            btVerParcelas.Text = "Ver Parcelas";
            btVerParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btVerParcelas.UseVisualStyleBackColor = false;
            // 
            // btCerrarSesion
            // 
            btCerrarSesion.BackColor = Color.FromArgb(192, 255, 192);
            btCerrarSesion.Dock = DockStyle.Top;
            btCerrarSesion.FlatAppearance.BorderSize = 0;
            btCerrarSesion.FlatStyle = FlatStyle.Flat;
            btCerrarSesion.Location = new Point(0, 663);
            btCerrarSesion.Name = "btCerrarSesion";
            btCerrarSesion.Padding = new Padding(10, 0, 0, 0);
            btCerrarSesion.Size = new Size(250, 40);
            btCerrarSesion.TabIndex = 8;
            btCerrarSesion.Text = "Cerrar sesion";
            btCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 992);
            Controls.Add(panel1);
            Name = "principal";
            Text = "principal";
            Load += principal_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btVerAlmacenes;
        private Button btAlmacenes;
        private Button btGestionarAlmacenes;
        private Button btCerrarSesion;
        private Panel panel6;
        private Button btGestionarParcelas;
        private Button btVerParcelas;
        private Button btParcelas;
        private Panel panel5;
        private Button btAnalisisClima30diass;
        private Button btAnalisisClima15dias;
        private Button btAnalisisClimaHoy;
        private Button btAnalisisdelClima;
        private Panel panel4;
        private Button btCalendario;
        private Button btRecordatorio;
        private Button btTareasPendientes;
        private Button btAgendayCalendario;
    }
}