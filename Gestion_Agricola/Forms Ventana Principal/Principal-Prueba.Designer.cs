﻿namespace Gestion_Agricola
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
            cmbxColor = new ComboBox();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            subPanelParcelas.SuspendLayout();
            subPanelAgendayCalendario.SuspendLayout();
            subPanelAlmacenes.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ChildrenForm.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumVioletRed;
            panel1.Controls.Add(cmbxColor);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(Bt_Nombre_de_Usuario);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 49);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint_1;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // cmbxColor
            // 
            cmbxColor.FormattingEnabled = true;
            cmbxColor.Items.AddRange(new object[] { "Oscuro", "Verde", "Morado", "Rosa" });
            cmbxColor.Location = new Point(304, 11);
            cmbxColor.Name = "cmbxColor";
            cmbxColor.Size = new Size(151, 28);
            cmbxColor.TabIndex = 3;
            cmbxColor.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(250, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(48, 40);
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
            Bt_Nombre_de_Usuario.Location = new Point(12, 3);
            Bt_Nombre_de_Usuario.Name = "Bt_Nombre_de_Usuario";
            Bt_Nombre_de_Usuario.Size = new Size(232, 43);
            Bt_Nombre_de_Usuario.TabIndex = 3;
            Bt_Nombre_de_Usuario.TextColor = Color.White;
            Bt_Nombre_de_Usuario.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.IndianRed;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(986, 9);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 37);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.IndianRed;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1028, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1068, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.HotPink;
            panel2.Controls.Add(btCerrarSesion);
            panel2.Controls.Add(subPanelParcelas);
            panel2.Controls.Add(btParcelas);
            panel2.Controls.Add(btAnalisisdelClima);
            panel2.Controls.Add(subPanelAgendayCalendario);
            panel2.Controls.Add(btAgendayCalendario);
            panel2.Controls.Add(subPanelAlmacenes);
            panel2.Controls.Add(btAlmacenes);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 662);
            panel2.TabIndex = 1;
            // 
            // btCerrarSesion
            // 
            btCerrarSesion.BackColor = Color.MediumVioletRed;
            btCerrarSesion.Dock = DockStyle.Top;
            btCerrarSesion.FlatAppearance.BorderSize = 0;
            btCerrarSesion.FlatStyle = FlatStyle.Flat;
            btCerrarSesion.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btCerrarSesion.ForeColor = SystemColors.ButtonFace;
            btCerrarSesion.Image = (Image)resources.GetObject("btCerrarSesion.Image");
            btCerrarSesion.ImageAlign = ContentAlignment.MiddleRight;
            btCerrarSesion.Location = new Point(0, 527);
            btCerrarSesion.Name = "btCerrarSesion";
            btCerrarSesion.Padding = new Padding(10, 0, 0, 0);
            btCerrarSesion.Size = new Size(272, 40);
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
            subPanelParcelas.Location = new Point(0, 459);
            subPanelParcelas.Name = "subPanelParcelas";
            subPanelParcelas.Size = new Size(272, 68);
            subPanelParcelas.TabIndex = 7;
            // 
            // btGestionarParcelas
            // 
            btGestionarParcelas.BackColor = Color.HotPink;
            btGestionarParcelas.Dock = DockStyle.Top;
            btGestionarParcelas.FlatAppearance.BorderSize = 0;
            btGestionarParcelas.FlatStyle = FlatStyle.Flat;
            btGestionarParcelas.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btGestionarParcelas.ForeColor = SystemColors.ButtonHighlight;
            btGestionarParcelas.Image = (Image)resources.GetObject("btGestionarParcelas.Image");
            btGestionarParcelas.ImageAlign = ContentAlignment.MiddleRight;
            btGestionarParcelas.Location = new Point(0, 35);
            btGestionarParcelas.Name = "btGestionarParcelas";
            btGestionarParcelas.Padding = new Padding(30, 0, 0, 0);
            btGestionarParcelas.Size = new Size(272, 35);
            btGestionarParcelas.TabIndex = 2;
            btGestionarParcelas.Text = "Gestionar Parcelas";
            btGestionarParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btGestionarParcelas.UseVisualStyleBackColor = false;
            btGestionarParcelas.Click += btGestionarParcelas_Click;
            // 
            // btVerParcelas
            // 
            btVerParcelas.BackColor = Color.HotPink;
            btVerParcelas.Dock = DockStyle.Top;
            btVerParcelas.FlatAppearance.BorderSize = 0;
            btVerParcelas.FlatStyle = FlatStyle.Flat;
            btVerParcelas.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btVerParcelas.ForeColor = SystemColors.ButtonHighlight;
            btVerParcelas.Image = (Image)resources.GetObject("btVerParcelas.Image");
            btVerParcelas.ImageAlign = ContentAlignment.MiddleRight;
            btVerParcelas.Location = new Point(0, 0);
            btVerParcelas.Name = "btVerParcelas";
            btVerParcelas.Padding = new Padding(30, 0, 0, 0);
            btVerParcelas.Size = new Size(272, 35);
            btVerParcelas.TabIndex = 1;
            btVerParcelas.Text = "Ver Parcelas";
            btVerParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btVerParcelas.UseVisualStyleBackColor = false;
            btVerParcelas.Click += btVerParcelas_Click;
            // 
            // btParcelas
            // 
            btParcelas.BackColor = Color.MediumVioletRed;
            btParcelas.Dock = DockStyle.Top;
            btParcelas.FlatAppearance.BorderSize = 0;
            btParcelas.FlatStyle = FlatStyle.Flat;
            btParcelas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btParcelas.ForeColor = SystemColors.ButtonFace;
            btParcelas.Image = (Image)resources.GetObject("btParcelas.Image");
            btParcelas.ImageAlign = ContentAlignment.MiddleRight;
            btParcelas.Location = new Point(0, 419);
            btParcelas.Name = "btParcelas";
            btParcelas.Padding = new Padding(10, 0, 0, 0);
            btParcelas.Size = new Size(272, 40);
            btParcelas.TabIndex = 6;
            btParcelas.Text = "Parcelas";
            btParcelas.TextAlign = ContentAlignment.MiddleLeft;
            btParcelas.UseVisualStyleBackColor = false;
            btParcelas.Click += btParcelas_Click;
            // 
            // btAnalisisdelClima
            // 
            btAnalisisdelClima.BackColor = Color.MediumVioletRed;
            btAnalisisdelClima.Dock = DockStyle.Top;
            btAnalisisdelClima.FlatAppearance.BorderSize = 0;
            btAnalisisdelClima.FlatStyle = FlatStyle.Flat;
            btAnalisisdelClima.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btAnalisisdelClima.ForeColor = SystemColors.ButtonFace;
            btAnalisisdelClima.Image = (Image)resources.GetObject("btAnalisisdelClima.Image");
            btAnalisisdelClima.ImageAlign = ContentAlignment.MiddleRight;
            btAnalisisdelClima.Location = new Point(0, 379);
            btAnalisisdelClima.Name = "btAnalisisdelClima";
            btAnalisisdelClima.Padding = new Padding(10, 0, 0, 0);
            btAnalisisdelClima.Size = new Size(272, 40);
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
            subPanelAgendayCalendario.Location = new Point(0, 273);
            subPanelAgendayCalendario.Name = "subPanelAgendayCalendario";
            subPanelAgendayCalendario.Size = new Size(272, 106);
            subPanelAgendayCalendario.TabIndex = 3;
            // 
            // btCalendario
            // 
            btCalendario.BackColor = Color.HotPink;
            btCalendario.Dock = DockStyle.Top;
            btCalendario.FlatAppearance.BorderSize = 0;
            btCalendario.FlatStyle = FlatStyle.Flat;
            btCalendario.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btCalendario.ForeColor = SystemColors.ButtonHighlight;
            btCalendario.Image = (Image)resources.GetObject("btCalendario.Image");
            btCalendario.ImageAlign = ContentAlignment.MiddleRight;
            btCalendario.Location = new Point(0, 70);
            btCalendario.Name = "btCalendario";
            btCalendario.Padding = new Padding(30, 0, 0, 0);
            btCalendario.Size = new Size(272, 35);
            btCalendario.TabIndex = 3;
            btCalendario.Text = "Calendario";
            btCalendario.TextAlign = ContentAlignment.MiddleLeft;
            btCalendario.UseVisualStyleBackColor = false;
            btCalendario.Click += btCalendario_Click;
            // 
            // btRecordatorio
            // 
            btRecordatorio.BackColor = Color.HotPink;
            btRecordatorio.Dock = DockStyle.Top;
            btRecordatorio.FlatAppearance.BorderSize = 0;
            btRecordatorio.FlatStyle = FlatStyle.Flat;
            btRecordatorio.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btRecordatorio.ForeColor = SystemColors.ButtonHighlight;
            btRecordatorio.Image = (Image)resources.GetObject("btRecordatorio.Image");
            btRecordatorio.ImageAlign = ContentAlignment.MiddleRight;
            btRecordatorio.Location = new Point(0, 35);
            btRecordatorio.Name = "btRecordatorio";
            btRecordatorio.Padding = new Padding(30, 0, 0, 0);
            btRecordatorio.Size = new Size(272, 35);
            btRecordatorio.TabIndex = 2;
            btRecordatorio.Text = "Recordatorio";
            btRecordatorio.TextAlign = ContentAlignment.MiddleLeft;
            btRecordatorio.UseVisualStyleBackColor = false;
            btRecordatorio.Click += btRecordatorio_Click;
            // 
            // btTareasPendientes
            // 
            btTareasPendientes.BackColor = Color.HotPink;
            btTareasPendientes.Dock = DockStyle.Top;
            btTareasPendientes.FlatAppearance.BorderSize = 0;
            btTareasPendientes.FlatStyle = FlatStyle.Flat;
            btTareasPendientes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btTareasPendientes.ForeColor = SystemColors.ButtonHighlight;
            btTareasPendientes.Image = (Image)resources.GetObject("btTareasPendientes.Image");
            btTareasPendientes.ImageAlign = ContentAlignment.MiddleRight;
            btTareasPendientes.Location = new Point(0, 0);
            btTareasPendientes.Name = "btTareasPendientes";
            btTareasPendientes.Padding = new Padding(30, 0, 0, 0);
            btTareasPendientes.Size = new Size(272, 35);
            btTareasPendientes.TabIndex = 1;
            btTareasPendientes.Text = "Tareas Pendientes";
            btTareasPendientes.TextAlign = ContentAlignment.MiddleLeft;
            btTareasPendientes.UseVisualStyleBackColor = false;
            btTareasPendientes.Click += btTareasPendientes_Click;
            // 
            // btAgendayCalendario
            // 
            btAgendayCalendario.BackColor = Color.MediumVioletRed;
            btAgendayCalendario.Dock = DockStyle.Top;
            btAgendayCalendario.FlatAppearance.BorderSize = 0;
            btAgendayCalendario.FlatStyle = FlatStyle.Flat;
            btAgendayCalendario.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btAgendayCalendario.ForeColor = SystemColors.ButtonFace;
            btAgendayCalendario.Image = (Image)resources.GetObject("btAgendayCalendario.Image");
            btAgendayCalendario.ImageAlign = ContentAlignment.MiddleRight;
            btAgendayCalendario.Location = new Point(0, 233);
            btAgendayCalendario.Name = "btAgendayCalendario";
            btAgendayCalendario.Size = new Size(272, 40);
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
            subPanelAlmacenes.Location = new Point(0, 165);
            subPanelAlmacenes.Name = "subPanelAlmacenes";
            subPanelAlmacenes.Size = new Size(272, 68);
            subPanelAlmacenes.TabIndex = 1;
            // 
            // btGestionarAlmacenes
            // 
            btGestionarAlmacenes.BackColor = Color.HotPink;
            btGestionarAlmacenes.Dock = DockStyle.Top;
            btGestionarAlmacenes.FlatAppearance.BorderSize = 0;
            btGestionarAlmacenes.FlatStyle = FlatStyle.Flat;
            btGestionarAlmacenes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btGestionarAlmacenes.ForeColor = SystemColors.ButtonHighlight;
            btGestionarAlmacenes.Image = (Image)resources.GetObject("btGestionarAlmacenes.Image");
            btGestionarAlmacenes.ImageAlign = ContentAlignment.MiddleRight;
            btGestionarAlmacenes.Location = new Point(0, 35);
            btGestionarAlmacenes.Name = "btGestionarAlmacenes";
            btGestionarAlmacenes.Padding = new Padding(30, 0, 0, 0);
            btGestionarAlmacenes.Size = new Size(272, 35);
            btGestionarAlmacenes.TabIndex = 2;
            btGestionarAlmacenes.Text = "Gestionar Almacenes";
            btGestionarAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btGestionarAlmacenes.UseVisualStyleBackColor = false;
            btGestionarAlmacenes.Click += btGestionarAlmacenes_Click;
            // 
            // btVerAlmacenes
            // 
            btVerAlmacenes.BackColor = Color.HotPink;
            btVerAlmacenes.Dock = DockStyle.Top;
            btVerAlmacenes.FlatAppearance.BorderSize = 0;
            btVerAlmacenes.FlatStyle = FlatStyle.Flat;
            btVerAlmacenes.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btVerAlmacenes.ForeColor = SystemColors.ButtonHighlight;
            btVerAlmacenes.Image = (Image)resources.GetObject("btVerAlmacenes.Image");
            btVerAlmacenes.ImageAlign = ContentAlignment.MiddleRight;
            btVerAlmacenes.Location = new Point(0, 0);
            btVerAlmacenes.Name = "btVerAlmacenes";
            btVerAlmacenes.Padding = new Padding(30, 0, 0, 0);
            btVerAlmacenes.Size = new Size(272, 35);
            btVerAlmacenes.TabIndex = 1;
            btVerAlmacenes.Text = "Ver Almacenes";
            btVerAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btVerAlmacenes.UseVisualStyleBackColor = false;
            btVerAlmacenes.Click += btVerAlmacenes_Click;
            // 
            // btAlmacenes
            // 
            btAlmacenes.BackColor = Color.MediumVioletRed;
            btAlmacenes.Dock = DockStyle.Top;
            btAlmacenes.FlatAppearance.BorderSize = 0;
            btAlmacenes.FlatStyle = FlatStyle.Flat;
            btAlmacenes.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            btAlmacenes.ForeColor = SystemColors.ButtonFace;
            btAlmacenes.Image = (Image)resources.GetObject("btAlmacenes.Image");
            btAlmacenes.ImageAlign = ContentAlignment.MiddleRight;
            btAlmacenes.Location = new Point(0, 125);
            btAlmacenes.Name = "btAlmacenes";
            btAlmacenes.Padding = new Padding(10, 0, 0, 0);
            btAlmacenes.Size = new Size(272, 40);
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
            panel3.Name = "panel3";
            panel3.Size = new Size(272, 125);
            panel3.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.HotPink;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(272, 125);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // ChildrenForm
            // 
            ChildrenForm.BackColor = Color.Plum;
            ChildrenForm.Controls.Add(lbfecha);
            ChildrenForm.Controls.Add(lbhora);
            ChildrenForm.Dock = DockStyle.Fill;
            ChildrenForm.Location = new Point(272, 49);
            ChildrenForm.Name = "ChildrenForm";
            ChildrenForm.Size = new Size(842, 662);
            ChildrenForm.TabIndex = 2;
            ChildrenForm.Paint += ChildrenForm_Paint;
            // 
            // lbfecha
            // 
            lbfecha.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbfecha.AutoSize = true;
            lbfecha.BackColor = Color.Transparent;
            lbfecha.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbfecha.ForeColor = SystemColors.Control;
            lbfecha.Location = new Point(334, 308);
            lbfecha.Name = "lbfecha";
            lbfecha.Size = new Size(139, 46);
            lbfecha.TabIndex = 2;
            lbfecha.Text = "label3";
            // 
            // lbhora
            // 
            lbhora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lbhora.AutoSize = true;
            lbhora.BackColor = Color.Transparent;
            lbhora.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lbhora.ForeColor = SystemColors.Control;
            lbhora.Location = new Point(296, 239);
            lbhora.Name = "lbhora";
            lbhora.Size = new Size(164, 70);
            lbhora.TabIndex = 0;
            lbhora.Text = "hora";
            lbhora.Click += lbhora_Click;
            // 
            // tmrFecha_Hora
            // 
            tmrFecha_Hora.Enabled = true;
            tmrFecha_Hora.Tick += timer1_Tick;
            // 
            // Principal_Prueba
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 711);
            Controls.Add(ChildrenForm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Principal_Prueba";
            Text = "Principal_Prueba";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            subPanelParcelas.ResumeLayout(false);
            subPanelAgendayCalendario.ResumeLayout(false);
            subPanelAlmacenes.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ChildrenForm.ResumeLayout(false);
            ChildrenForm.PerformLayout();
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
        private ComboBox cmbxColor;
    }
}