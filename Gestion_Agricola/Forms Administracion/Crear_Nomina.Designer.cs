﻿namespace Gestion_Agricola
{
    partial class Crear_Nomina
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(427, 318);
            label1.Name = "label1";
            label1.Size = new Size(93, 126);
            label1.TabIndex = 1;
            label1.Text = "2";
            // 
            // Crear_Nomina
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 816);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Crear_Nomina";
            Text = "Crear_Nomina";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
    }
}