namespace UI.Primary_Forms
{
    partial class AltaClienteForm
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
            lblDatosCliente = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            SuspendLayout();
            // 
            // lblDatosCliente
            // 
            lblDatosCliente.Anchor = AnchorStyles.None;
            lblDatosCliente.AutoSize = true;
            lblDatosCliente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosCliente.ForeColor = SystemColors.ActiveCaptionText;
            lblDatosCliente.Location = new Point(149, 62);
            lblDatosCliente.Name = "lblDatosCliente";
            lblDatosCliente.Size = new Size(222, 17);
            lblDatosCliente.TabIndex = 0;
            lblDatosCliente.Text = "Ingrese los datos del nuevo cliente:";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(149, 103);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
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
            btnRegistrar.Location = new Point(340, 470);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
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
            lblApellido.Location = new Point(149, 169);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 17);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
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
            lblDni.Location = new Point(149, 238);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(31, 17);
            lblDni.TabIndex = 7;
            lblDni.Text = "DNI";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.Location = new Point(149, 333);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(317, 23);
            txtTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(149, 313);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 17);
            lblTelefono.TabIndex = 9;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.Location = new Point(149, 407);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(317, 23);
            txtDireccion.TabIndex = 12;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.None;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(149, 387);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(63, 17);
            lblDireccion.TabIndex = 11;
            lblDireccion.Text = "Dirección";
            // 
            // AltaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            ClientSize = new Size(624, 561);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosCliente);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(624, 561);
            Name = "AltaClienteForm";
            Text = "AltaClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosCliente;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnRegistrar;
        private Button btnSalir;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDireccion;
        private Label lblDireccion;
    }
}