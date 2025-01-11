namespace AlquilerGestion.SecondWindows
{
    partial class FormInquilinos
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textNombre = new TextBox();
            textDni = new TextBox();
            textCorreo = new TextBox();
            textTelefono = new TextBox();
            button1 = new Button();
            label6 = new Label();
            textId = new TextBox();
            label2 = new Label();
            textDireccion = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(32, 69);
            label1.Name = "label1";
            label1.Size = new Size(140, 21);
            label1.TabIndex = 0;
            label1.Text = "Nombre Completo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(82, 109);
            label3.Name = "label3";
            label3.Size = new Size(37, 21);
            label3.TabIndex = 0;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(82, 151);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 0;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(82, 193);
            label5.Name = "label5";
            label5.Size = new Size(68, 21);
            label5.TabIndex = 0;
            label5.Text = "Telefono";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(177, 71);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(100, 23);
            textNombre.TabIndex = 1;
            // 
            // textDni
            // 
            textDni.Location = new Point(177, 111);
            textDni.Name = "textDni";
            textDni.Size = new Size(100, 23);
            textDni.TabIndex = 1;
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(177, 153);
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(100, 23);
            textCorreo.TabIndex = 1;
            // 
            // textTelefono
            // 
            textTelefono.Location = new Point(177, 195);
            textTelefono.Name = "textTelefono";
            textTelefono.Size = new Size(100, 23);
            textTelefono.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(177, 275);
            button1.Name = "button1";
            button1.Size = new Size(78, 44);
            button1.TabIndex = 2;
            button1.Text = "Hecho";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(82, 29);
            label6.Name = "label6";
            label6.Size = new Size(90, 21);
            label6.TabIndex = 0;
            label6.Text = "ID Inquilino";
            // 
            // textId
            // 
            textId.Location = new Point(177, 31);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(100, 23);
            textId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(82, 234);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 0;
            label2.Text = "Direccion";
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(177, 236);
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(100, 23);
            textDireccion.TabIndex = 1;
            // 
            // FormInquilinos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 363);
            Controls.Add(button1);
            Controls.Add(textDireccion);
            Controls.Add(textTelefono);
            Controls.Add(textCorreo);
            Controls.Add(textDni);
            Controls.Add(textId);
            Controls.Add(label2);
            Controls.Add(textNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "FormInquilinos";
            Text = "FormInquilinos";
            Load += FormInquilinos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNombre;
        private TextBox textDni;
        private TextBox textCorreo;
        private TextBox textTelefono;
        private Button button1;
        private Label label6;
        private TextBox textId;
        private Label label2;
        private TextBox textDireccion;
    }
}