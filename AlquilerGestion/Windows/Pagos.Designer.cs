﻿namespace AlquilerGestion.Windows
{
    partial class Pagos
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
            label2 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 98);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(645, 300);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(354, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 1;
            label1.Text = "Pagos";
            // 
            // button1
            // 
            button1.Location = new Point(726, 98);
            button1.Name = "button1";
            button1.Size = new Size(100, 62);
            button1.TabIndex = 2;
            button1.Text = "Registrar nuevo pago";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(59, 58);
            label2.Name = "label2";
            label2.Size = new Size(125, 21);
            label2.TabIndex = 1;
            label2.Text = "Historial Pagos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(227, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(335, 60);
            button2.Name = "button2";
            button2.Size = new Size(95, 23);
            button2.TabIndex = 4;
            button2.Text = "Buscar Fecha";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(726, 185);
            button3.Name = "button3";
            button3.Size = new Size(100, 62);
            button3.TabIndex = 2;
            button3.Text = "Filtrar por deudores";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(726, 336);
            button4.Name = "button4";
            button4.Size = new Size(100, 62);
            button4.TabIndex = 2;
            button4.Text = "Filtrar por métodos de pago";
            button4.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(714, 292);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // Pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 489);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "Pagos";
            Text = "Pagos";
            Load += Pagos_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
        private Label label2;
        private TextBox textBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox comboBox1;
    }
}