namespace UI.Administrative_Forms
{
    partial class RegistrarUsuarioForm
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
            lblDatosUsuario = new Label();
            label1 = new Label();
            label2 = new Label();
            txtNombreUsuario = new TextBox();
            txtCorreoElectronico = new TextBox();
            lblRol = new Label();
            cmbRol = new ComboBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.Anchor = AnchorStyles.None;
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblDatosUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblDatosUsuario.Location = new Point(172, 76);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(187, 19);
            lblDatosUsuario.TabIndex = 0;
            lblDatosUsuario.Text = "Ingrese los datos del usuario:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 9.75F);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(172, 127);
            label1.Name = "label1";
            label1.Size = new Size(131, 19);
            label1.TabIndex = 1;
            label1.Text = "Nombre de usuario:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 9.75F);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(172, 194);
            label2.Name = "label2";
            label2.Size = new Size(126, 19);
            label2.TabIndex = 2;
            label2.Text = "Correo electrónico:";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Anchor = AnchorStyles.None;
            txtNombreUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtNombreUsuario.ForeColor = SystemColors.ActiveCaptionText;
            txtNombreUsuario.Location = new Point(172, 149);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(252, 24);
            txtNombreUsuario.TabIndex = 3;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Anchor = AnchorStyles.None;
            txtCorreoElectronico.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtCorreoElectronico.ForeColor = SystemColors.ActiveCaptionText;
            txtCorreoElectronico.Location = new Point(172, 216);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(252, 24);
            txtCorreoElectronico.TabIndex = 4;
            // 
            // lblRol
            // 
            lblRol.Anchor = AnchorStyles.None;
            lblRol.AutoSize = true;
            lblRol.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblRol.ForeColor = SystemColors.ActiveCaptionText;
            lblRol.Location = new Point(172, 267);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(182, 19);
            lblRol.TabIndex = 5;
            lblRol.Text = "Seleccione el rol del usuario:";
            // 
            // cmbRol
            // 
            cmbRol.Anchor = AnchorStyles.None;
            cmbRol.Font = new Font("Microsoft YaHei UI", 9.75F);
            cmbRol.ForeColor = SystemColors.ActiveCaptionText;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(172, 289);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(252, 27);
            cmbRol.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnRegistrar.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrar.Location = new Point(318, 350);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 31);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.Brown;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnSalir.Location = new Point(490, 31);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 27);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // RegistrarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbRol);
            Controls.Add(lblRol);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtNombreUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblDatosUsuario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarUsuarioForm";
            Text = "RegistrarUsuarioForm";
            Load += RegistrarUsuarioForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosUsuario;
        private Label label1;
        private Label label2;
        private TextBox txtNombreUsuario;
        private TextBox txtCorreoElectronico;
        private Label lblRol;
        private ComboBox cmbRol;
        private Button btnRegistrar;
        private Button btnSalir;
    }
}