namespace AlquilerGestion
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            deptoDisp = new Label();
            panel2 = new Panel();
            label3 = new Label();
            deptoOcup = new Label();
            panel3 = new Panel();
            label5 = new Label();
            inquilinosReg = new Label();
            panel4 = new Panel();
            label4 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            inquilinosToolStripMenuItem = new ToolStripMenuItem();
            departamentosToolStripMenuItem = new ToolStripMenuItem();
            historialDeAlquilerToolStripMenuItem = new ToolStripMenuItem();
            pagosToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 0;
            label1.Text = "Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(deptoDisp);
            panel1.Location = new Point(612, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 100);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(36, 26);
            label2.Name = "label2";
            label2.Size = new Size(202, 21);
            label2.TabIndex = 2;
            label2.Text = "Departamentos Disponibles";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // deptoDisp
            // 
            deptoDisp.AutoSize = true;
            deptoDisp.Font = new Font("Segoe UI", 14F);
            deptoDisp.ForeColor = Color.LawnGreen;
            deptoDisp.Location = new Point(133, 60);
            deptoDisp.Name = "deptoDisp";
            deptoDisp.Size = new Size(0, 25);
            deptoDisp.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(deptoOcup);
            panel2.Location = new Point(612, 164);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 100);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(36, 26);
            label3.Name = "label3";
            label3.Size = new Size(191, 21);
            label3.TabIndex = 2;
            label3.Text = "Departamentos Ocupados";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // deptoOcup
            // 
            deptoOcup.AutoSize = true;
            deptoOcup.Font = new Font("Segoe UI", 14F);
            deptoOcup.ForeColor = Color.Red;
            deptoOcup.Location = new Point(133, 61);
            deptoOcup.Name = "deptoOcup";
            deptoOcup.Size = new Size(0, 25);
            deptoOcup.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.AppWorkspace;
            panel3.Controls.Add(label5);
            panel3.Controls.Add(inquilinosReg);
            panel3.Location = new Point(612, 282);
            panel3.Name = "panel3";
            panel3.Size = new Size(280, 100);
            panel3.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(36, 26);
            label5.Name = "label5";
            label5.Size = new Size(164, 21);
            label5.TabIndex = 2;
            label5.Text = "Inquilinos Registrados";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // inquilinosReg
            // 
            inquilinosReg.AutoSize = true;
            inquilinosReg.Font = new Font("Segoe UI", 14F);
            inquilinosReg.ForeColor = Color.DarkOrange;
            inquilinosReg.Location = new Point(133, 61);
            inquilinosReg.Name = "inquilinosReg";
            inquilinosReg.Size = new Size(0, 25);
            inquilinosReg.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.AppWorkspace;
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(612, 411);
            panel4.Name = "panel4";
            panel4.Size = new Size(280, 100);
            panel4.TabIndex = 1;
            panel4.Paint += panel4_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(36, 26);
            label4.Name = "label4";
            label4.Size = new Size(112, 21);
            label4.TabIndex = 2;
            label4.Text = "Deudas totales";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.ForeColor = Color.Crimson;
            label6.Location = new Point(133, 61);
            label6.Name = "label6";
            label6.Size = new Size(0, 25);
            label6.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ControlDark;
            panel5.Controls.Add(button1);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(dataGridView1);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(12, 44);
            panel5.Name = "panel5";
            panel5.Size = new Size(582, 467);
            panel5.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(308, 25);
            button1.Name = "button1";
            button1.Size = new Size(89, 32);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(50, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(480, 340);
            dataGridView1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(41, 26);
            label7.Name = "label7";
            label7.Size = new Size(155, 25);
            label7.TabIndex = 0;
            label7.Text = "Busqueda Global";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { inquilinosToolStripMenuItem, departamentosToolStripMenuItem, historialDeAlquilerToolStripMenuItem, pagosToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(931, 29);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // inquilinosToolStripMenuItem
            // 
            inquilinosToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inquilinosToolStripMenuItem.Name = "inquilinosToolStripMenuItem";
            inquilinosToolStripMenuItem.Size = new Size(99, 25);
            inquilinosToolStripMenuItem.Text = "Inquilinos";
            inquilinosToolStripMenuItem.Click += inquilinosToolStripMenuItem_Click;
            // 
            // departamentosToolStripMenuItem
            // 
            departamentosToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            departamentosToolStripMenuItem.Size = new Size(140, 25);
            departamentosToolStripMenuItem.Text = "Departamentos";
            departamentosToolStripMenuItem.Click += departamentosToolStripMenuItem_Click;
            // 
            // historialDeAlquilerToolStripMenuItem
            // 
            historialDeAlquilerToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            historialDeAlquilerToolStripMenuItem.Name = "historialDeAlquilerToolStripMenuItem";
            historialDeAlquilerToolStripMenuItem.Size = new Size(175, 25);
            historialDeAlquilerToolStripMenuItem.Text = "Historial de Alquiler";
            historialDeAlquilerToolStripMenuItem.Click += historialDeAlquilerToolStripMenuItem_Click;
            // 
            // pagosToolStripMenuItem
            // 
            pagosToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            pagosToolStripMenuItem.Size = new Size(68, 25);
            pagosToolStripMenuItem.Text = "Pagos";
            pagosToolStripMenuItem.Click += pagosToolStripMenuItem_Click;
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(89, 25);
            reportesToolStripMenuItem.Text = "Reportes";
            reportesToolStripMenuItem.Click += reportesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 533);
            Controls.Add(menuStrip1);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label deptoDisp;
        private Panel panel2;
        private Label label3;
        private Label deptoOcup;
        private Panel panel3;
        private Label label5;
        private Label inquilinosReg;
        private Panel panel4;
        private Label label4;
        private Label label6;
        private Panel panel5;
        private DataGridView dataGridView1;
        private Label label7;
        private Button button1;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inquilinosToolStripMenuItem;
        private ToolStripMenuItem departamentosToolStripMenuItem;
        private ToolStripMenuItem historialDeAlquilerToolStripMenuItem;
        private ToolStripMenuItem pagosToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}
