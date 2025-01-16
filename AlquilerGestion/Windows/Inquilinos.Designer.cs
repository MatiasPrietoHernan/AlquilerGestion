namespace AlquilerGestion.Windows
{
    partial class Inquilinos
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            textId = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(499, 270);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(261, 9);
            label1.Name = "label1";
            label1.Size = new Size(149, 21);
            label1.TabIndex = 1;
            label1.Text = "Lista de Inquilinos";
            // 
            // button1
            // 
            button1.Location = new Point(579, 107);
            button1.Name = "button1";
            button1.Size = new Size(113, 49);
            button1.TabIndex = 2;
            button1.Text = "Agregar Inquilino";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(579, 192);
            button2.Name = "button2";
            button2.Size = new Size(113, 49);
            button2.TabIndex = 2;
            button2.Text = "Editar Inquilino";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(579, 283);
            button3.Name = "button3";
            button3.Size = new Size(113, 49);
            button3.TabIndex = 2;
            button3.Text = "Eliminar Inquilino";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(71, 385);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 3;
            label2.Text = "ID Inquilino";
            // 
            // textId
            // 
            textId.Location = new Point(167, 383);
            textId.Name = "textId";
            textId.Size = new Size(100, 23);
            textId.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(133, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(71, 55);
            label3.Name = "label3";
            label3.Size = new Size(56, 21);
            label3.TabIndex = 6;
            label3.Text = "Buscar";
            // 
            // button4
            // 
            button4.Location = new Point(251, 56);
            button4.Name = "button4";
            button4.Size = new Size(103, 23);
            button4.TabIndex = 7;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // Inquilinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 472);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textId);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Inquilinos";
            Text = "Inquilinos";
            Load += Inquilinos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private TextBox textId;
        private TextBox textBox2;
        private Label label3;
        private Button button4;
    }
}