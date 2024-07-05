namespace Gestion_Agricola
{
    partial class Recordatorio
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
            dtgRecordatorio = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgRecordatorio).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 25.8000011F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(307, 51);
            label1.TabIndex = 4;
            label1.Text = "Recordatorio";
            // 
            // dtgRecordatorio
            // 
            dtgRecordatorio.AllowUserToDeleteRows = false;
            dtgRecordatorio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRecordatorio.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dtgRecordatorio.GridColor = SystemColors.InactiveCaptionText;
            dtgRecordatorio.Location = new Point(12, 99);
            dtgRecordatorio.Name = "dtgRecordatorio";
            dtgRecordatorio.ReadOnly = true;
            dtgRecordatorio.RowHeadersWidth = 51;
            dtgRecordatorio.RowTemplate.Height = 29;
            dtgRecordatorio.Size = new Size(829, 511);
            dtgRecordatorio.TabIndex = 3;
            dtgRecordatorio.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "No_Parcela";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cultivo";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 140;
            // 
            // Column3
            // 
            Column3.HeaderText = "Abono";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 140;
            // 
            // Column4
            // 
            Column4.HeaderText = "Limpieza";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 140;
            // 
            // Column5
            // 
            Column5.HeaderText = "Fumigacion";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 140;
            // 
            // Column6
            // 
            Column6.HeaderText = "Cosecha";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Recordatorio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 627);
            Controls.Add(label1);
            Controls.Add(dtgRecordatorio);
            ForeColor = SystemColors.ControlLight;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recordatorio";
            Text = "Recordatorio";
            ((System.ComponentModel.ISupportInitialize)dtgRecordatorio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgRecordatorio;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}