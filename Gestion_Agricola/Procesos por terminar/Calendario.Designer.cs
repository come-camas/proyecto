namespace Gestion_Agricola
{
    partial class Calendario
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
            dataGridView1 = new DataGridView();
            fechaI = new DataGridViewTextBoxColumn();
            Nivel_P = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            des_tar = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaI, Nivel_P, Descripcion, des_tar, Column1 });
            dataGridView1.Location = new Point(12, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(746, 228);
            dataGridView1.TabIndex = 1;
            // 
            // fechaI
            // 
            fechaI.HeaderText = "Fecha Emision";
            fechaI.Name = "fechaI";
            fechaI.ReadOnly = true;
            fechaI.Resizable = DataGridViewTriState.False;
            // 
            // Nivel_P
            // 
            Nivel_P.HeaderText = "Nivel P";
            Nivel_P.Name = "Nivel_P";
            Nivel_P.ReadOnly = true;
            Nivel_P.Resizable = DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Nom Tarea";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = DataGridViewTriState.False;
            // 
            // des_tar
            // 
            des_tar.HeaderText = "Descripcion Tarea";
            des_tar.Name = "des_tar";
            des_tar.ReadOnly = true;
            des_tar.Width = 300;
            // 
            // Column1
            // 
            Column1.HeaderText = "Fecha Cancelacion";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Calendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 470);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Calendario";
            Text = "Calendario";
            Load += Calendario_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn fechaI;
        private DataGridViewTextBoxColumn Nivel_P;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn des_tar;
        private DataGridViewTextBoxColumn Column1;
    }
}