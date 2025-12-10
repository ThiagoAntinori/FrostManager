using Org.BouncyCastle.Asn1.Crmf;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecuperarContraseñaForm));
            panelSolicitarToken = new Panel();
            btnSolicitarToken = new Button();
            txtUsuarioSolicitud = new TextBox();
            lblTituloSolicitud = new Label();
            lblUsuarioSolicitud = new Label();
            panelRestablecer = new Panel();
            btnRestablecerContrasena = new Button();
            txtConfirmarNuevaPassword = new TextBox();
            lblConfirmarNuevaPassword = new Label();
            txtNuevaPassword = new TextBox();
            lblNuevaPassword = new Label();
            txtToken = new TextBox();
            lblToken = new Label();
            lblTituloRestablecer = new Label();
            btnCerrar = new Button();
            panelSolicitarToken.SuspendLayout();
            panelRestablecer.SuspendLayout();
            SuspendLayout();
            // 
            // panelSolicitarToken
            // 
            panelSolicitarToken.Anchor = AnchorStyles.None;
            panelSolicitarToken.BorderStyle = BorderStyle.FixedSingle;
            panelSolicitarToken.Controls.Add(btnSolicitarToken);
            panelSolicitarToken.Controls.Add(txtUsuarioSolicitud);
            panelSolicitarToken.Controls.Add(lblTituloSolicitud);
            panelSolicitarToken.Controls.Add(lblUsuarioSolicitud);
            panelSolicitarToken.Location = new Point(20, 40);
            panelSolicitarToken.Name = "panelSolicitarToken";
            panelSolicitarToken.Size = new Size(300, 120);
            panelSolicitarToken.TabIndex = 0;
            // 
            // btnSolicitarToken
            // 
            btnSolicitarToken.Anchor = AnchorStyles.None;
            btnSolicitarToken.BackColor = Color.LightBlue;
            btnSolicitarToken.Location = new Point(195, 78);
            btnSolicitarToken.Name = "btnSolicitarToken";
            btnSolicitarToken.Size = new Size(95, 30);
            btnSolicitarToken.TabIndex = 2;
            btnSolicitarToken.Text = "Solicitar Token";
            btnSolicitarToken.UseVisualStyleBackColor = false;
            btnSolicitarToken.Click += btnSolicitarToken_Click;
            // 
            // txtUsuarioSolicitud
            // 
            txtUsuarioSolicitud.Anchor = AnchorStyles.None;
            txtUsuarioSolicitud.Location = new Point(15, 49);
            txtUsuarioSolicitud.Name = "txtUsuarioSolicitud";
            txtUsuarioSolicitud.Size = new Size(275, 23);
            txtUsuarioSolicitud.TabIndex = 1;
            // 
            // lblTituloSolicitud
            // 
            lblTituloSolicitud.Anchor = AnchorStyles.None;
            lblTituloSolicitud.AutoSize = true;
            lblTituloSolicitud.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloSolicitud.Location = new Point(12, 5);
            lblTituloSolicitud.Name = "lblTituloSolicitud";
            lblTituloSolicitud.Size = new Size(106, 16);
            lblTituloSolicitud.TabIndex = 0;
            lblTituloSolicitud.Text = "Solicitar Token:";
            // 
            // lblUsuarioSolicitud
            // 
            lblUsuarioSolicitud.Anchor = AnchorStyles.None;
            lblUsuarioSolicitud.AutoSize = true;
            lblUsuarioSolicitud.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuarioSolicitud.Location = new Point(12, 29);
            lblUsuarioSolicitud.Name = "lblUsuarioSolicitud";
            lblUsuarioSolicitud.Size = new Size(188, 17);
            lblUsuarioSolicitud.TabIndex = 3;
            lblUsuarioSolicitud.Text = "Nombre de usuario o Email:";
            // 
            // panelRestablecer
            // 
            panelRestablecer.Anchor = AnchorStyles.None;
            panelRestablecer.BorderStyle = BorderStyle.FixedSingle;
            panelRestablecer.Controls.Add(btnRestablecerContrasena);
            panelRestablecer.Controls.Add(txtConfirmarNuevaPassword);
            panelRestablecer.Controls.Add(lblConfirmarNuevaPassword);
            panelRestablecer.Controls.Add(txtNuevaPassword);
            panelRestablecer.Controls.Add(lblNuevaPassword);
            panelRestablecer.Controls.Add(txtToken);
            panelRestablecer.Controls.Add(lblToken);
            panelRestablecer.Controls.Add(lblTituloRestablecer);
            panelRestablecer.Location = new Point(20, 168);
            panelRestablecer.Name = "panelRestablecer";
            panelRestablecer.Size = new Size(300, 150);
            panelRestablecer.TabIndex = 1;
            // 
            // btnRestablecerContrasena
            // 
            btnRestablecerContrasena.Anchor = AnchorStyles.None;
            btnRestablecerContrasena.BackColor = Color.LightBlue;
            btnRestablecerContrasena.Location = new Point(195, 115);
            btnRestablecerContrasena.Name = "btnRestablecerContrasena";
            btnRestablecerContrasena.Size = new Size(95, 30);
            btnRestablecerContrasena.TabIndex = 6;
            btnRestablecerContrasena.Text = "Restablecer";
            btnRestablecerContrasena.UseVisualStyleBackColor = false;
            btnRestablecerContrasena.Click += btnRestablecerContrasena_Click;
            // 
            // txtConfirmarNuevaPassword
            // 
            txtConfirmarNuevaPassword.Anchor = AnchorStyles.None;
            txtConfirmarNuevaPassword.Location = new Point(148, 86);
            txtConfirmarNuevaPassword.Name = "txtConfirmarNuevaPassword";
            txtConfirmarNuevaPassword.Size = new Size(142, 23);
            txtConfirmarNuevaPassword.TabIndex = 5;
            txtConfirmarNuevaPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmarNuevaPassword
            // 
            lblConfirmarNuevaPassword.Anchor = AnchorStyles.None;
            lblConfirmarNuevaPassword.AutoSize = true;
            lblConfirmarNuevaPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmarNuevaPassword.Location = new Point(148, 66);
            lblConfirmarNuevaPassword.Name = "lblConfirmarNuevaPassword";
            lblConfirmarNuevaPassword.Size = new Size(157, 17);
            lblConfirmarNuevaPassword.TabIndex = 7;
            lblConfirmarNuevaPassword.Text = "Confirmar Contraseña:";
            // 
            // txtNuevaPassword
            // 
            txtNuevaPassword.Anchor = AnchorStyles.None;
            txtNuevaPassword.Location = new Point(12, 86);
            txtNuevaPassword.Name = "txtNuevaPassword";
            txtNuevaPassword.Size = new Size(130, 23);
            txtNuevaPassword.TabIndex = 4;
            txtNuevaPassword.UseSystemPasswordChar = true;
            // 
            // lblNuevaPassword
            // 
            lblNuevaPassword.Anchor = AnchorStyles.None;
            lblNuevaPassword.AutoSize = true;
            lblNuevaPassword.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNuevaPassword.Location = new Point(12, 66);
            lblNuevaPassword.Name = "lblNuevaPassword";
            lblNuevaPassword.Size = new Size(135, 17);
            lblNuevaPassword.TabIndex = 6;
            lblNuevaPassword.Text = "Nueva Contraseña:";
            // 
            // txtToken
            // 
            txtToken.Anchor = AnchorStyles.None;
            txtToken.Location = new Point(148, 38);
            txtToken.Name = "txtToken";
            txtToken.Size = new Size(142, 23);
            txtToken.TabIndex = 3;
            // 
            // lblToken
            // 
            lblToken.Anchor = AnchorStyles.None;
            lblToken.AutoSize = true;
            lblToken.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblToken.Location = new Point(148, 18);
            lblToken.Name = "lblToken";
            lblToken.Size = new Size(110, 17);
            lblToken.TabIndex = 5;
            lblToken.Text = "Token Recibido:";
            // 
            // lblTituloRestablecer
            // 
            lblTituloRestablecer.Anchor = AnchorStyles.None;
            lblTituloRestablecer.AutoSize = true;
            lblTituloRestablecer.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloRestablecer.Location = new Point(12, 5);
            lblTituloRestablecer.Name = "lblTituloRestablecer";
            lblTituloRestablecer.Size = new Size(247, 16);
            lblTituloRestablecer.TabIndex = 4;
            lblTituloRestablecer.Text = "Restablecer Contraseña (con Token):";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.BackColor = Color.IndianRed;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(312, 5);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(27, 27);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            // 
            // RecuperarContraseñaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(344, 331);
            Controls.Add(btnCerrar);
            Controls.Add(panelRestablecer);
            Controls.Add(panelSolicitarToken);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(360, 370);
            Name = "RecuperarContraseñaForm";
            Text = "RECUPERAR CONTRASEÑA";
            panelSolicitarToken.ResumeLayout(false);
            panelSolicitarToken.PerformLayout();
            panelRestablecer.ResumeLayout(false);
            panelRestablecer.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSolicitarToken;
        private Label lblTituloSolicitud;
        private TextBox txtUsuarioSolicitud;
        private Button btnSolicitarToken;
        private Panel panelRestablecer;
        private Label lblTituloRestablecer;
        private TextBox txtToken;
        private Label lblToken;
        private TextBox txtConfirmarNuevaPassword;
        private Label lblConfirmarNuevaPassword;
        private TextBox txtNuevaPassword;
        private Label lblNuevaPassword;
        private Button btnRestablecerContrasena;
        private Button btnCerrar;
        private Label lblUsuarioSolicitud;
    }
}