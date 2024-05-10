namespace Gestion_Agricola
{
    partial class SubventanaClima
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
            lb1 = new Label();
            btnA15D = new Button();
            btnA30D = new Button();
            btnA1D = new Button();
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb1.Location = new Point(169, 9);
            lb1.Name = "lb1";
            lb1.Size = new Size(270, 26);
            lb1.TabIndex = 0;
            lb1.Text = "ANALISIS DEL CLIMA ";
            // 
            // btnA15D
            // 
            btnA15D.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA15D.Location = new Point(12, 270);
            btnA15D.Name = "btnA15D";
            btnA15D.Size = new Size(165, 23);
            btnA15D.TabIndex = 1;
            btnA15D.Text = "ANALIZAR 15 DIAS";
            btnA15D.UseVisualStyleBackColor = true;
            // 
            // btnA30D
            // 
            btnA30D.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA30D.Location = new Point(239, 270);
            btnA30D.Name = "btnA30D";
            btnA30D.Size = new Size(165, 23);
            btnA30D.TabIndex = 2;
            btnA30D.Text = "ANALIZAR 30 DIAS";
            btnA30D.UseVisualStyleBackColor = true;
            // 
            // btnA1D
            // 
            btnA1D.Font = new Font("Yu Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnA1D.Location = new Point(459, 270);
            btnA1D.Name = "btnA1D";
            btnA1D.Size = new Size(182, 23);
            btnA1D.TabIndex = 3;
            btnA1D.Text = "ANANALIZAR DIA HOY";
            btnA1D.UseVisualStyleBackColor = true;
            // 
            // SubventanaClima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 332);
            Controls.Add(btnA1D);
            Controls.Add(btnA30D);
            Controls.Add(btnA15D);
            Controls.Add(lb1);
            Name = "SubventanaClima";
            Text = "SubventanaClima";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
        private Button btnA15D;
        private Button btnA30D;
        private Button btnA1D;
    }
}