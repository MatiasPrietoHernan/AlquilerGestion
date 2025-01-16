namespace AlquilerGestion.Windows
{
    partial class Departamentos
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
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            IdTxt = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(566, 315);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 1;
            label1.Text = "Departamentos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(44, 429);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 1;
            label2.Text = "ID Departamento: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(208, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(27, 54);
            label3.Name = "label3";
            label3.Size = new Size(160, 21);
            label3.TabIndex = 1;
            label3.Text = "Buscar Departamento";
            // 
            // button1
            // 
            button1.Location = new Point(330, 54);
            button1.Name = "button1";
            button1.Size = new Size(85, 26);
            button1.TabIndex = 3;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // IdTxt
            // 
            IdTxt.Location = new Point(186, 429);
            IdTxt.Name = "IdTxt";
            IdTxt.Size = new Size(100, 23);
            IdTxt.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(636, 112);
            button2.Name = "button2";
            button2.Size = new Size(105, 47);
            button2.TabIndex = 4;
            button2.Text = "Agregar nuevo Departamento";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(636, 180);
            button3.Name = "button3";
            button3.Size = new Size(105, 47);
            button3.TabIndex = 4;
            button3.Text = "Editar Departamento";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(636, 250);
            button4.Name = "button4";
            button4.Size = new Size(105, 47);
            button4.TabIndex = 4;
            button4.Text = "Eliminar Departamento";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Departamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 479);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(IdTxt);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Departamentos";
            Text = "Departamentos";
            Load += Departamentos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button1;
        private TextBox IdTxt;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}