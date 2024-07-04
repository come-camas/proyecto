namespace Gestion_Agricola
{
    partial class VerAlmacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerAlmacenes));
            dtgAlmacenes = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            cbx = new CheckBox();
            textBox2 = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgAlmacenes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dtgAlmacenes
            // 
            dtgAlmacenes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgAlmacenes.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dtgAlmacenes.Location = new Point(12, 112);
            dtgAlmacenes.Name = "dtgAlmacenes";
            dtgAlmacenes.RowHeadersWidth = 51;
            dtgAlmacenes.RowTemplate.Height = 29;
            dtgAlmacenes.Size = new Size(822, 503);
            dtgAlmacenes.TabIndex = 1;
            dtgAlmacenes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 170;
            // 
            // Column3
            // 
            Column3.HeaderText = "Cantidad";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Ult. Modificacion";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 51);
            label1.Name = "label1";
            label1.Size = new Size(41, 34);
            label1.TabIndex = 2;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(64, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 30);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(211, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(33, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // cbx
            // 
            cbx.AutoSize = true;
            cbx.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbx.Location = new Point(627, 52);
            cbx.Name = "cbx";
            cbx.Size = new Size(207, 38);
            cbx.TabIndex = 5;
            cbx.Text = "En Existencia";
            cbx.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(389, 56);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 30);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(267, 52);
            label2.Name = "label2";
            label2.Size = new Size(116, 34);
            label2.TabIndex = 7;
            label2.Text = "Nombre";
            // 
            // VerAlmacenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 627);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(cbx);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dtgAlmacenes);
            Name = "VerAlmacenes";
            Text = "VerAlmacenes";
            Load += VerAlmacenes_Load;
            ((System.ComponentModel.ISupportInitialize)dtgAlmacenes).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgAlmacenes;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private CheckBox cbx;
        private TextBox textBox2;
        private Label label2;
    }
}