namespace UI.Primary_Forms
{
    partial class CrearInsumoForm
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
            txtCapacidad = new TextBox();
            lblCapacidad = new Label();
            txtStockMinimo = new TextBox();
            lblStockMinimo = new Label();
            txtStockInicial = new TextBox();
            lblStockInicial = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            btnSalir = new Button();
            btnRegistrar = new Button();
            lblTipoInsumo = new Label();
            lblDatosInsumo = new Label();
            cmbTipoInsumo = new ComboBox();
            SuspendLayout();
            // 
            // txtCapacidad
            // 
            txtCapacidad.Anchor = AnchorStyles.None;
            txtCapacidad.ForeColor = SystemColors.WindowText;
            txtCapacidad.Location = new Point(137, 422);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(317, 23);
            txtCapacidad.TabIndex = 25;
            // 
            // lblCapacidad
            // 
            lblCapacidad.Anchor = AnchorStyles.None;
            lblCapacidad.AutoSize = true;
            lblCapacidad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCapacidad.ForeColor = SystemColors.WindowText;
            lblCapacidad.Location = new Point(137, 402);
            lblCapacidad.Name = "lblCapacidad";
            lblCapacidad.Size = new Size(139, 17);
            lblCapacidad.TabIndex = 24;
            lblCapacidad.Text = "Capacidad en gramos";
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Anchor = AnchorStyles.None;
            txtStockMinimo.ForeColor = SystemColors.WindowText;
            txtStockMinimo.Location = new Point(137, 348);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(317, 23);
            txtStockMinimo.TabIndex = 23;
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.Anchor = AnchorStyles.None;
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockMinimo.ForeColor = SystemColors.WindowText;
            lblStockMinimo.Location = new Point(137, 328);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(91, 17);
            lblStockMinimo.TabIndex = 22;
            lblStockMinimo.Text = "Stock Minimo";
            // 
            // txtStockInicial
            // 
            txtStockInicial.Anchor = AnchorStyles.None;
            txtStockInicial.ForeColor = SystemColors.WindowText;
            txtStockInicial.Location = new Point(137, 273);
            txtStockInicial.Name = "txtStockInicial";
            txtStockInicial.Size = new Size(317, 23);
            txtStockInicial.TabIndex = 21;
            // 
            // lblStockInicial
            // 
            lblStockInicial.Anchor = AnchorStyles.None;
            lblStockInicial.AutoSize = true;
            lblStockInicial.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockInicial.ForeColor = SystemColors.WindowText;
            lblStockInicial.Location = new Point(137, 253);
            lblStockInicial.Name = "lblStockInicial";
            lblStockInicial.Size = new Size(78, 17);
            lblStockInicial.TabIndex = 20;
            lblStockInicial.Text = "Stock inicial";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.ForeColor = SystemColors.WindowText;
            txtDescripcion.Location = new Point(137, 204);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(317, 23);
            txtDescripcion.TabIndex = 19;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescripcion.ForeColor = SystemColors.WindowText;
            lblDescripcion.Location = new Point(137, 184);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(80, 17);
            lblDescripcion.TabIndex = 18;
            lblDescripcion.Text = "Descripicion";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(512, 37);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.BackColor = Color.Lavender;
            btnRegistrar.FlatStyle = FlatStyle.Popup;
            btnRegistrar.ForeColor = SystemColors.WindowText;
            btnRegistrar.Location = new Point(328, 485);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(126, 29);
            btnRegistrar.TabIndex = 16;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblTipoInsumo
            // 
            lblTipoInsumo.Anchor = AnchorStyles.None;
            lblTipoInsumo.AutoSize = true;
            lblTipoInsumo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoInsumo.ForeColor = SystemColors.WindowText;
            lblTipoInsumo.Location = new Point(137, 118);
            lblTipoInsumo.Name = "lblTipoInsumo";
            lblTipoInsumo.Size = new Size(102, 17);
            lblTipoInsumo.TabIndex = 14;
            lblTipoInsumo.Text = "Tipo de insumo";
            // 
            // lblDatosInsumo
            // 
            lblDatosInsumo.Anchor = AnchorStyles.None;
            lblDatosInsumo.AutoSize = true;
            lblDatosInsumo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosInsumo.ForeColor = SystemColors.WindowText;
            lblDatosInsumo.Location = new Point(137, 77);
            lblDatosInsumo.Name = "lblDatosInsumo";
            lblDatosInsumo.Size = new Size(228, 17);
            lblDatosInsumo.TabIndex = 13;
            lblDatosInsumo.Text = "Ingrese los datos del nuevo insumo:";
            // 
            // cmbTipoInsumo
            // 
            cmbTipoInsumo.Anchor = AnchorStyles.None;
            cmbTipoInsumo.FormattingEnabled = true;
            cmbTipoInsumo.Items.AddRange(new object[] { "Sabor", "Envase" });
            cmbTipoInsumo.Location = new Point(137, 138);
            cmbTipoInsumo.Name = "cmbTipoInsumo";
            cmbTipoInsumo.Size = new Size(317, 23);
            cmbTipoInsumo.TabIndex = 26;
            cmbTipoInsumo.SelectedIndexChanged += cmbTipoInsumo_SelectedIndexChanged;
            // 
            // CrearInsumoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(cmbTipoInsumo);
            Controls.Add(txtCapacidad);
            Controls.Add(lblCapacidad);
            Controls.Add(txtStockMinimo);
            Controls.Add(lblStockMinimo);
            Controls.Add(txtStockInicial);
            Controls.Add(lblStockInicial);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(lblTipoInsumo);
            Controls.Add(lblDatosInsumo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearInsumoForm";
            Text = "CrearInsumoForm";
            Load += CrearInsumoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCapacidad;
        private Label lblCapacidad;
        private TextBox txtStockMinimo;
        private Label lblStockMinimo;
        private TextBox txtStockInicial;
        private Label lblStockInicial;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private Button btnSalir;
        private Button btnRegistrar;
        private Label lblTipoInsumo;
        private Label lblDatosInsumo;
        private ComboBox cmbTipoInsumo;
    }
}