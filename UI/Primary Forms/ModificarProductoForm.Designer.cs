namespace UI.Primary_Forms
{
    partial class ModificarProductoForm
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
            btnModificar = new Button();
            txtNombre = new TextBox();
            lblNombre = new Label();
            lblDatosProducto = new Label();
            txtCapacidad = new TextBox();
            lblCapacidad = new Label();
            txtPrecioUnitario = new TextBox();
            lblPrecioUnitario = new Label();
            lblEnvaseNecesario = new Label();
            cmbEnvaseNecesario = new ComboBox();
            dgvProductos = new DataGridView();
            lblBuscar = new Label();
            txtBuscarNombre = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 9;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.Lavender;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.ForeColor = SystemColors.WindowText;
            btnModificar.Location = new Point(410, 485);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(126, 29);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(350, 199);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(186, 23);
            txtNombre.TabIndex = 7;
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.WindowText;
            lblNombre.Location = new Point(350, 179);
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
            lblDatosProducto.Location = new Point(350, 140);
            lblDatosProducto.Name = "lblDatosProducto";
            lblDatosProducto.Size = new Size(128, 17);
            lblDatosProducto.TabIndex = 5;
            lblDatosProducto.Text = "Datos del Producto:";
            // 
            // txtCapacidad
            // 
            txtCapacidad.Anchor = AnchorStyles.None;
            txtCapacidad.ForeColor = SystemColors.WindowText;
            txtCapacidad.Location = new Point(350, 263);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(186, 23);
            txtCapacidad.TabIndex = 11;
            // 
            // lblCapacidad
            // 
            lblCapacidad.Anchor = AnchorStyles.None;
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidad.ForeColor = SystemColors.WindowText;
            lblCapacidad.Location = new Point(350, 243);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(140, 17);
            lblCapacidad.TabIndex = 10;
            lblCapacidad.Text = "Capacidad en Gramos";
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Anchor = AnchorStyles.None;
            txtPrecioUnitario.ForeColor = SystemColors.WindowText;
            txtPrecioUnitario.Location = new Point(350, 335);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(186, 23);
            txtPrecioUnitario.TabIndex = 13;
            // 
            // lblPrecioUnitario
            // 
            lblPrecioUnitario.Anchor = AnchorStyles.None;
            lblPrecioUnitario.AutoSize = true;
            lblPrecioUnitario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrecioUnitario.ForeColor = SystemColors.WindowText;
            lblPrecioUnitario.Location = new Point(350, 315);
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
            lblEnvaseNecesario.Location = new Point(350, 391);
            lblEnvaseNecesario.Name = "lblEnvaseNecesario";
            lblEnvaseNecesario.Size = new Size(111, 17);
            lblEnvaseNecesario.TabIndex = 14;
            lblEnvaseNecesario.Text = "Envase necesario";
            // 
            // cmbEnvaseNecesario
            // 
            cmbEnvaseNecesario.Anchor = AnchorStyles.None;
            cmbEnvaseNecesario.FormattingEnabled = true;
            cmbEnvaseNecesario.Location = new Point(350, 411);
            cmbEnvaseNecesario.Name = "cmbEnvaseNecesario";
            cmbEnvaseNecesario.Size = new Size(186, 23);
            cmbEnvaseNecesario.TabIndex = 15;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(45, 115);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(270, 321);
            dgvProductos.TabIndex = 16;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.None;
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscar.Location = new Point(45, 456);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(113, 15);
            lblBuscar.TabIndex = 17;
            lblBuscar.Text = "Buscar por Nombre:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Anchor = AnchorStyles.None;
            txtBuscarNombre.Location = new Point(45, 483);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(187, 23);
            txtBuscarNombre.TabIndex = 18;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(240, 483);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 19;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ModificarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarNombre);
            Controls.Add(lblBuscar);
            Controls.Add(dgvProductos);
            Controls.Add(cmbEnvaseNecesario);
            Controls.Add(lblEnvaseNecesario);
            Controls.Add(txtPrecioUnitario);
            Controls.Add(lblPrecioUnitario);
            Controls.Add(txtCapacidad);
            Controls.Add(lblCapacidad);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarProductoForm";
            Text = "ModificarProductoForm";
            Load += ModificarProductoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnModificar;
        private TextBox txtNombre;
        private Label lblNombre;
        private Label lblDatosProducto;
        private TextBox txtCapacidad;
        private Label lblCapacidad;
        private TextBox txtPrecioUnitario;
        private Label lblPrecioUnitario;
        private Label lblEnvaseNecesario;
        private ComboBox cmbEnvaseNecesario;
        private DataGridView dgvProductos;
        private Label lblBuscar;
        private TextBox txtBuscarNombre;
        private Button btnBuscar;
    }
}