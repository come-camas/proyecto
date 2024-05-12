namespace Gestion_Agricola
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            Datos_login = new Button();
            label3 = new Label();
            label4 = new Label();
            usuario_login = new TextBox();
            contraseña_login = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(167, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 28F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(136, 181);
            label1.Name = "label1";
            label1.Size = new Size(194, 63);
            label1.TabIndex = 1;
            label1.Text = "LOG IN";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.login_avatar;
            pictureBox2.Location = new Point(32, 303);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(57, 52);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(32, 417);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(57, 52);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Desktop;
            panel2.Location = new Point(32, 361);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 2);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlText;
            panel3.Location = new Point(32, 475);
            panel3.Name = "panel3";
            panel3.Size = new Size(400, 2);
            panel3.TabIndex = 5;
            // 
            // Datos_login
            // 
            Datos_login.BackColor = Color.Black;
            Datos_login.FlatAppearance.BorderSize = 0;
            Datos_login.FlatStyle = FlatStyle.Flat;
            Datos_login.Font = new Font("Bahnschrift", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Datos_login.ForeColor = Color.White;
            Datos_login.Location = new Point(32, 541);
            Datos_login.Name = "Datos_login";
            Datos_login.Size = new Size(400, 49);
            Datos_login.TabIndex = 6;
            Datos_login.Text = "LOG IN";
            Datos_login.UseVisualStyleBackColor = false;
            Datos_login.Click += Datos_login_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(303, 499);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 8;
            label3.Text = "Limpiar casillas";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(204, 628);
            label4.Name = "label4";
            label4.Size = new Size(50, 28);
            label4.TabIndex = 9;
            label4.Text = "Salir";
            label4.Click += label4_Click;
            // 
            // usuario_login
            // 
            usuario_login.BorderStyle = BorderStyle.None;
            usuario_login.Cursor = Cursors.IBeam;
            usuario_login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            usuario_login.Location = new Point(95, 309);
            usuario_login.Multiline = true;
            usuario_login.Name = "usuario_login";
            usuario_login.Size = new Size(337, 46);
            usuario_login.TabIndex = 10;
            // 
            // contraseña_login
            // 
            contraseña_login.BorderStyle = BorderStyle.None;
            contraseña_login.Cursor = Cursors.IBeam;
            contraseña_login.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            contraseña_login.Location = new Point(95, 423);
            contraseña_login.Multiline = true;
            contraseña_login.Name = "contraseña_login";
            contraseña_login.Size = new Size(337, 46);
            contraseña_login.TabIndex = 11;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(481, 707);
            Controls.Add(contraseña_login);
            Controls.Add(usuario_login);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(Datos_login);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel2;
        private Panel panel3;
        private Button Datos_login;
        private Label label3;
        private Label label4;
        private TextBox usuario_login;
        private TextBox contraseña_login;
    }
}