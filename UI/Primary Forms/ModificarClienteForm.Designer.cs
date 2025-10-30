namespace UI.Primary_Forms
{
    partial class ModificarClienteForm
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
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDni = new TextBox();
            lblDni = new Label();
            txtApellido = new TextBox();
            lblApellido = new Label();
            btnRegistrar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnBuscar = new Button();
            SuspendLayout();
            // 
            // txtDireccion
            // 
            txtDireccion.Anchor = AnchorStyles.None;
            txtDireccion.ForeColor = SystemColors.WindowText;
            txtDireccion.Location = new Point(70, 398);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(317, 23);
            txtDireccion.TabIndex = 24;
            // 
            // lblDireccion
            // 
            lblDireccion.Anchor = AnchorStyles.None;
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDireccion.ForeColor = SystemColors.WindowText;
            lblDireccion.Location = new Point(70, 378);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(63, 17);
            lblDireccion.TabIndex = 23;
            lblDireccion.Text = "Dirección";
            // 
            // txtTelefono
            // 
            txtTelefono.Anchor = AnchorStyles.None;
            txtTelefono.ForeColor = SystemColors.WindowText;
            txtTelefono.Location = new Point(70, 324);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(317, 23);
            txtTelefono.TabIndex = 22;
            // 
            // lblTelefono
            // 
            lblTelefono.Anchor = AnchorStyles.None;
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTelefono.ForeColor = SystemColors.WindowText;
            lblTelefono.Location = new Point(70, 304);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 17);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Teléfono";
            // 
            // txtDni
            // 
            txtDni.Anchor = AnchorStyles.None;
            txtDni.ForeColor = SystemColors.WindowText;
            txtDni.Location = new Point(306, 97);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(158, 23);
            txtDni.TabIndex = 20;
            // 
            // lblDni
            // 
            lblDni.Anchor = AnchorStyles.None;
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.ForeColor = SystemColors.WindowText;
            lblDni.Location = new Point(70, 98);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(230, 17);
            lblDni.TabIndex = 19;
            lblDni.Text = "Ingrese el DNI del cliente a modificar";
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.ForeColor = SystemColors.WindowText;
            txtApellido.Location = new Point(70, 254);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(317, 23);
            txtApellido.TabIndex = 18;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.WindowText;
            lblApellido.Location = new Point(70, 234);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 17);
            lblApellido.TabIndex = 17;
            lblApellido.Text = "Apellido";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.Lavender;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.ForeColor = SystemColors.WindowText;
            btnRegistrar.Location = new Point(439, 487);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 29);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(70, 188);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 23);
            txtNombre.TabIndex = 15;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.WindowText;
            lblNombre.Location = new Point(70, 168);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(483, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(91, 23);
            btnBuscar.TabIndex = 25;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ModificarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnBuscar);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(624, 561);
            Name = "ModificarClienteForm";
            Text = "ModificarClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtApellido;
        private Label lblApellido;
        private Button btnRegistrar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnBuscar;
    }
}