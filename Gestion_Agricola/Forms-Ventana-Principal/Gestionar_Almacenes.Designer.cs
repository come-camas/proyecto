namespace Gestion_Agricola
{
    partial class Gestionar_Almacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar_Almacenes));
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            btGuardar = new Button();
            btEliminar = new Button();
            btCambiarImagen = new Button();
            cmbxProducto = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(120, 77);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(123, 236);
            label2.Name = "label2";
            label2.Size = new Size(197, 46);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ActiveCaptionText;
            textBox2.Location = new Point(116, 315);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 30);
            textBox2.TabIndex = 3;
            // 
            // btGuardar
            // 
            btGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btGuardar.Location = new Point(40, 475);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(205, 62);
            btGuardar.TabIndex = 4;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            btEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btEliminar.Location = new Point(291, 475);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(205, 62);
            btEliminar.TabIndex = 5;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            // 
            // btCambiarImagen
            // 
            btCambiarImagen.ForeColor = SystemColors.ActiveCaptionText;
            btCambiarImagen.Location = new Point(543, 385);
            btCambiarImagen.Name = "btCambiarImagen";
            btCambiarImagen.Size = new Size(234, 42);
            btCambiarImagen.TabIndex = 6;
            btCambiarImagen.Text = "Cambiar Imagen";
            btCambiarImagen.UseVisualStyleBackColor = true;
            // 
            // cmbxProducto
            // 
            cmbxProducto.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbxProducto.ForeColor = SystemColors.ActiveCaptionText;
            cmbxProducto.FormattingEnabled = true;
            cmbxProducto.Location = new Point(116, 147);
            cmbxProducto.Name = "cmbxProducto";
            cmbxProducto.Size = new Size(207, 32);
            cmbxProducto.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(543, 136);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(329, 147);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Gestionar_Almacenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(846, 627);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(cmbxProducto);
            Controls.Add(btCambiarImagen);
            Controls.Add(btEliminar);
            Controls.Add(btGuardar);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Gestionar_Almacenes";
            Text = "Gestionar_Almacenes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button btGuardar;
        private Button btEliminar;
        private Button btCambiarImagen;
        private ComboBox cmbxProducto;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}