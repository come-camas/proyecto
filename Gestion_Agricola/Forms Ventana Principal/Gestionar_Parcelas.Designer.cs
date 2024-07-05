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
            panel1 = new Panel();
            txtCultivo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            datefechaabono = new DateTimePicker();
            label6 = new Label();
            panel3 = new Panel();
            combolimpieza = new ComboBox();
            label3 = new Label();
            panel4 = new Panel();
            combofumigacion = new ComboBox();
            combotiempocosecha = new ComboBox();
            label4 = new Label();
            panel5 = new Panel();
            crearparcelas = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InfoText;
            panel1.Location = new Point(26, 175);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 2);
            panel1.TabIndex = 6;
            // 
            // txtCultivo
            // 
            txtCultivo.BackColor = SystemColors.MenuBar;
            txtCultivo.BorderStyle = BorderStyle.None;
            txtCultivo.Cursor = Cursors.IBeam;
            txtCultivo.Location = new Point(114, 148);
            txtCultivo.Name = "txtCultivo";
            txtCultivo.Size = new Size(241, 24);
            txtCultivo.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 147);
            label1.Name = "label1";
            label1.Size = new Size(82, 25);
            label1.TabIndex = 7;
            label1.Text = "Cultivo:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 202);
            label2.Name = "label2";
            label2.Size = new Size(132, 25);
            label2.TabIndex = 15;
            label2.Text = "Fecha Abono:";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.InfoText;
            panel2.Location = new Point(26, 230);
            panel2.Name = "panel2";
            panel2.Size = new Size(310, 2);
            panel2.TabIndex = 14;
            // 
            // datefechaabono
            // 
            datefechaabono.Format = DateTimePickerFormat.Custom;
            datefechaabono.Location = new Point(160, 198);
            datefechaabono.Name = "datefechaabono";
            datefechaabono.Size = new Size(173, 31);
            datefechaabono.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(26, 259);
            label6.Name = "label6";
            label6.Size = new Size(98, 25);
            label6.TabIndex = 19;
            label6.Text = "Limpieza:";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.InfoText;
            panel3.Location = new Point(26, 287);
            panel3.Name = "panel3";
            panel3.Size = new Size(310, 2);
            panel3.TabIndex = 18;
            // 
            // combolimpieza
            // 
            combolimpieza.BackColor = SystemColors.MenuBar;
            combolimpieza.FormattingEnabled = true;
            combolimpieza.Items.AddRange(new object[] { "Superficial", "Normal", "Exhaustiva" });
            combolimpieza.Location = new Point(127, 253);
            combolimpieza.Name = "combolimpieza";
            combolimpieza.Size = new Size(209, 33);
            combolimpieza.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 323);
            label3.Name = "label3";
            label3.Size = new Size(121, 25);
            label3.TabIndex = 23;
            label3.Text = "Fumigacion:";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.InfoText;
            panel4.Location = new Point(26, 351);
            panel4.Name = "panel4";
            panel4.Size = new Size(310, 2);
            panel4.TabIndex = 22;
            // 
            // combofumigacion
            // 
            combofumigacion.BackColor = SystemColors.MenuBar;
            combofumigacion.FormattingEnabled = true;
            combofumigacion.Items.AddRange(new object[] { "Quimica", "Termica", "Gas", "Biologica" });
            combofumigacion.Location = new Point(144, 315);
            combofumigacion.Name = "combofumigacion";
            combofumigacion.Size = new Size(192, 33);
            combofumigacion.TabIndex = 24;
            combofumigacion.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // combotiempocosecha
            // 
            combotiempocosecha.BackColor = SystemColors.MenuBar;
            combotiempocosecha.FormattingEnabled = true;
            combotiempocosecha.Items.AddRange(new object[] { "7 Dias", "15 Dias", "1 mes", "3 meses", "6 meses", "9 meses", "12 meses" });
            combotiempocosecha.Location = new Point(191, 376);
            combotiempocosecha.Name = "combotiempocosecha";
            combotiempocosecha.Size = new Size(145, 33);
            combotiempocosecha.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 384);
            label4.Name = "label4";
            label4.Size = new Size(159, 25);
            label4.TabIndex = 26;
            label4.Text = "Tiempo cosecha:";
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.InfoText;
            panel5.Location = new Point(26, 412);
            panel5.Name = "panel5";
            panel5.Size = new Size(310, 2);
            panel5.TabIndex = 25;
            // 
            // crearparcelas
            // 
            crearparcelas.BackColor = SystemColors.MenuBar;
            crearparcelas.FlatStyle = FlatStyle.Flat;
            crearparcelas.Location = new Point(786, 642);
            crearparcelas.Name = "crearparcelas";
            crearparcelas.Size = new Size(180, 57);
            crearparcelas.TabIndex = 28;
            crearparcelas.Text = "Crear Parcela";
            crearparcelas.UseVisualStyleBackColor = false;
            crearparcelas.Click += crearparcelas_Click;
            // 
            // Gestionar_Parcelas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(1058, 784);
            Controls.Add(crearparcelas);
            Controls.Add(combotiempocosecha);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(combofumigacion);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(combolimpieza);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(datefechaabono);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(txtCultivo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Gestionar_Parcelas";
            Text = "Gestionar_Parcelas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox txtCultivo;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private DateTimePicker datefechaabono;
        private Label label6;
        private Panel panel3;
        private ComboBox combolimpieza;
        private Label label3;
        private Panel panel4;
        private ComboBox combofumigacion;
        private ComboBox combotiempocosecha;
        private Label label4;
        private Panel panel5;
        private Button crearparcelas;
    }
}