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
            nivelPrioridad = new DataGridViewTextBoxColumn();
            Detalles = new DataGridViewTextBoxColumn();
            estado_Tarea = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { fechaI, nivelPrioridad, Detalles, estado_Tarea, Descripcion });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(691, 228);
            dataGridView1.TabIndex = 1;
            // 
            // fechaI
            // 
            fechaI.HeaderText = "Dias";
            fechaI.Name = "fechaI";
            fechaI.ReadOnly = true;
            fechaI.Resizable = DataGridViewTriState.False;
            // 
            // nivelPrioridad
            // 
            nivelPrioridad.HeaderText = "nivel_Prioridad";
            nivelPrioridad.Name = "nivelPrioridad";
            nivelPrioridad.ReadOnly = true;
            nivelPrioridad.Resizable = DataGridViewTriState.False;
            // 
            // Detalles
            // 
            Detalles.HeaderText = "Detalles";
            Detalles.Name = "Detalles";
            Detalles.ReadOnly = true;
            Detalles.Resizable = DataGridViewTriState.False;
            Detalles.Width = 150;
            // 
            // estado_Tarea
            // 
            estado_Tarea.HeaderText = "Estado Tarea";
            estado_Tarea.Name = "estado_Tarea";
            estado_Tarea.ReadOnly = true;
            estado_Tarea.Resizable = DataGridViewTriState.False;
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion Tarea";
            Descripcion.Name = "Descripcion";
            Descripcion.ReadOnly = true;
            Descripcion.Resizable = DataGridViewTriState.False;
            Descripcion.Width = 200;
            // 
            // Calendario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 470);
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
        private DataGridViewTextBoxColumn nivelPrioridad;
        private DataGridViewTextBoxColumn Detalles;
        private DataGridViewTextBoxColumn estado_Tarea;
        private DataGridViewTextBoxColumn Descripcion;
    }
}