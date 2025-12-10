namespace UI.Primary_Forms
{
    partial class RegistrarRepartidorForm
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
            lblDatosRepartidor = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            SuspendLayout();
            // 
            // lblDatosRepartidor
            // 
            lblDatosRepartidor.Anchor = AnchorStyles.None;
            lblDatosRepartidor.AutoSize = true;
            lblDatosRepartidor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosRepartidor.ForeColor = SystemColors.WindowText;
            lblDatosRepartidor.Location = new Point(149, 62);
            lblDatosRepartidor.Name = "lblDatosRepartidor";
            lblDatosRepartidor.Size = new Size(245, 17);
            lblDatosRepartidor.TabIndex = 0;
            lblDatosRepartidor.Text = "Ingrese los datos del nuevo repartidor:";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.WindowText;
            lblNombre.Location = new Point(149, 103);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(149, 123);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.Lavender;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.ForeColor = SystemColors.WindowText;
            btnRegistrar.Location = new Point(340, 470);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.ForeColor = SystemColors.WindowText;
            txtApellido.Location = new Point(149, 189);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(317, 23);
            txtApellido.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.WindowText;
            lblApellido.Location = new Point(149, 169);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 17);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.ForeColor = SystemColors.WindowText;
            txtDni.Location = new Point(149, 258);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(317, 23);
            txtDni.TabIndex = 8;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.ForeColor = SystemColors.WindowText;
            lblDni.Location = new Point(149, 238);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(31, 17);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(149, 335);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(317, 23);
            txtEmail.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.WindowText;
            lblEmail.Location = new Point(149, 315);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 17);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // RegistrarRepartidorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosRepartidor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarRepartidorForm";
            Text = "RegistrarRepartidorForm";
            Load += RegistrarRepartidorForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosRepartidor;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private Button btnSalir;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtEmail;
        private Label lblEmail;
    }
}