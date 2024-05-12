namespace Gestion_Agricola
{
    partial class principal
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
            PanelLateral = new Panel();
            panelLogo = new Panel();
            btAlmacenes = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnSubMenuAlmacenes = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            PanelLateral.SuspendLayout();
            pnSubMenuAlmacenes.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLateral
            // 
            PanelLateral.BackColor = SystemColors.ActiveCaptionText;
            PanelLateral.Controls.Add(button5);
            PanelLateral.Controls.Add(button3);
            PanelLateral.Controls.Add(pnSubMenuAlmacenes);
            PanelLateral.Controls.Add(flowLayoutPanel1);
            PanelLateral.Controls.Add(btAlmacenes);
            PanelLateral.Controls.Add(panelLogo);
            PanelLateral.Dock = DockStyle.Left;
            PanelLateral.Location = new Point(0, 0);
            PanelLateral.Name = "PanelLateral";
            PanelLateral.Size = new Size(250, 548);
            PanelLateral.TabIndex = 0;
            PanelLateral.Paint += panel1_Paint;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(250, 118);
            panelLogo.TabIndex = 1;
            // 
            // btAlmacenes
            // 
            btAlmacenes.Dock = DockStyle.Top;
            btAlmacenes.FlatStyle = FlatStyle.Flat;
            btAlmacenes.ForeColor = Color.Transparent;
            btAlmacenes.Location = new Point(0, 118);
            btAlmacenes.Name = "btAlmacenes";
            btAlmacenes.Padding = new Padding(10, 0, 0, 0);
            btAlmacenes.Size = new Size(250, 45);
            btAlmacenes.TabIndex = 0;
            btAlmacenes.Text = "Almacenes";
            btAlmacenes.TextAlign = ContentAlignment.MiddleLeft;
            btAlmacenes.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 125);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pnSubMenuAlmacenes
            // 
            pnSubMenuAlmacenes.BackColor = SystemColors.AppWorkspace;
            pnSubMenuAlmacenes.Controls.Add(button4);
            pnSubMenuAlmacenes.Controls.Add(button2);
            pnSubMenuAlmacenes.Controls.Add(button1);
            pnSubMenuAlmacenes.Dock = DockStyle.Top;
            pnSubMenuAlmacenes.Location = new Point(0, 163);
            pnSubMenuAlmacenes.Name = "pnSubMenuAlmacenes";
            pnSubMenuAlmacenes.Size = new Size(250, 77);
            pnSubMenuAlmacenes.TabIndex = 1;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(250, 40);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(0, 40);
            button2.Name = "button2";
            button2.Size = new Size(250, 40);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Top;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(0, 240);
            button3.Name = "button3";
            button3.Padding = new Padding(10, 0, 0, 0);
            button3.Size = new Size(250, 45);
            button3.TabIndex = 3;
            button3.Text = "Almacenes";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Top;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(0, 80);
            button4.Name = "button4";
            button4.Size = new Size(250, 40);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Top;
            button5.Location = new Point(0, 285);
            button5.Name = "button5";
            button5.Size = new Size(250, 42);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1512, 548);
            Controls.Add(PanelLateral);
            Name = "principal";
            Text = "principal";
            Load += principal_Load;
            PanelLateral.ResumeLayout(false);
            pnSubMenuAlmacenes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelLateral;
        private Panel pnSubMenuAlmacenes;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btAlmacenes;
        private Panel panelLogo;
        private Button button2;
        private Button button5;
        private Button button3;
        private Button button4;
    }
}