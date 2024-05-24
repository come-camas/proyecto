namespace Gestion_Agricola
{
    partial class Analisis_Hoy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Analisis_Hoy));
            panelAClima = new Panel();
            panelBotones = new Panel();
            btnA30D = new Button();
            btnA15D = new Button();
            btnAHoy = new Button();
            panelAClima.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelAClima
            // 
            panelAClima.BackColor = Color.Transparent;
            panelAClima.BackgroundImage = (Image)resources.GetObject("panelAClima.BackgroundImage");
            panelAClima.BackgroundImageLayout = ImageLayout.None;
            panelAClima.Controls.Add(panelBotones);
            panelAClima.Dock = DockStyle.Fill;
            panelAClima.Location = new Point(0, 0);
            panelAClima.Name = "panelAClima";
            panelAClima.Size = new Size(642, 427);
            panelAClima.TabIndex = 1;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnA30D);
            panelBotones.Controls.Add(btnA15D);
            panelBotones.Controls.Add(btnAHoy);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(186, 427);
            panelBotones.TabIndex = 0;
            // 
            // btnA30D
            // 
            btnA30D.Dock = DockStyle.Top;
            btnA30D.FlatAppearance.BorderSize = 0;
            btnA30D.FlatStyle = FlatStyle.Flat;
            btnA30D.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA30D.Location = new Point(0, 110);
            btnA30D.Name = "btnA30D";
            btnA30D.Padding = new Padding(10, 0, 0, 0);
            btnA30D.Size = new Size(186, 55);
            btnA30D.TabIndex = 3;
            btnA30D.Text = "Analisis 30 dias";
            btnA30D.UseVisualStyleBackColor = true;
            // 
            // btnA15D
            // 
            btnA15D.Dock = DockStyle.Top;
            btnA15D.FlatAppearance.BorderSize = 0;
            btnA15D.FlatStyle = FlatStyle.Flat;
            btnA15D.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA15D.Location = new Point(0, 55);
            btnA15D.Name = "btnA15D";
            btnA15D.Padding = new Padding(10, 0, 0, 0);
            btnA15D.Size = new Size(186, 55);
            btnA15D.TabIndex = 2;
            btnA15D.Text = "Analisis 15 dias";
            btnA15D.UseVisualStyleBackColor = true;
            // 
            // btnAHoy
            // 
            btnAHoy.Dock = DockStyle.Top;
            btnAHoy.FlatAppearance.BorderSize = 0;
            btnAHoy.FlatStyle = FlatStyle.Flat;
            btnAHoy.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAHoy.Location = new Point(0, 0);
            btnAHoy.Name = "btnAHoy";
            btnAHoy.Padding = new Padding(10, 0, 0, 0);
            btnAHoy.Size = new Size(186, 55);
            btnAHoy.TabIndex = 1;
            btnAHoy.Text = "Analisis Hoy";
            btnAHoy.UseVisualStyleBackColor = true;
            // 
            // Analisis_Hoy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 427);
            Controls.Add(panelAClima);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Analisis_Hoy";
            Text = "Analisis_Hoy";
            Load += Analisis_Hoy_Load;
            panelAClima.ResumeLayout(false);
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public Panel panelAClima;
        public Panel panelBotones;
        private Button btnA30D;
        private Button btnA15D;
        private Button btnAHoy;
    }
}