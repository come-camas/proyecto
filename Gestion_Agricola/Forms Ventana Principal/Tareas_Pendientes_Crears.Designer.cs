namespace Gestion_Agricola
{
    partial class Tareas_Pendientes_Crears
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tareas_Pendientes_Crears));
            panel1 = new Panel();
            label4 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cmbxPrioridad = new ComboBox();
            txtNotas = new TextBox();
            txtDescripcion = new TextBox();
            dtpkFechaVencimiento = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumAquamarine;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(657, 53);
            panel1.TabIndex = 7;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(9, 7);
            label4.Name = "label4";
            label4.Size = new Size(258, 39);
            label4.TabIndex = 7;
            label4.Text = "Agregar Tarea";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 213);
            label5.Name = "label5";
            label5.Size = new Size(86, 32);
            label5.TabIndex = 11;
            label5.Text = "Notas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(22, 122);
            label3.Name = "label3";
            label3.Size = new Size(294, 32);
            label3.TabIndex = 10;
            label3.Text = "Fecha De Vencimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 165);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 9;
            label2.Text = "Prioridad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 77);
            label1.Name = "label1";
            label1.Size = new Size(159, 32);
            label1.TabIndex = 8;
            label1.Text = "Descripcion";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(471, 253);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(46, 46);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(534, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 46);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // cmbxPrioridad
            // 
            cmbxPrioridad.FormattingEnabled = true;
            cmbxPrioridad.Items.AddRange(new object[] { "baja", "media", "alta" });
            cmbxPrioridad.Location = new Point(323, 172);
            cmbxPrioridad.Name = "cmbxPrioridad";
            cmbxPrioridad.Size = new Size(257, 28);
            cmbxPrioridad.TabIndex = 15;
            // 
            // txtNotas
            // 
            txtNotas.Location = new Point(323, 220);
            txtNotas.Name = "txtNotas";
            txtNotas.Size = new Size(257, 27);
            txtNotas.TabIndex = 14;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(323, 84);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(257, 31);
            txtDescripcion.TabIndex = 12;
            // 
            // dtpkFechaVencimiento
            // 
            dtpkFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpkFechaVencimiento.Location = new Point(323, 127);
            dtpkFechaVencimiento.Name = "dtpkFechaVencimiento";
            dtpkFechaVencimiento.Size = new Size(257, 27);
            dtpkFechaVencimiento.TabIndex = 18;
            // 
            // Tareas_Pendientes_Crears
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 311);
            Controls.Add(dtpkFechaVencimiento);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cmbxPrioridad);
            Controls.Add(txtNotas);
            Controls.Add(txtDescripcion);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Tareas_Pendientes_Crears";
            Text = "Tareas_Pendientes_Crears";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox cmbxPrioridad;
        private TextBox txtNotas;
        private TextBox txtDescripcion;
        private DateTimePicker dtpkFechaVencimiento;
    }
}