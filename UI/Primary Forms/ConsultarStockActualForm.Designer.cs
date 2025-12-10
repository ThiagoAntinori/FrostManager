namespace UI.Primary_Forms
{
    partial class ConsultarStockActualForm
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
            dgvStock = new DataGridView();
            lblTituloStock = new Label();
            btnSalir = new Button();
            lblFiltrarTipoInsumo = new Label();
            cmbTipoInsumo = new ComboBox();
            lblBuscarDescripcion = new Label();
            txtDescripcionBuscar = new TextBox();
            btnBuscar = new Button();
            btnConsultar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // dgvStock
            // 
            dgvStock.Anchor = AnchorStyles.None;
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Location = new Point(45, 115);
            dgvStock.MultiSelect = false;
            dgvStock.Name = "dgvStock";
            dgvStock.ReadOnly = true;
            dgvStock.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStock.Size = new Size(530, 321);
            dgvStock.TabIndex = 0;
            dgvStock.SelectionChanged += dgvStock_SelectionChanged;
            // 
            // lblTituloStock
            // 
            lblTituloStock.Anchor = AnchorStyles.None;
            lblTituloStock.AutoSize = true;
            lblTituloStock.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloStock.ForeColor = SystemColors.WindowText;
            lblTituloStock.Location = new Point(45, 32);
            lblTituloStock.Name = "lblTituloStock";
            lblTituloStock.Size = new Size(86, 17);
            lblTituloStock.TabIndex = 1;
            lblTituloStock.Text = "Stock Actual:";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblFiltrarTipoInsumo
            // 
            lblFiltrarTipoInsumo.Anchor = AnchorStyles.None;
            lblFiltrarTipoInsumo.AutoSize = true;
            lblFiltrarTipoInsumo.ForeColor = SystemColors.ActiveCaptionText;
            lblFiltrarTipoInsumo.Location = new Point(45, 72);
            lblFiltrarTipoInsumo.Name = "lblFiltrarTipoInsumo";
            lblFiltrarTipoInsumo.Size = new Size(144, 15);
            lblFiltrarTipoInsumo.TabIndex = 7;
            lblFiltrarTipoInsumo.Text = "Filtrar por tipo de insumo:";
            // 
            // cmbTipoInsumo
            // 
            cmbTipoInsumo.Anchor = AnchorStyles.None;
            cmbTipoInsumo.FormattingEnabled = true;
            cmbTipoInsumo.Items.AddRange(new object[] { "Envase", "Sabor" });
            cmbTipoInsumo.Location = new Point(216, 69);
            cmbTipoInsumo.Name = "cmbTipoInsumo";
            cmbTipoInsumo.Size = new Size(121, 23);
            cmbTipoInsumo.TabIndex = 6;
            cmbTipoInsumo.SelectedValueChanged += cmbTipoInsumo_SelectedValueChanged;
            // 
            // lblBuscarDescripcion
            // 
            lblBuscarDescripcion.Anchor = AnchorStyles.None;
            lblBuscarDescripcion.AutoSize = true;
            lblBuscarDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscarDescripcion.Location = new Point(45, 456);
            lblBuscarDescripcion.Name = "lblBuscarDescripcion";
            lblBuscarDescripcion.Size = new Size(127, 15);
            lblBuscarDescripcion.TabIndex = 8;
            lblBuscarDescripcion.Text = "Buscar por descripción";
            // 
            // txtDescripcionBuscar
            // 
            txtDescripcionBuscar.Anchor = AnchorStyles.None;
            txtDescripcionBuscar.Location = new Point(45, 483);
            txtDescripcionBuscar.Name = "txtDescripcionBuscar";
            txtDescripcionBuscar.Size = new Size(187, 23);
            txtDescripcionBuscar.TabIndex = 9;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(262, 483);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Anchor = AnchorStyles.None;
            btnConsultar.Location = new Point(424, 476);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(151, 35);
            btnConsultar.TabIndex = 11;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // ConsultarStockActualForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnConsultar);
            Controls.Add(btnBuscar);
            Controls.Add(txtDescripcionBuscar);
            Controls.Add(lblBuscarDescripcion);
            Controls.Add(lblFiltrarTipoInsumo);
            Controls.Add(cmbTipoInsumo);
            Controls.Add(btnSalir);
            Controls.Add(lblTituloStock);
            Controls.Add(dgvStock);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultarStockActualForm";
            Text = "ConsultarStockActualForm";
            Load += ConsultarStockActualForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStock;
        private Label lblTituloStock;
        private Button btnSalir;
        private Label lblFiltrarTipoInsumo;
        private ComboBox cmbTipoInsumo;
        private Label lblBuscarDescripcion;
        private TextBox txtDescripcionBuscar;
        private Button btnBuscar;
        private Button btnConsultar;
    }
}