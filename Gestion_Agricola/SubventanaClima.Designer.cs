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
            SuspendLayout();
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lb1.Location = new Point(161, 24);
            lb1.Name = "lb1";
            lb1.Size = new Size(270, 26);
            lb1.TabIndex = 0;
            lb1.Text = "ANALISIS DEL CLIMA ";
            // 
            // SubventanaClima
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 332);
            Controls.Add(lb1);
            Name = "SubventanaClima";
            Text = "SubventanaClima";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb1;
    }
}