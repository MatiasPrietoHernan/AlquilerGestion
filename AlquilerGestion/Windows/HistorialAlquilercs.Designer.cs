﻿namespace AlquilerGestion.Windows
{
    partial class HistorialAlquilercs
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
            button4 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(46, 99);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(538, 283);
            dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(282, 9);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 1;
            label1.Text = "Alquileres";
            // 
            // button1
            // 
            button1.Location = new Point(637, 99);
            button1.Name = "button1";
            button1.Size = new Size(110, 47);
            button1.TabIndex = 2;
            button1.Text = "Eliminar Alquiler";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(637, 179);
            button2.Name = "button2";
            button2.Size = new Size(110, 47);
            button2.TabIndex = 2;
            button2.Text = "Editar Alquiler";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(637, 256);
            button3.Name = "button3";
            button3.Size = new Size(110, 47);
            button3.TabIndex = 2;
            button3.Text = "Registrar Alquiler";
            button3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(69, 390);
            label2.Name = "label2";
            label2.Size = new Size(83, 21);
            label2.TabIndex = 3;
            label2.Text = "ID Alquiler";
            // 
            // button4
            // 
            button4.Location = new Point(305, 58);
            button4.Name = "button4";
            button4.Size = new Size(80, 35);
            button4.TabIndex = 4;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 392);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(59, 63);
            label3.Name = "label3";
            label3.Size = new Size(114, 21);
            label3.TabIndex = 3;
            label3.Text = "Buscar Alquiler";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(179, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // HistorialAlquilercs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "HistorialAlquilercs";
            Text = "HistorialAlquilercs";
            Load += HistorialAlquilercs_Load;
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
        private Button button4;
        private TextBox textBox1;
        private Label label3;
        private TextBox textBox2;
    }
}