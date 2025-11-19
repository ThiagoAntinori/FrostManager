namespace UI.Primary_Forms
{
    partial class AjustarStockForm
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
            dgvInsumos = new DataGridView();
            lblSeleccionarInsumo = new Label();
            lblBuscarDescripcion = new Label();
            txtDescripcionBuscar = new TextBox();
            btnBuscar = new Button();
            cmbTipoInsumo = new ComboBox();
            lblFiltrarTipoInsumo = new Label();
            lblSeleccionado = new Label();
            lblDescripcionSeleccionado = new Label();
            txtCantidadAjustar = new TextBox();
            lblCantidadAjuste = new Label();
            btnAceptarAjuste = new Button();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            SuspendLayout();
            // 
            // dgvInsumos
            // 
            dgvInsumos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvInsumos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvInsumos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInsumos.Location = new Point(45, 115);
            dgvInsumos.MultiSelect = false;
            dgvInsumos.Name = "dgvInsumos";
            dgvInsumos.ReadOnly = true;
            dgvInsumos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInsumos.Size = new Size(292, 321);
            dgvInsumos.TabIndex = 0;
            // 
            // lblSeleccionarInsumo
            // 
            lblSeleccionarInsumo.AutoSize = true;
            lblSeleccionarInsumo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccionarInsumo.ForeColor = SystemColors.WindowText;
            lblSeleccionarInsumo.Location = new Point(45, 32);
            lblSeleccionarInsumo.Name = "lblSeleccionarInsumo";
            lblSeleccionarInsumo.Size = new Size(134, 17);
            lblSeleccionarInsumo.TabIndex = 1;
            lblSeleccionarInsumo.Text = "Seleccione el Insumo";
            // 
            // lblBuscarDescripcion
            // 
            lblBuscarDescripcion.AutoSize = true;
            lblBuscarDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscarDescripcion.Location = new Point(45, 456);
            lblBuscarDescripcion.Name = "lblBuscarDescripcion";
            lblBuscarDescripcion.Size = new Size(127, 15);
            lblBuscarDescripcion.TabIndex = 2;
            lblBuscarDescripcion.Text = "Buscar por descripción";
            // 
            // txtDescripcionBuscar
            // 
            txtDescripcionBuscar.Location = new Point(45, 483);
            txtDescripcionBuscar.Name = "txtDescripcionBuscar";
            txtDescripcionBuscar.Size = new Size(187, 23);
            txtDescripcionBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(262, 483);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // cmbTipoInsumo
            // 
            cmbTipoInsumo.FormattingEnabled = true;
            cmbTipoInsumo.Items.AddRange(new object[] { "Envase", "Sabor" });
            cmbTipoInsumo.Location = new Point(216, 72);
            cmbTipoInsumo.Name = "cmbTipoInsumo";
            cmbTipoInsumo.Size = new Size(121, 23);
            cmbTipoInsumo.TabIndex = 5;
            // 
            // lblFiltrarTipoInsumo
            // 
            lblFiltrarTipoInsumo.AutoSize = true;
            lblFiltrarTipoInsumo.ForeColor = SystemColors.ActiveCaptionText;
            lblFiltrarTipoInsumo.Location = new Point(45, 72);
            lblFiltrarTipoInsumo.Name = "lblFiltrarTipoInsumo";
            lblFiltrarTipoInsumo.Size = new Size(144, 15);
            lblFiltrarTipoInsumo.TabIndex = 6;
            lblFiltrarTipoInsumo.Text = "Filtrar por tipo de insumo:";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccionado.Location = new Point(398, 115);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(80, 15);
            lblSeleccionado.TabIndex = 7;
            lblSeleccionado.Text = "Seleccionado:";
            // 
            // lblDescripcionSeleccionado
            // 
            lblDescripcionSeleccionado.AutoSize = true;
            lblDescripcionSeleccionado.ForeColor = SystemColors.ActiveCaptionText;
            lblDescripcionSeleccionado.Location = new Point(398, 143);
            lblDescripcionSeleccionado.Name = "lblDescripcionSeleccionado";
            lblDescripcionSeleccionado.Size = new Size(12, 15);
            lblDescripcionSeleccionado.TabIndex = 8;
            lblDescripcionSeleccionado.Text = "-";
            // 
            // txtCantidadAjustar
            // 
            txtCantidadAjustar.Location = new Point(398, 216);
            txtCantidadAjustar.Name = "txtCantidadAjustar";
            txtCantidadAjustar.Size = new Size(187, 23);
            txtCantidadAjustar.TabIndex = 9;
            // 
            // lblCantidadAjuste
            // 
            lblCantidadAjuste.AutoSize = true;
            lblCantidadAjuste.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidadAjuste.Location = new Point(398, 198);
            lblCantidadAjuste.Name = "lblCantidadAjuste";
            lblCantidadAjuste.Size = new Size(203, 15);
            lblCantidadAjuste.TabIndex = 10;
            lblCantidadAjuste.Text = "Ingrese la nueva cantidad en gramos:";
            // 
            // btnAceptarAjuste
            // 
            btnAceptarAjuste.BackColor = Color.Lavender;
            btnAceptarAjuste.FlatStyle = FlatStyle.Popup;
            btnAceptarAjuste.ForeColor = SystemColors.WindowText;
            btnAceptarAjuste.Location = new Point(449, 403);
            btnAceptarAjuste.Name = "btnAceptarAjuste";
            btnAceptarAjuste.Size = new Size(136, 33);
            btnAceptarAjuste.TabIndex = 11;
            btnAceptarAjuste.Text = "Aceptar Ajuste";
            btnAceptarAjuste.UseVisualStyleBackColor = false;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.ForeColor = SystemColors.ActiveCaptionText;
            lblMotivo.Location = new Point(398, 277);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(154, 15);
            lblMotivo.TabIndex = 12;
            lblMotivo.Text = "Ingrese el motivo del ajuste:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(398, 295);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(187, 23);
            txtMotivo.TabIndex = 13;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // AjustarStockForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnSalir);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivo);
            Controls.Add(btnAceptarAjuste);
            Controls.Add(lblCantidadAjuste);
            Controls.Add(txtCantidadAjustar);
            Controls.Add(lblDescripcionSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(lblFiltrarTipoInsumo);
            Controls.Add(cmbTipoInsumo);
            Controls.Add(btnBuscar);
            Controls.Add(txtDescripcionBuscar);
            Controls.Add(lblBuscarDescripcion);
            Controls.Add(lblSeleccionarInsumo);
            Controls.Add(dgvInsumos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AjustarStockForm";
            Text = "AjustarStockForm";
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInsumos;
        private Label lblSeleccionarInsumo;
        private Label lblBuscarDescripcion;
        private TextBox txtDescripcionBuscar;
        private Button btnBuscar;
        private ComboBox cmbTipoInsumo;
        private Label lblFiltrarTipoInsumo;
        private Label lblSeleccionado;
        private Label lblDescripcionSeleccionado;
        private TextBox txtCantidadAjustar;
        private Label lblCantidadAjuste;
        private Button btnAceptarAjuste;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Button btnSalir;
    }
}