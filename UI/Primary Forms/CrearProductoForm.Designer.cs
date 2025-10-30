namespace UI.Primary_Forms
{
    partial class CrearProductoForm
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
            btnSalir = new Button();
            btnRegistrar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDatosProducto = new Label();
            txtCapacidad = new TextBox();
            lblCapacidad = new Label();
            txtPrecioUnitario = new TextBox();
            lblPrecioUnitario = new Label();
            lblEnvaseNecesario = new Label();
            cmbEnvaseNecesario = new ComboBox();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(527, 18);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.Lavender;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.ForeColor = SystemColors.WindowText;
            btnRegistrar.Location = new Point(344, 405);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 29);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(153, 129);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(317, 23);
            txtNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.WindowText;
            lblNombre.Location = new Point(153, 109);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblDatosProducto
            // 
            lblDatosProducto.Anchor = AnchorStyles.None;
            lblDatosProducto.AutoSize = true;
            lblDatosProducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosProducto.ForeColor = SystemColors.WindowText;
            lblDatosProducto.Location = new Point(153, 68);
            lblDatosProducto.Name = "lblDatosProducto";
            lblDatosProducto.Size = new Size(194, 17);
            lblDatosProducto.TabIndex = 5;
            lblDatosProducto.Text = "Ingrese los datos del producto";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Anchor = AnchorStyles.None;
            txtCapacidad.ForeColor = SystemColors.WindowText;
            txtCapacidad.Location = new Point(153, 193);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(317, 23);
            txtCapacidad.TabIndex = 11;
            // 
            // lblCapacidad
            // 
            lblCapacidad.Anchor = AnchorStyles.None;
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidad.ForeColor = SystemColors.WindowText;
            lblCapacidad.Location = new Point(153, 173);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(140, 17);
            lblCapacidad.TabIndex = 10;
            lblCapacidad.Text = "Capacidad en Gramos";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Anchor = AnchorStyles.None;
            txtPrecioUnitario.ForeColor = SystemColors.WindowText;
            txtPrecioUnitario.Location = new Point(153, 265);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(317, 23);
            txtPrecioUnitario.TabIndex = 13;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.Anchor = AnchorStyles.None;
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioUnitario.ForeColor = SystemColors.WindowText;
            lblPrecioUnitario.Location = new Point(153, 245);
            lblPrecioUnitario.Name = "lblPrecioUnitario";
            lblPrecioUnitario.Size = new Size(96, 17);
            lblPrecioUnitario.TabIndex = 12;
            lblPrecioUnitario.Text = "Precio unitario";
            // 
            // lblEnvaseNecesario
            // 
            lblEnvaseNecesario.Anchor = AnchorStyles.None;
            lblEnvaseNecesario.AutoSize = true;
            lblEnvaseNecesario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnvaseNecesario.ForeColor = SystemColors.WindowText;
            lblEnvaseNecesario.Location = new Point(153, 321);
            lblEnvaseNecesario.Name = "lblEnvaseNecesario";
            lblEnvaseNecesario.Size = new Size(111, 17);
            lblEnvaseNecesario.TabIndex = 14;
            lblEnvaseNecesario.Text = "Envase necesario";
            // 
            // cmbEnvaseNecesario
            // 
            cmbEnvaseNecesario.Anchor = AnchorStyles.None;
            cmbEnvaseNecesario.FormattingEnabled = true;
            cmbEnvaseNecesario.Location = new Point(153, 341);
            cmbEnvaseNecesario.Name = "cmbEnvaseNecesario";
            cmbEnvaseNecesario.Size = new Size(317, 23);
            cmbEnvaseNecesario.TabIndex = 15;
            // 
            // CrearProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(cmbEnvaseNecesario);
            Controls.Add(lblEnvaseNecesario);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(txtCapacidad);
            Controls.Add(lblCapacidad);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearProductoForm";
            Text = "CrearProductoForm";
            Load += CrearProductoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnRegistrar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDatosProducto;
        private TextBox txtCapacidad;
        private Label lblCapacidad;
        private TextBox txtPrecioUnitario;
        private Label lblPrecioUnitario;
        private Label lblEnvaseNecesario;
        private ComboBox cmbEnvaseNecesario;
    }
}