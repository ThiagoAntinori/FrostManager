namespace UI
{
    partial class RecuperarContraseñaForm
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
            lblIngresarNombreUsuario = new Label();
            txtNombreUsuario = new TextBox();
            btnEnviarToken = new Button();
            label1 = new Label();
            txtToken = new TextBox();
            btnIngresar = new Button();
            SuspendLayout();
            // 
            // lblIngresarNombreUsuario
            // 
            lblIngresarNombreUsuario.AutoSize = true;
            lblIngresarNombreUsuario.Location = new Point(38, 30);
            lblIngresarNombreUsuario.Name = "lblIngresarNombreUsuario";
            lblIngresarNombreUsuario.Size = new Size(166, 15);
            lblIngresarNombreUsuario.TabIndex = 0;
            lblIngresarNombreUsuario.Text = "Ingrese su nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(38, 48);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(219, 23);
            txtNombreUsuario.TabIndex = 1;
            // 
            // btnEnviarToken
            // 
            btnEnviarToken.Location = new Point(288, 47);
            btnEnviarToken.Name = "btnEnviarToken";
            btnEnviarToken.Size = new Size(89, 23);
            btnEnviarToken.TabIndex = 2;
            btnEnviarToken.Text = "Enviar Token";
            btnEnviarToken.UseVisualStyleBackColor = true;
            btnEnviarToken.Click += btnEnviarToken_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 114);
            label1.Name = "label1";
            label1.Size = new Size(168, 15);
            label1.TabIndex = 3;
            label1.Text = "Ingrese el Token de validación:";
            // 
            // txtToken
            // 
            txtToken.Location = new Point(38, 132);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(219, 23);
            txtToken.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(288, 132);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(89, 23);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // RecuperarContraseñaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 205);
            Controls.Add(btnIngresar);
            Controls.Add(txtToken);
            Controls.Add(label1);
            Controls.Add(btnEnviarToken);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblIngresarNombreUsuario);
            Name = "RecuperarContraseñaForm";
            Text = "RecuperarContraseñaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngresarNombreUsuario;
        private TextBox txtNombreUsuario;
        private Button btnEnviarToken;
        private Label label1;
        private TextBox txtToken;
        private Button btnIngresar;
    }
}