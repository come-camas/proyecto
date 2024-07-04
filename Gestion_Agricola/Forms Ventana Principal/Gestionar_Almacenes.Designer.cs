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
            groupBox1 = new GroupBox();
            txtID = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            cmbxProducto = new ComboBox();
            btCambiarImagen = new Button();
            btEliminar = new Button();
            btGuardar = new Button();
            txtCantidad = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(cmbxProducto);
            groupBox1.Controls.Add(btCambiarImagen);
            groupBox1.Controls.Add(btEliminar);
            groupBox1.Controls.Add(btGuardar);
            groupBox1.Controls.Add(txtCantidad);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(822, 603);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtID
            // 
            txtID.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.ForeColor = SystemColors.ActiveCaptionText;
            txtID.Location = new Point(121, 102);
            txtID.Name = "txtID";
            txtID.Size = new Size(207, 30);
            txtID.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(198, 42);
            label3.Name = "label3";
            label3.Size = new Size(63, 46);
            label3.TabIndex = 10;
            label3.Text = "ID";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(334, 236);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // cmbxProducto
            // 
            cmbxProducto.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbxProducto.ForeColor = SystemColors.ActiveCaptionText;
            cmbxProducto.FormattingEnabled = true;
            cmbxProducto.Items.AddRange(new object[] { "papas", "zanahorias", "arroz", "frijol" });
            cmbxProducto.Location = new Point(118, 236);
            cmbxProducto.Name = "cmbxProducto";
            cmbxProducto.Size = new Size(207, 32);
            cmbxProducto.TabIndex = 7;
            cmbxProducto.SelectedIndexChanged += cmbxProducto_SelectedIndexChanged;
            // 
            // btCambiarImagen
            // 
            btCambiarImagen.ForeColor = SystemColors.ActiveCaptionText;
            btCambiarImagen.Location = new Point(521, 361);
            btCambiarImagen.Name = "btCambiarImagen";
            btCambiarImagen.Size = new Size(234, 42);
            btCambiarImagen.TabIndex = 6;
            btCambiarImagen.Text = "Cambiar Imagen";
            btCambiarImagen.UseVisualStyleBackColor = true;
            // 
            // btEliminar
            // 
            btEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btEliminar.Location = new Point(269, 451);
            btEliminar.Name = "btEliminar";
            btEliminar.Size = new Size(205, 62);
            btEliminar.TabIndex = 5;
            btEliminar.Text = "Eliminar";
            btEliminar.UseVisualStyleBackColor = true;
            // 
            // btGuardar
            // 
            btGuardar.ForeColor = SystemColors.ActiveCaptionText;
            btGuardar.Location = new Point(18, 451);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(205, 62);
            btGuardar.TabIndex = 4;
            btGuardar.Text = "Guardar";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCantidad.ForeColor = SystemColors.ActiveCaptionText;
            txtCantidad.Location = new Point(124, 361);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(207, 30);
            txtCantidad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(125, 290);
            label2.Name = "label2";
            label2.Size = new Size(197, 46);
            label2.TabIndex = 1;
            label2.Text = "Cantidad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(128, 163);
            label1.Name = "label1";
            label1.Size = new Size(200, 46);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // Gestionar_Almacenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 627);
            Controls.Add(groupBox1);
            Name = "Gestionar_Almacenes";
            Text = "Gestionar_Almacenes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ComboBox cmbxProducto;
        private Button btCambiarImagen;
        private Button btEliminar;
        private Button btGuardar;
        private TextBox txtCantidad;
        private Label label2;
        private Label label1;
        private TextBox txtID;
        private Label label3;
    }
}