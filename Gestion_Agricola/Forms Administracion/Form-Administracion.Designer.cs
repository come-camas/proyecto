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
            Crear_Nomina = new Button();
            panel2 = new Panel();
            Actualizar_Datos_nomina = new Button();
            Eliminar_Empleado = new Button();
            Salir_Nomina = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(Salir_Nomina);
            panel1.Controls.Add(Eliminar_Empleado);
            panel1.Controls.Add(Actualizar_Datos_nomina);
            panel1.Controls.Add(Crear_Nomina);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 816);
            panel1.TabIndex = 2;
            // 
            // Crear_Nomina
            // 
            Crear_Nomina.BackColor = Color.DarkCyan;
            Crear_Nomina.Dock = DockStyle.Top;
            Crear_Nomina.FlatAppearance.BorderSize = 0;
            Crear_Nomina.FlatStyle = FlatStyle.Flat;
            Crear_Nomina.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Crear_Nomina.ForeColor = SystemColors.ButtonHighlight;
            Crear_Nomina.Location = new Point(0, 150);
            Crear_Nomina.Name = "Crear_Nomina";
            Crear_Nomina.Padding = new Padding(10, 0, 0, 0);
            Crear_Nomina.RightToLeft = RightToLeft.No;
            Crear_Nomina.Size = new Size(300, 50);
            Crear_Nomina.TabIndex = 0;
            Crear_Nomina.Text = "Crear Nomina";
            Crear_Nomina.TextAlign = ContentAlignment.MiddleLeft;
            Crear_Nomina.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 150);
            panel2.TabIndex = 1;
            // 
            // Actualizar_Datos_nomina
            // 
            Actualizar_Datos_nomina.BackColor = Color.DarkCyan;
            Actualizar_Datos_nomina.Dock = DockStyle.Top;
            Actualizar_Datos_nomina.FlatAppearance.BorderSize = 0;
            Actualizar_Datos_nomina.FlatStyle = FlatStyle.Flat;
            Actualizar_Datos_nomina.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Actualizar_Datos_nomina.ForeColor = SystemColors.ButtonHighlight;
            Actualizar_Datos_nomina.Location = new Point(0, 200);
            Actualizar_Datos_nomina.Name = "Actualizar_Datos_nomina";
            Actualizar_Datos_nomina.Padding = new Padding(10, 0, 0, 0);
            Actualizar_Datos_nomina.RightToLeft = RightToLeft.No;
            Actualizar_Datos_nomina.Size = new Size(300, 50);
            Actualizar_Datos_nomina.TabIndex = 2;
            Actualizar_Datos_nomina.Text = "Actualizar Datos";
            Actualizar_Datos_nomina.TextAlign = ContentAlignment.MiddleLeft;
            Actualizar_Datos_nomina.UseVisualStyleBackColor = false;
            // 
            // Eliminar_Empleado
            // 
            Eliminar_Empleado.BackColor = Color.DarkCyan;
            Eliminar_Empleado.Dock = DockStyle.Top;
            Eliminar_Empleado.FlatAppearance.BorderSize = 0;
            Eliminar_Empleado.FlatStyle = FlatStyle.Flat;
            Eliminar_Empleado.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Eliminar_Empleado.ForeColor = SystemColors.ButtonHighlight;
            Eliminar_Empleado.Location = new Point(0, 250);
            Eliminar_Empleado.Name = "Eliminar_Empleado";
            Eliminar_Empleado.Padding = new Padding(10, 0, 0, 0);
            Eliminar_Empleado.RightToLeft = RightToLeft.No;
            Eliminar_Empleado.Size = new Size(300, 50);
            Eliminar_Empleado.TabIndex = 3;
            Eliminar_Empleado.Text = "Eliminar Empleado";
            Eliminar_Empleado.TextAlign = ContentAlignment.MiddleLeft;
            Eliminar_Empleado.UseVisualStyleBackColor = false;
            // 
            // Salir_Nomina
            // 
            Salir_Nomina.BackColor = Color.DarkCyan;
            Salir_Nomina.Dock = DockStyle.Top;
            Salir_Nomina.FlatAppearance.BorderSize = 0;
            Salir_Nomina.FlatStyle = FlatStyle.Flat;
            Salir_Nomina.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Italic, GraphicsUnit.Point);
            Salir_Nomina.ForeColor = SystemColors.ButtonHighlight;
            Salir_Nomina.Location = new Point(0, 300);
            Salir_Nomina.Name = "Salir_Nomina";
            Salir_Nomina.Padding = new Padding(10, 0, 0, 0);
            Salir_Nomina.RightToLeft = RightToLeft.No;
            Salir_Nomina.Size = new Size(300, 50);
            Salir_Nomina.TabIndex = 4;
            Salir_Nomina.Text = "Salir";
            Salir_Nomina.TextAlign = ContentAlignment.MiddleLeft;
            Salir_Nomina.UseVisualStyleBackColor = false;
            // 
            // Form_Administracion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1344, 816);
            Controls.Add(panel1);
            Margin = new Padding(4);
            MinimumSize = new Size(500, 400);
            Name = "Form_Administracion";
            Text = "Form_Administracion";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button Crear_Nomina;
        private Button Salir_Nomina;
        private Button Eliminar_Empleado;
        private Button Actualizar_Datos_nomina;
    }
}