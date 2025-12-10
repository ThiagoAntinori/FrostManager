namespace UI.Primary_Forms
{
    partial class RegistrarEgresoForm
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
            lblSeleccionarInsumoAModificar = new Label();
            lblBuscarDescripcion = new Label();
            txtDescripcionBuscar = new TextBox();
            btnBuscar = new Button();
            cmbTipoInsumo = new ComboBox();
            lblFiltrarTipoInsumo = new Label();
            label1 = new Label();
            lblDescripcionSeleccionado = new Label();
            txtCantidadAEgresar = new TextBox();
            lblCantidadEgreso = new Label();
            btnAceptar = new Button();
            lblMotivoEgreso = new Label();
            txtMotivo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).BeginInit();
            SuspendLayout();
            // 
            // dgvInsumos
            // 
            dgvInsumos.Anchor = AnchorStyles.None;
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
            dgvInsumos.SelectionChanged += dgvInsumos_SelectionChanged;
            // 
            // lblSeleccionarInsumoAModificar
            // 
            lblSeleccionarInsumoAModificar.Anchor = AnchorStyles.None;
            lblSeleccionarInsumoAModificar.AutoSize = true;
            lblSeleccionarInsumoAModificar.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccionarInsumoAModificar.Location = new Point(51, 32);
            lblSeleccionarInsumoAModificar.Name = "lblSeleccionarInsumoAModificar";
            lblSeleccionarInsumoAModificar.Size = new Size(181, 15);
            lblSeleccionarInsumoAModificar.TabIndex = 1;
            lblSeleccionarInsumoAModificar.Text = "Seleccione el insumo a modificar";
            // 
            // lblBuscarDescripcion
            // 
            lblBuscarDescripcion.Anchor = AnchorStyles.None;
            lblBuscarDescripcion.AutoSize = true;
            lblBuscarDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscarDescripcion.Location = new Point(45, 456);
            lblBuscarDescripcion.Name = "lblBuscarDescripcion";
            lblBuscarDescripcion.Size = new Size(127, 15);
            lblBuscarDescripcion.TabIndex = 2;
            lblBuscarDescripcion.Text = "Buscar por descripcion";
            // 
            // txtDescripcionBuscar
            // 
            txtDescripcionBuscar.Anchor = AnchorStyles.None;
            txtDescripcionBuscar.Location = new Point(45, 483);
            txtDescripcionBuscar.Name = "txtDescripcionBuscar";
            txtDescripcionBuscar.Size = new Size(187, 23);
            txtDescripcionBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(262, 483);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipoInsumo
            // 
            cmbTipoInsumo.Anchor = AnchorStyles.None;
            cmbTipoInsumo.FormattingEnabled = true;
            cmbTipoInsumo.Items.AddRange(new object[] { "Envase", "Sabor" });
            cmbTipoInsumo.Location = new Point(216, 72);
            cmbTipoInsumo.Name = "cmbTipoInsumo";
            cmbTipoInsumo.Size = new Size(121, 23);
            cmbTipoInsumo.TabIndex = 5;
            cmbTipoInsumo.SelectedIndexChanged += cmbTipoInsumo_SelectedIndexChanged;
            // 
            // lblFiltrarTipoInsumo
            // 
            lblFiltrarTipoInsumo.Anchor = AnchorStyles.None;
            lblFiltrarTipoInsumo.AutoSize = true;
            lblFiltrarTipoInsumo.ForeColor = SystemColors.ActiveCaptionText;
            lblFiltrarTipoInsumo.Location = new Point(45, 72);
            lblFiltrarTipoInsumo.Name = "lblFiltrarTipoInsumo";
            lblFiltrarTipoInsumo.Size = new Size(144, 15);
            lblFiltrarTipoInsumo.TabIndex = 6;
            lblFiltrarTipoInsumo.Text = "Filtrar por tipo de insumo:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(398, 115);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 7;
            label1.Text = "Seleccionado:";
            // 
            // lblDescripcionSeleccionado
            // 
            lblDescripcionSeleccionado.Anchor = AnchorStyles.None;
            lblDescripcionSeleccionado.AutoSize = true;
            lblDescripcionSeleccionado.ForeColor = SystemColors.ActiveCaptionText;
            lblDescripcionSeleccionado.Location = new Point(398, 143);
            lblDescripcionSeleccionado.Name = "lblDescripcionSeleccionado";
            lblDescripcionSeleccionado.Size = new Size(12, 15);
            lblDescripcionSeleccionado.TabIndex = 8;
            lblDescripcionSeleccionado.Text = "-";
            // 
            // txtCantidadAEgresar
            // 
            txtCantidadAEgresar.Anchor = AnchorStyles.None;
            txtCantidadAEgresar.Location = new Point(398, 216);
            txtCantidadAEgresar.Name = "txtCantidadAEgresar";
            txtCantidadAEgresar.Size = new Size(187, 23);
            txtCantidadAEgresar.TabIndex = 9;
            // 
            // lblCantidadEgreso
            // 
            lblCantidadEgreso.Anchor = AnchorStyles.None;
            lblCantidadEgreso.AutoSize = true;
            lblCantidadEgreso.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidadEgreso.Location = new Point(398, 198);
            lblCantidadEgreso.Name = "lblCantidadEgreso";
            lblCantidadEgreso.Size = new Size(159, 15);
            lblCantidadEgreso.TabIndex = 10;
            lblCantidadEgreso.Text = "Ingrese la cantidad a egresar:";
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.ForeColor = SystemColors.ActiveCaptionText;
            btnAceptar.Location = new Point(449, 403);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(136, 33);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblMotivoEgreso
            // 
            lblMotivoEgreso.Anchor = AnchorStyles.None;
            lblMotivoEgreso.AutoSize = true;
            lblMotivoEgreso.ForeColor = SystemColors.ActiveCaptionText;
            lblMotivoEgreso.Location = new Point(398, 277);
            lblMotivoEgreso.Name = "lblMotivoEgreso";
            lblMotivoEgreso.Size = new Size(158, 15);
            lblMotivoEgreso.TabIndex = 12;
            lblMotivoEgreso.Text = "Ingrese el motivo del egreso:";
            // 
            // txtMotivo
            // 
            txtMotivo.Anchor = AnchorStyles.None;
            txtMotivo.Location = new Point(398, 295);
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(187, 23);
            txtMotivo.TabIndex = 13;
            // 
            // RegistrarEgresoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(txtMotivo);
            Controls.Add(lblMotivoEgreso);
            Controls.Add(btnAceptar);
            Controls.Add(lblCantidadEgreso);
            Controls.Add(txtCantidadAEgresar);
            Controls.Add(lblDescripcionSeleccionado);
            Controls.Add(label1);
            Controls.Add(lblFiltrarTipoInsumo);
            Controls.Add(cmbTipoInsumo);
            Controls.Add(btnBuscar);
            Controls.Add(txtDescripcionBuscar);
            Controls.Add(lblBuscarDescripcion);
            Controls.Add(lblSeleccionarInsumoAModificar);
            Controls.Add(dgvInsumos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarEgresoForm";
            Text = "RegistrarIngresoForm";
            Load += RegistrarEgresoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInsumos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInsumos;
        private Label lblSeleccionarInsumoAModificar;
        private Label lblBuscarDescripcion;
        private TextBox txtDescripcionBuscar;
        private Button btnBuscar;
        private ComboBox cmbTipoInsumo;
        private Label lblFiltrarTipoInsumo;
        private Label label1;
        private Label lblDescripcionSeleccionado;
        private TextBox txtCantidadAEgresar;
        private Label lblCantidadEgreso;
        private Button btnAceptar;
        private Label lblMotivoEgreso;
        private TextBox txtMotivo;
    }
}