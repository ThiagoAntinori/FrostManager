namespace UI
{
    partial class LoginForm
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
            txtCorreo = new TextBox();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(66, 50);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Correo electronico";
            txtCorreo.Size = new Size(230, 23);
            txtCorreo.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(66, 97);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Contraseña";
            txtPassword.Size = new Size(230, 23);
            txtPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(231, 164);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(371, 212);
            Controls.Add(btnIngresar);
            Controls.Add(txtPassword);
            Controls.Add(txtCorreo);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCorreo;
        private TextBox txtPassword;
        private Button btnIngresar;
    }
}
