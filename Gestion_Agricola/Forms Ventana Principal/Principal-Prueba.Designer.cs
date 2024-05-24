namespace Gestion_Agricola
{
    partial class Principal_Prueba
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal_Prueba));
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            Bt_Nombre_de_Usuario = new Boton_personalizado();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btCerrarSesion = new Button();
            subPanelParcelas = new Panel();
            btGestionarParcelas = new Button();
            btVerParcelas = new Button();
            btParcelas = new Button();
            subPanelAnalisisDelClima = new Panel();
            btAnalisisClima30diass = new Button();
            btAnalisisClima15dias = new Button();
            btAnalisisClimaHoy = new Button();
            btAnalisisdelClima = new Button();
            subPanelAgendayCalendario = new Panel();
            btCalendario = new Button();
            btRecordatorio = new Button();
            btTareasPendientes = new Button();
            btAgendayCalendario = new Button();
            subPanelAlmacenes = new Panel();
            btGestionarAlmacenes = new Button();
            btVerAlmacenes = new Button();
            btAlmacenes = new Button();
            panel3 = new Panel();
            pictureBox4 = new PictureBox();
            ChildrenForm = new Panel();
            lbfecha = new Label();
            lbhora = new Label();
            tmrFecha_Hora = new System.Windows.Forms.Timer(components);
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            subPanelParcelas.SuspendLayout();
            subPanelAnalisisDelClima.SuspendLayout();
            subPanelAgendayCalendario.SuspendLayout();
            subPanelAlmacenes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ChildrenForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(Bt_Nombre_de_Usuario);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1392, 61);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(312, 4);
            pictureBox5.Margin = new Padding(4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(60, 50);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 3;
            pictureBox5.TabStop = false;
            // 
            // Bt_Nombre_de_Usuario
            // 
            Bt_Nombre_de_Usuario.BackColor = Color.PaleTurquoise;
            Bt_Nombre_de_Usuario.BackgroundColor = Color.PaleTurquoise;
            Bt_Nombre_de_Usuario.BorderColor = Color.PaleVioletRed;
            Bt_Nombre_de_Usuario.BorderRadius = 20;
            Bt_Nombre_de_Usuario.BorderSize = 0;
            Bt_Nombre_de_Usuario.FlatAppearance.BorderSize = 0;
            Bt_Nombre_de_Usuario.FlatStyle = FlatStyle.Flat;
            Bt_Nombre_de_Usuario.ForeColor = Color.White;
            Bt_Nombre_de_Usuario.Location = new Point(15, 4);
            Bt_Nombre_de_Usuario.Margin = new Padding(4);
            Bt_Nombre_de_Usuario.Name = "Bt_Nombre_de_Usuario";
            Bt_Nombre_de_Usuario.Size = new Size(290, 54);
            Bt_Nombre_de_Usuario.TabIndex = 3;
            Bt_Nombre_de_Usuario.TextColor = Color.White;
            Bt_Nombre_de_Usuario.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1232, 11);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 46);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1285, 11);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1335, 11);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(42, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.CadetBlue;
            panel2.Controls.Add(btCerrarSesion);
            panel2.Controls.Add(subPanelParcelas);
            panel2.Controls.Add(btParcelas);
            panel2.Controls.Add(subPanelAnalisisDelClima);
            panel2.Controls.Add(btAnalisisdelClima);
            panel2.Controls.Add(subPanelAgendayCalendario);
            panel2.Controls.Add(btAgendayCalendario);
            panel2.Controls.Add(subPanelAlmacenes);
            panel2.Controls.Add(btAlmacenes);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 61);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 828);
            panel2.TabIndex = 1;
            // 
            // btCerrarSesion
            // 
            btCerrarSesion.BackColor = Color.DarkCyan;
            btCerrarSesion.Dock = DockStyle.Top;
            btCerrarSesion.FlatAppearance.BorderSize = 0;
            btCerrarSesion.FlatStyle = FlatStyle.Flat;
            btCerrarSesion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btCerrarSesion.ForeColor = SystemColors.ButtonFace;
            btCerrarSesion.Image = (Image)resources.GetObject("btCerrarSesion.Image");
            btCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btCerrarSesion.Location = new Point(0, 790);
            btCerrarSesion.Margin = new Padding(4);
            btCerrarSesion.Name = "btCerrarSesion";
            btCerrarSesion.Padding = new Padding(12, 0, 0, 0);
            btCerrarSesion.Size = new Size(314, 50);
            btCerrarSesion.TabIndex = 8;
            btCerrarSesion.Text = "Cerrar sesion";
            btCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btCerrarSesion.UseVisualStyleBackColor = false;
            btCerrarSesion.Click += btCerrarSesion_Click;
            // 
            // subPanelParcelas
            // 
            subPanelParcelas.BackColor = Color.Silver;
            subPanelParcelas.Controls.Add(btGestionarParcelas);
            subPanelParcelas.Controls.Add(btVerParcelas);
            subPanelParcelas.Dock = DockStyle.Top;
            subPanelParcelas.Location = new Point(0, 705);
            subPanelParcelas.Margin = new Padding(4);
            subPanelParcelas.Name = "subPanelParcelas";
            subPanelParcelas.Size = new Size(314, 85);
            subPanelParcelas.TabIndex = 7;
            // 
            // btGestionarParcelas
            // 
            btGestionarParcelas.BackColor = Color.CadetBlue;
            btGestionarParcelas.Dock = DockStyle.Top;
            btGestionarParcelas.FlatAppearance.BorderSize = 0;
            btGestionarParcelas.FlatStyle = FlatStyle.Flat;
            btGestionarParcelas.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btGestionarParcelas.ForeColor = SystemColors.ButtonHighlight;
            btGestionarParcelas.Image = (Image)resources.GetObject("btGestionarParcelas.Image");
            btGestionarParcelas.ImageAlign = ContentAlignment.MiddleRight;
            btGestionarParcelas.Location = new Point(0, 44);
            btGestionarParcelas.Margin = new Padding(4);
            btGestionarParcelas.Name = "btGestionarParcelas";
            btGestionarParcelas.Padding = new Padding(38, 0, 0, 0);
            btGestionarParcelas.Size = new Size(314, 44);
            btGestionarParcelas.TabIndex = 2;
            btGestionarParcelas.Text = "Gestionar Parcelas";
            btGestionarParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btGestionarParcelas.UseVisualStyleBackColor = false;
            btGestionarParcelas.Click += btGestionarParcelas_Click;
            // 
            // btVerParcelas
            // 
            btVerParcelas.BackColor = Color.CadetBlue;
            btVerParcelas.Dock = DockStyle.Top;
            btVerParcelas.FlatAppearance.BorderSize = 0;
            btVerParcelas.FlatStyle = FlatStyle.Flat;
            btVerParcelas.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btVerParcelas.ForeColor = SystemColors.ButtonHighlight;
            btVerParcelas.Image = (Image)resources.GetObject("btVerParcelas.Image");
            btVerParcelas.ImageAlign = ContentAlignment.MiddleRight;
            btVerParcelas.Location = new Point(0, 0);
            btVerParcelas.Margin = new Padding(4);
            btVerParcelas.Name = "btVerParcelas";
            btVerParcelas.Padding = new Padding(38, 0, 0, 0);
            btVerParcelas.Size = new Size(314, 44);
            btVerParcelas.TabIndex = 1;
            btVerParcelas.Text = "Ver Parcelas";
            btVerParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btVerParcelas.UseVisualStyleBackColor = false;
            btVerParcelas.Click += btVerParcelas_Click;
            // 
            // btParcelas
            // 
            btParcelas.BackColor = Color.DarkCyan;
            btParcelas.Dock = DockStyle.Top;
            btParcelas.FlatAppearance.BorderSize = 0;
            btParcelas.FlatStyle = FlatStyle.Flat;
            btParcelas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btParcelas.ForeColor = SystemColors.ButtonFace;
            btParcelas.Image = (Image)resources.GetObject("btParcelas.Image");
            btParcelas.ImageAlign = ContentAlignment.MiddleRight;
            btParcelas.Location = new Point(0, 655);
            btParcelas.Margin = new Padding(4);
            btParcelas.Name = "btParcelas";
            btParcelas.Padding = new Padding(12, 0, 0, 0);
            btParcelas.Size = new Size(314, 50);
            btParcelas.TabIndex = 6;
            btParcelas.Text = "Parcelas";
            btParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btParcelas.UseVisualStyleBackColor = false;
            btParcelas.Click += btParcelas_Click;
            // 
            // subPanelAnalisisDelClima
            // 
            subPanelAnalisisDelClima.BackColor = Color.Silver;
            subPanelAnalisisDelClima.Controls.Add(btAnalisisClima30diass);
            subPanelAnalisisDelClima.Controls.Add(btAnalisisClima15dias);
            subPanelAnalisisDelClima.Controls.Add(btAnalisisClimaHoy);
            subPanelAnalisisDelClima.Dock = DockStyle.Top;
            subPanelAnalisisDelClima.Location = new Point(0, 523);
            subPanelAnalisisDelClima.Margin = new Padding(4);
            subPanelAnalisisDelClima.Name = "subPanelAnalisisDelClima";
            subPanelAnalisisDelClima.Size = new Size(314, 132);
            subPanelAnalisisDelClima.TabIndex = 5;
            // 
            // btAnalisisClima30diass
            // 
            btAnalisisClima30diass.BackColor = Color.CadetBlue;
            btAnalisisClima30diass.Dock = DockStyle.Top;
            btAnalisisClima30diass.FlatAppearance.BorderSize = 0;
            btAnalisisClima30diass.FlatStyle = FlatStyle.Flat;
            btAnalisisClima30diass.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btAnalisisClima30diass.ForeColor = SystemColors.ButtonHighlight;
            btAnalisisClima30diass.ImageAlign = ContentAlignment.MiddleRight;
            btAnalisisClima30diass.Location = new Point(0, 88);
            btAnalisisClima30diass.Margin = new Padding(4);
            btAnalisisClima30diass.Name = "btAnalisisClima30diass";
            btAnalisisClima30diass.Padding = new Padding(38, 0, 0, 0);
            btAnalisisClima30diass.Size = new Size(314, 44);
            btAnalisisClima30diass.TabIndex = 3;
            btAnalisisClima30diass.Text = "Analisis  en 30 dias";
            btAnalisisClima30diass.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisClima30diass.UseVisualStyleBackColor = false;
            btAnalisisClima30diass.Click += btAnalisisClima30diass_Click;
            // 
            // btAnalisisClima15dias
            // 
            btAnalisisClima15dias.BackColor = Color.CadetBlue;
            btAnalisisClima15dias.Dock = DockStyle.Top;
            btAnalisisClima15dias.FlatAppearance.BorderSize = 0;
            btAnalisisClima15dias.FlatStyle = FlatStyle.Flat;
            btAnalisisClima15dias.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btAnalisisClima15dias.ForeColor = SystemColors.ButtonHighlight;
            btAnalisisClima15dias.ImageAlign = ContentAlignment.MiddleRight;
            btAnalisisClima15dias.Location = new Point(0, 44);
            btAnalisisClima15dias.Margin = new Padding(4);
            btAnalisisClima15dias.Name = "btAnalisisClima15dias";
            btAnalisisClima15dias.Padding = new Padding(38, 0, 0, 0);
            btAnalisisClima15dias.Size = new Size(314, 44);
            btAnalisisClima15dias.TabIndex = 2;
            btAnalisisClima15dias.Text = "Analisis en 15 dias";
            btAnalisisClima15dias.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisClima15dias.UseVisualStyleBackColor = false;
            btAnalisisClima15dias.Click += btAnalisisClima15dias_Click;
            // 
            // btAnalisisClimaHoy
            // 
            btAnalisisClimaHoy.BackColor = Color.CadetBlue;
            btAnalisisClimaHoy.Dock = DockStyle.Top;
            btAnalisisClimaHoy.FlatAppearance.BorderSize = 0;
            btAnalisisClimaHoy.FlatStyle = FlatStyle.Flat;
            btAnalisisClimaHoy.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btAnalisisClimaHoy.ForeColor = SystemColors.ButtonHighlight;
            btAnalisisClimaHoy.Image = (Image)resources.GetObject("btAnalisisClimaHoy.Image");
            btAnalisisClimaHoy.ImageAlign = ContentAlignment.MiddleRight;
            btAnalisisClimaHoy.Location = new Point(0, 0);
            btAnalisisClimaHoy.Margin = new Padding(4);
            btAnalisisClimaHoy.Name = "btAnalisisClimaHoy";
            btAnalisisClimaHoy.Padding = new Padding(38, 0, 0, 0);
            btAnalisisClimaHoy.Size = new Size(314, 44);
            btAnalisisClimaHoy.TabIndex = 1;
            btAnalisisClimaHoy.Text = "Analisis de hoy";
            btAnalisisClimaHoy.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisClimaHoy.UseVisualStyleBackColor = false;
            btAnalisisClimaHoy.Click += btAnalisisClimaHoy_Click;
            // 
            // btAnalisisdelClima
            // 
            btAnalisisdelClima.BackColor = Color.DarkCyan;
            btAnalisisdelClima.Dock = DockStyle.Top;
            btAnalisisdelClima.FlatAppearance.BorderSize = 0;
            btAnalisisdelClima.FlatStyle = FlatStyle.Flat;
            btAnalisisdelClima.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btAnalisisdelClima.ForeColor = SystemColors.ButtonFace;
            btAnalisisdelClima.Image = (Image)resources.GetObject("btAnalisisdelClima.Image");
            btAnalisisdelClima.ImageAlign = ContentAlignment.MiddleRight;
            btAnalisisdelClima.Location = new Point(0, 473);
            btAnalisisdelClima.Margin = new Padding(4);
            btAnalisisdelClima.Name = "btAnalisisdelClima";
            btAnalisisdelClima.Padding = new Padding(12, 0, 0, 0);
            btAnalisisdelClima.Size = new Size(314, 50);
            btAnalisisdelClima.TabIndex = 4;
            btAnalisisdelClima.Text = "Analisis Del Clima";
            btAnalisisdelClima.TextAlign = ContentAlignment.MiddleLeft;
            btAnalisisdelClima.UseVisualStyleBackColor = false;
            btAnalisisdelClima.Click += btAnalisisdelClima_Click;
            // 
            // subPanelAgendayCalendario
            // 
            subPanelAgendayCalendario.BackColor = Color.Silver;
            subPanelAgendayCalendario.Controls.Add(btCalendario);
            subPanelAgendayCalendario.Controls.Add(btRecordatorio);
            subPanelAgendayCalendario.Controls.Add(btTareasPendientes);
            subPanelAgendayCalendario.Dock = DockStyle.Top;
            subPanelAgendayCalendario.Location = new Point(0, 341);
            subPanelAgendayCalendario.Margin = new Padding(4);
            subPanelAgendayCalendario.Name = "subPanelAgendayCalendario";
            subPanelAgendayCalendario.Size = new Size(314, 132);
            subPanelAgendayCalendario.TabIndex = 3;
            // 
            // btCalendario
            // 
            btCalendario.BackColor = Color.CadetBlue;
            btCalendario.Dock = DockStyle.Top;
            btCalendario.FlatAppearance.BorderSize = 0;
            btCalendario.FlatStyle = FlatStyle.Flat;
            btCalendario.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btCalendario.ForeColor = SystemColors.ButtonHighlight;
            btCalendario.Image = (Image)resources.GetObject("btCalendario.Image");
            btCalendario.ImageAlign = ContentAlignment.MiddleRight;
            btCalendario.Location = new Point(0, 88);
            btCalendario.Margin = new Padding(4);
            btCalendario.Name = "btCalendario";
            btCalendario.Padding = new Padding(38, 0, 0, 0);
            btCalendario.Size = new Size(314, 44);
            btCalendario.TabIndex = 3;
            btCalendario.Text = "Calendario";
            btCalendario.TextAlign = ContentAlignment.MiddleLeft;
            btCalendario.UseVisualStyleBackColor = false;
            btCalendario.Click += btCalendario_Click;
            // 
            // btRecordatorio
            // 
            btRecordatorio.BackColor = Color.CadetBlue;
            btRecordatorio.Dock = DockStyle.Top;
            btRecordatorio.FlatAppearance.BorderSize = 0;
            btRecordatorio.FlatStyle = FlatStyle.Flat;
            btRecordatorio.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btRecordatorio.ForeColor = SystemColors.ButtonHighlight;
            btRecordatorio.Image = (Image)resources.GetObject("btRecordatorio.Image");
            btRecordatorio.ImageAlign = ContentAlignment.MiddleRight;
            btRecordatorio.Location = new Point(0, 44);
            btRecordatorio.Margin = new Padding(4);
            btRecordatorio.Name = "btRecordatorio";
            btRecordatorio.Padding = new Padding(38, 0, 0, 0);
            btRecordatorio.Size = new Size(314, 44);
            btRecordatorio.TabIndex = 2;
            btRecordatorio.Text = "Recordatorio";
            btRecordatorio.TextAlign = ContentAlignment.MiddleLeft;
            btRecordatorio.UseVisualStyleBackColor = false;
            btRecordatorio.Click += btRecordatorio_Click;
            // 
            // btTareasPendientes
            // 
            btTareasPendientes.BackColor = Color.CadetBlue;
            btTareasPendientes.Dock = DockStyle.Top;
            btTareasPendientes.FlatAppearance.BorderSize = 0;
            btTareasPendientes.FlatStyle = FlatStyle.Flat;
            btTareasPendientes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btTareasPendientes.ForeColor = SystemColors.ButtonHighlight;
            btTareasPendientes.Image = (Image)resources.GetObject("btTareasPendientes.Image");
            btTareasPendientes.ImageAlign = ContentAlignment.MiddleRight;
            btTareasPendientes.Location = new Point(0, 0);
            btTareasPendientes.Margin = new Padding(4);
            btTareasPendientes.Name = "btTareasPendientes";
            btTareasPendientes.Padding = new Padding(38, 0, 0, 0);
            btTareasPendientes.Size = new Size(314, 44);
            btTareasPendientes.TabIndex = 1;
            btTareasPendientes.Text = "Tareas Pendientes";
            btTareasPendientes.TextAlign = ContentAlignment.MiddleLeft;
            btTareasPendientes.UseVisualStyleBackColor = false;
            btTareasPendientes.Click += btTareasPendientes_Click;
            // 
            // btAgendayCalendario
            // 
            btAgendayCalendario.BackColor = Color.DarkCyan;
            btAgendayCalendario.Dock = DockStyle.Top;
            btAgendayCalendario.FlatAppearance.BorderSize = 0;
            btAgendayCalendario.FlatStyle = FlatStyle.Flat;
            btAgendayCalendario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btAgendayCalendario.ForeColor = SystemColors.ButtonFace;
            btAgendayCalendario.Image = (Image)resources.GetObject("btAgendayCalendario.Image");
            btAgendayCalendario.ImageAlign = ContentAlignment.MiddleRight;
            btAgendayCalendario.Location = new Point(0, 291);
            btAgendayCalendario.Margin = new Padding(4);
            btAgendayCalendario.Name = "btAgendayCalendario";
            btAgendayCalendario.Size = new Size(314, 50);
            btAgendayCalendario.TabIndex = 2;
            btAgendayCalendario.Text = "Agenda y Calendario";
            btAgendayCalendario.TextAlign = ContentAlignment.MiddleLeft;
            btAgendayCalendario.UseVisualStyleBackColor = false;
            btAgendayCalendario.Click += btAgendayCalendario_Click;
            // 
            // subPanelAlmacenes
            // 
            subPanelAlmacenes.BackColor = Color.Silver;
            subPanelAlmacenes.Controls.Add(btGestionarAlmacenes);
            subPanelAlmacenes.Controls.Add(btVerAlmacenes);
            subPanelAlmacenes.Dock = DockStyle.Top;
            subPanelAlmacenes.Location = new Point(0, 206);
            subPanelAlmacenes.Margin = new Padding(4);
            subPanelAlmacenes.Name = "subPanelAlmacenes";
            subPanelAlmacenes.Size = new Size(314, 85);
            subPanelAlmacenes.TabIndex = 1;
            // 
            // btGestionarAlmacenes
            // 
            btGestionarAlmacenes.BackColor = Color.CadetBlue;
            btGestionarAlmacenes.Dock = DockStyle.Top;
            btGestionarAlmacenes.FlatAppearance.BorderSize = 0;
            btGestionarAlmacenes.FlatStyle = FlatStyle.Flat;
            btGestionarAlmacenes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btGestionarAlmacenes.ForeColor = SystemColors.ButtonHighlight;
            btGestionarAlmacenes.Image = (Image)resources.GetObject("btGestionarAlmacenes.Image");
            btGestionarAlmacenes.ImageAlign = ContentAlignment.MiddleRight;
            btGestionarAlmacenes.Location = new Point(0, 44);
            btGestionarAlmacenes.Margin = new Padding(4);
            btGestionarAlmacenes.Name = "btGestionarAlmacenes";
            btGestionarAlmacenes.Padding = new Padding(38, 0, 0, 0);
            btGestionarAlmacenes.Size = new Size(314, 44);
            btGestionarAlmacenes.TabIndex = 2;
            btGestionarAlmacenes.Text = "Gestionar Almacenes";
            btGestionarAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btGestionarAlmacenes.UseVisualStyleBackColor = false;
            btGestionarAlmacenes.Click += btGestionarAlmacenes_Click;
            // 
            // btVerAlmacenes
            // 
            btVerAlmacenes.BackColor = Color.CadetBlue;
            btVerAlmacenes.Dock = DockStyle.Top;
            btVerAlmacenes.FlatAppearance.BorderSize = 0;
            btVerAlmacenes.FlatStyle = FlatStyle.Flat;
            btVerAlmacenes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btVerAlmacenes.ForeColor = SystemColors.ButtonHighlight;
            btVerAlmacenes.Image = (Image)resources.GetObject("btVerAlmacenes.Image");
            btVerAlmacenes.ImageAlign = ContentAlignment.MiddleRight;
            btVerAlmacenes.Location = new Point(0, 0);
            btVerAlmacenes.Margin = new Padding(4);
            btVerAlmacenes.Name = "btVerAlmacenes";
            btVerAlmacenes.Padding = new Padding(38, 0, 0, 0);
            btVerAlmacenes.Size = new Size(314, 44);
            btVerAlmacenes.TabIndex = 1;
            btVerAlmacenes.Text = "Ver Almacenes";
            btVerAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btVerAlmacenes.UseVisualStyleBackColor = false;
            btVerAlmacenes.Click += btVerAlmacenes_Click;
            // 
            // btAlmacenes
            // 
            btAlmacenes.BackColor = Color.DarkCyan;
            btAlmacenes.Dock = DockStyle.Top;
            btAlmacenes.FlatAppearance.BorderSize = 0;
            btAlmacenes.FlatStyle = FlatStyle.Flat;
            btAlmacenes.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btAlmacenes.ForeColor = SystemColors.ButtonFace;
            btAlmacenes.Image = (Image)resources.GetObject("btAlmacenes.Image");
            btAlmacenes.ImageAlign = ContentAlignment.MiddleRight;
            btAlmacenes.Location = new Point(0, 156);
            btAlmacenes.Margin = new Padding(4);
            btAlmacenes.Name = "btAlmacenes";
            btAlmacenes.Padding = new Padding(12, 0, 0, 0);
            btAlmacenes.Size = new Size(314, 50);
            btAlmacenes.TabIndex = 1;
            btAlmacenes.Text = "Almacenes";
            btAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btAlmacenes.UseVisualStyleBackColor = false;
            btAlmacenes.Click += btAlmacenes_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.CadetBlue;
            panel3.Controls.Add(pictureBox4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 156);
            panel3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(340, 156);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // ChildrenForm
            // 
            ChildrenForm.BackColor = Color.DarkSlateGray;
            ChildrenForm.Controls.Add(pictureBox6);
            ChildrenForm.Controls.Add(lbfecha);
            ChildrenForm.Controls.Add(lbhora);
            ChildrenForm.Dock = DockStyle.Fill;
            ChildrenForm.Location = new Point(340, 61);
            ChildrenForm.Margin = new Padding(4);
            ChildrenForm.Name = "ChildrenForm";
            ChildrenForm.Size = new Size(1052, 828);
            ChildrenForm.TabIndex = 2;
            ChildrenForm.Paint += ChildrenForm_Paint;
            // 
            // lbfecha
            // 
            lbfecha.AutoSize = true;
            lbfecha.BackColor = Color.Transparent;
            lbfecha.Dock = DockStyle.Fill;
            lbfecha.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbfecha.ForeColor = SystemColors.Control;
            lbfecha.Location = new Point(0, 0);
            lbfecha.Margin = new Padding(4, 0, 4, 0);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(167, 55);
            lbfecha.TabIndex = 2;
            lbfecha.Text = "label3";
            // 
            // lbhora
            // 
            lbhora.AutoSize = true;
            lbhora.BackColor = Color.Transparent;
            lbhora.Dock = DockStyle.Fill;
            lbhora.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbhora.ForeColor = SystemColors.Control;
            lbhora.Location = new Point(0, 0);
            lbhora.Margin = new Padding(4, 0, 4, 0);
            lbhora.Name = "lbhora";
            lbhora.Size = new Size(196, 83);
            lbhora.TabIndex = 0;
            lbhora.Text = "hora";
            // 
            // tmrFecha_Hora
            // 
            tmrFecha_Hora.Enabled = true;
            tmrFecha_Hora.Tick += timer1_Tick;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Azure;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(756, 560);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(74, 72);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 3;
            pictureBox6.TabStop = false;
            // 
            // Principal_Prueba
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1392, 889);
            Controls.Add(ChildrenForm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Principal_Prueba";
            Text = "Principal_Prueba";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            subPanelParcelas.ResumeLayout(false);
            subPanelAnalisisDelClima.ResumeLayout(false);
            subPanelAgendayCalendario.ResumeLayout(false);
            subPanelAlmacenes.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ChildrenForm.ResumeLayout(false);
            ChildrenForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btCerrarSesion;
        private Panel subPanelParcelas;
        private Button btGestionarParcelas;
        private Button btVerParcelas;
        private Button btParcelas;
        private Panel subPanelAnalisisDelClima;
        private Button btAnalisisClima30diass;
        private Button btAnalisisClima15dias;
        private Button btAnalisisClimaHoy;
        private Button btAnalisisdelClima;
        private Panel subPanelAgendayCalendario;
        private Button btCalendario;
        private Button btRecordatorio;
        private Button btTareasPendientes;
        private Button btAgendayCalendario;
        private Panel subPanelAlmacenes;
        private Button btGestionarAlmacenes;
        private Button btVerAlmacenes;
        private Button btAlmacenes;
        private Panel panel3;
        private PictureBox pictureBox4;
        private Panel ChildrenForm;
        private Label lbfecha;
        private Label lbhora;
        private System.Windows.Forms.Timer tmrFecha_Hora;
        private Boton_personalizado Bt_Nombre_de_Usuario;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}