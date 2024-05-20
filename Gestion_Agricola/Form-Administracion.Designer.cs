namespace Gestion_Agricola
{
    partial class Form_Administracion
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
            Eliminar_Empleado = new Button();
            Crear_Emple = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(Eliminar_Empleado);
            panel1.Controls.Add(Crear_Emple);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(340, 886);
            panel1.TabIndex = 0;
            // 
            // Eliminar_Empleado
            // 
            Eliminar_Empleado.BackColor = Color.DarkCyan;
            Eliminar_Empleado.Dock = DockStyle.Top;
            Eliminar_Empleado.FlatAppearance.BorderSize = 0;
            Eliminar_Empleado.FlatStyle = FlatStyle.Flat;
            Eliminar_Empleado.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Eliminar_Empleado.ForeColor = SystemColors.MenuBar;
            Eliminar_Empleado.Location = new Point(0, 237);
            Eliminar_Empleado.Name = "Eliminar_Empleado";
            Eliminar_Empleado.Padding = new Padding(10, 0, 0, 0);
            Eliminar_Empleado.Size = new Size(340, 81);
            Eliminar_Empleado.TabIndex = 2;
            Eliminar_Empleado.Text = "Crear Nomina";
            Eliminar_Empleado.TextAlign = ContentAlignment.MiddleLeft;
            Eliminar_Empleado.UseVisualStyleBackColor = false;
            // 
            // Crear_Emple
            // 
            Crear_Emple.BackColor = Color.DarkCyan;
            Crear_Emple.Dock = DockStyle.Top;
            Crear_Emple.FlatAppearance.BorderSize = 0;
            Crear_Emple.FlatStyle = FlatStyle.Flat;
            Crear_Emple.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Crear_Emple.ForeColor = SystemColors.MenuBar;
            Crear_Emple.Location = new Point(0, 156);
            Crear_Emple.Name = "Crear_Emple";
            Crear_Emple.Padding = new Padding(10, 0, 0, 0);
            Crear_Emple.Size = new Size(340, 81);
            Crear_Emple.TabIndex = 1;
            Crear_Emple.Text = "Nuevo Empleado";
            Crear_Emple.TextAlign = ContentAlignment.MiddleLeft;
            Crear_Emple.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(340, 156);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkCyan;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuBar;
            button1.Location = new Point(0, 318);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 0, 0, 0);
            button1.Size = new Size(340, 81);
            button1.TabIndex = 3;
            button1.Text = "Baja de Empleado";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkCyan;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuBar;
            button2.Location = new Point(0, 399);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 0, 0, 0);
            button2.Size = new Size(340, 81);
            button2.TabIndex = 4;
            button2.Text = "Actualizar Datos";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // Form_Administracion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1508, 886);
            Controls.Add(panel1);
            Margin = new Padding(4);
            Name = "Form_Administracion";
            Text = "Form_Administracion";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button Crear_Emple;
        private Button Eliminar_Empleado;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}