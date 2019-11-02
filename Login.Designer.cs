namespace Examen2Parcial
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.correoLogin = new System.Windows.Forms.TextBox();
            this.contraseñaLogin = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.irARegistro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // correoLogin
            // 
            this.correoLogin.Location = new System.Drawing.Point(200, 40);
            this.correoLogin.Name = "correoLogin";
            this.correoLogin.Size = new System.Drawing.Size(100, 20);
            this.correoLogin.TabIndex = 2;
            // 
            // contraseñaLogin
            // 
            this.contraseñaLogin.Location = new System.Drawing.Point(200, 82);
            this.contraseñaLogin.Name = "contraseñaLogin";
            this.contraseñaLogin.Size = new System.Drawing.Size(100, 20);
            this.contraseñaLogin.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(161, 117);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(75, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // irARegistro
            // 
            this.irARegistro.Location = new System.Drawing.Point(225, 164);
            this.irARegistro.Name = "irARegistro";
            this.irARegistro.Size = new System.Drawing.Size(75, 23);
            this.irARegistro.TabIndex = 5;
            this.irARegistro.Text = "Registrate!";
            this.irARegistro.UseVisualStyleBackColor = true;
            this.irARegistro.Click += new System.EventHandler(this.IrARegistro_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "¿Aún no tienes una cuenta?";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 220);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.irARegistro);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.contraseñaLogin);
            this.Controls.Add(this.correoLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox correoLogin;
        private System.Windows.Forms.TextBox contraseñaLogin;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button irARegistro;
        private System.Windows.Forms.Label label3;
    }
}