namespace HolaMundo
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
            txtContrasenaUno = new TextBox();
            txtContrasenaDos = new TextBox();
            btnValidar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtContrasenaUno
            // 
            txtContrasenaUno.Location = new Point(165, 54);
            txtContrasenaUno.Name = "txtContrasenaUno";
            txtContrasenaUno.Size = new Size(217, 23);
            txtContrasenaUno.TabIndex = 0;
            // 
            // txtContrasenaDos
            // 
            txtContrasenaDos.Location = new Point(165, 106);
            txtContrasenaDos.Name = "txtContrasenaDos";
            txtContrasenaDos.Size = new Size(216, 23);
            txtContrasenaDos.TabIndex = 1;
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(165, 159);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 57);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 4;
            label1.Text = "Ingrese contraseña";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(46, 109);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 5;
            label2.Text = "Repita la contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 215);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnValidar);
            Controls.Add(txtContrasenaDos);
            Controls.Add(txtContrasenaUno);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContrasenaUno;
        private TextBox txtContrasenaDos;
        private Button btnValidar;
        private Label label1;
        private Label label2;
    }
}