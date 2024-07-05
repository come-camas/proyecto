namespace Gestion_Agricola
{
    partial class Gestionar_Parcelas
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
            label1 = new Label();
            label2 = new Label();
            datefechaabono = new DateTimePicker();
            label6 = new Label();
            combolimpieza = new ComboBox();
            label3 = new Label();
            combofumigacion = new ComboBox();
            combotiempocosecha = new ComboBox();
            label4 = new Label();
            btcrearparcelas = new Button();
            cmbxCultivo = new ComboBox();
            pngt1 = new Panel();
            pngt2 = new Panel();
            pngt3 = new Panel();
            pngt4 = new Panel();
            pngt5 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(209, 27);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(169, 46);
            label1.TabIndex = 7;
            label1.Text = "Cultivo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(143, 135);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(289, 46);
            label2.TabIndex = 15;
            label2.Text = "Fecha Abono:";
            // 
            // datefechaabono
            // 
            datefechaabono.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            datefechaabono.Format = DateTimePickerFormat.Custom;
            datefechaabono.Location = new Point(227, 183);
            datefechaabono.Margin = new Padding(2);
            datefechaabono.Name = "datefechaabono";
            datefechaabono.Size = new Size(139, 32);
            datefechaabono.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(184, 231);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(208, 46);
            label6.TabIndex = 19;
            label6.Text = "Limpieza:";
            // 
            // combolimpieza
            // 
            combolimpieza.BackColor = SystemColors.MenuBar;
            combolimpieza.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combolimpieza.FormattingEnabled = true;
            combolimpieza.Items.AddRange(new object[] { "Superficial", "Normal", "Exhaustiva" });
            combolimpieza.Location = new Point(210, 279);
            combolimpieza.Margin = new Padding(2);
            combolimpieza.Name = "combolimpieza";
            combolimpieza.Size = new Size(168, 32);
            combolimpieza.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(152, 330);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 46);
            label3.TabIndex = 23;
            label3.Text = "Fumigacion:";
            // 
            // combofumigacion
            // 
            combofumigacion.BackColor = SystemColors.MenuBar;
            combofumigacion.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combofumigacion.FormattingEnabled = true;
            combofumigacion.Items.AddRange(new object[] { "Quimica", "Termica", "Gas", "Biologica" });
            combofumigacion.Location = new Point(218, 388);
            combofumigacion.Margin = new Padding(2);
            combofumigacion.Name = "combofumigacion";
            combofumigacion.Size = new Size(154, 32);
            combofumigacion.TabIndex = 24;
            combofumigacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // combotiempocosecha
            // 
            combotiempocosecha.BackColor = SystemColors.MenuBar;
            combotiempocosecha.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            combotiempocosecha.FormattingEnabled = true;
            combotiempocosecha.Items.AddRange(new object[] { "7 Dias", "15 Dias", "1 mes", "3 meses", "6 meses", "9 meses", "12 meses" });
            combotiempocosecha.Location = new Point(227, 495);
            combotiempocosecha.Margin = new Padding(2);
            combotiempocosecha.Name = "combotiempocosecha";
            combotiempocosecha.Size = new Size(117, 32);
            combotiempocosecha.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(103, 436);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(353, 46);
            label4.TabIndex = 26;
            label4.Text = "Tiempo cosecha:";
            // 
            // btcrearparcelas
            // 
            btcrearparcelas.BackColor = Color.Khaki;
            btcrearparcelas.FlatStyle = FlatStyle.Flat;
            btcrearparcelas.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btcrearparcelas.ForeColor = SystemColors.ActiveCaptionText;
            btcrearparcelas.Location = new Point(544, 254);
            btcrearparcelas.Margin = new Padding(2);
            btcrearparcelas.Name = "btcrearparcelas";
            btcrearparcelas.Size = new Size(227, 84);
            btcrearparcelas.TabIndex = 28;
            btcrearparcelas.Text = "Crear Parcela";
            btcrearparcelas.UseVisualStyleBackColor = false;
            btcrearparcelas.Click += crearparcelas_Click;
            // 
            // cmbxCultivo
            // 
            cmbxCultivo.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbxCultivo.ForeColor = SystemColors.ActiveCaptionText;
            cmbxCultivo.FormattingEnabled = true;
            cmbxCultivo.Items.AddRange(new object[] { "papas", "zanahorias", "arroz", "frijol" });
            cmbxCultivo.Location = new Point(201, 76);
            cmbxCultivo.Name = "cmbxCultivo";
            cmbxCultivo.Size = new Size(177, 32);
            cmbxCultivo.TabIndex = 29;
            // 
            // pngt1
            // 
            pngt1.BackColor = SystemColors.InfoText;
            pngt1.Location = new Point(103, 113);
            pngt1.Margin = new Padding(2);
            pngt1.Name = "pngt1";
            pngt1.Size = new Size(353, 10);
            pngt1.TabIndex = 7;
            // 
            // pngt2
            // 
            pngt2.BackColor = SystemColors.InfoText;
            pngt2.Location = new Point(103, 219);
            pngt2.Margin = new Padding(2);
            pngt2.Name = "pngt2";
            pngt2.Size = new Size(353, 10);
            pngt2.TabIndex = 8;
            // 
            // pngt3
            // 
            pngt3.BackColor = SystemColors.InfoText;
            pngt3.Location = new Point(103, 318);
            pngt3.Margin = new Padding(2);
            pngt3.Name = "pngt3";
            pngt3.Size = new Size(353, 10);
            pngt3.TabIndex = 30;
            // 
            // pngt4
            // 
            pngt4.BackColor = SystemColors.InfoText;
            pngt4.Location = new Point(103, 424);
            pngt4.Margin = new Padding(2);
            pngt4.Name = "pngt4";
            pngt4.Size = new Size(353, 10);
            pngt4.TabIndex = 8;
            // 
            // pngt5
            // 
            pngt5.BackColor = SystemColors.InfoText;
            pngt5.Location = new Point(103, 542);
            pngt5.Margin = new Padding(2);
            pngt5.Name = "pngt5";
            pngt5.Size = new Size(353, 10);
            pngt5.TabIndex = 8;
            // 
            // Gestionar_Parcelas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(846, 627);
            Controls.Add(pngt5);
            Controls.Add(pngt4);
            Controls.Add(pngt3);
            Controls.Add(pngt2);
            Controls.Add(pngt1);
            Controls.Add(cmbxCultivo);
            Controls.Add(btcrearparcelas);
            Controls.Add(combotiempocosecha);
            Controls.Add(label4);
            Controls.Add(combofumigacion);
            Controls.Add(label3);
            Controls.Add(combolimpieza);
            Controls.Add(label6);
            Controls.Add(datefechaabono);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Gestionar_Parcelas";
            Text = "Gestionar_Parcelas";
            Load += Gestionar_Parcelas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DateTimePicker datefechaabono;
        private Label label6;
        private ComboBox combolimpieza;
        private Label label3;
        private ComboBox combofumigacion;
        private ComboBox combotiempocosecha;
        private Label label4;
        public Button btcrearparcelas;
        private ComboBox cmbxCultivo;
        public Panel pngt1;
        public Panel pngt2;
        public Panel pngt3;
        public Panel pngt4;
        public Panel pngt5;
    }
}