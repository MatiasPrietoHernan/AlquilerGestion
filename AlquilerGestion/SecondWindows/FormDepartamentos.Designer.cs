namespace AlquilerGestion.SecondWindows
{
    partial class FormDepartamentos
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            nombreTxt = new TextBox();
            materialesTxt = new TextBox();
            dimensionesTxt = new TextBox();
            accesoriosTxt = new TextBox();
            Idtxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(33, 73);
            label1.Name = "label1";
            label1.Size = new Size(160, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre/Numeración";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(33, 122);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 0;
            label2.Text = "Materiales";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(33, 169);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 0;
            label3.Text = "Dimensiones";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(33, 224);
            label4.Name = "label4";
            label4.Size = new Size(84, 21);
            label4.TabIndex = 0;
            label4.Text = "Accesorios";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(33, 21);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 0;
            label5.Text = "ID Departamento";
            // 
            // nombreTxt
            // 
            nombreTxt.Location = new Point(199, 75);
            nombreTxt.Name = "nombreTxt";
            nombreTxt.Size = new Size(100, 23);
            nombreTxt.TabIndex = 1;
            // 
            // materialesTxt
            // 
            materialesTxt.Location = new Point(199, 124);
            materialesTxt.Name = "materialesTxt";
            materialesTxt.Size = new Size(100, 23);
            materialesTxt.TabIndex = 1;
            // 
            // dimensionesTxt
            // 
            dimensionesTxt.Location = new Point(199, 171);
            dimensionesTxt.Name = "dimensionesTxt";
            dimensionesTxt.Size = new Size(100, 23);
            dimensionesTxt.TabIndex = 1;
            // 
            // accesoriosTxt
            // 
            accesoriosTxt.Location = new Point(199, 226);
            accesoriosTxt.Name = "accesoriosTxt";
            accesoriosTxt.Size = new Size(100, 23);
            accesoriosTxt.TabIndex = 1;
            // 
            // Idtxt
            // 
            Idtxt.Location = new Point(199, 23);
            Idtxt.Name = "Idtxt";
            Idtxt.ReadOnly = true;
            Idtxt.Size = new Size(100, 23);
            Idtxt.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(159, 286);
            button1.Name = "button1";
            button1.Size = new Size(92, 44);
            button1.TabIndex = 2;
            button1.Text = "Hecho";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(440, 373);
            Controls.Add(button1);
            Controls.Add(accesoriosTxt);
            Controls.Add(dimensionesTxt);
            Controls.Add(materialesTxt);
            Controls.Add(Idtxt);
            Controls.Add(nombreTxt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "FormDepartamentos";
            Text = "FormDepartamentos";
            Load += FormDepartamentos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox nombreTxt;
        private TextBox materialesTxt;
        private TextBox dimensionesTxt;
        private TextBox accesoriosTxt;
        private TextBox Idtxt;
        private Button button1;
    }
}