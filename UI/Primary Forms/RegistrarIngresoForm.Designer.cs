namespace UI.Primary_Forms
{
    partial class RegistrarIngresoForm
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
            textBox2 = new TextBox();
            lblCantidadIngreso = new Label();
            btnAceptar = new Button();
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
            dgvInsumos.Size = new Size(292, 347);
            dgvInsumos.TabIndex = 0;
            // 
            // lblSeleccionarInsumoAModificar
            // 
            lblSeleccionarInsumoAModificar.AutoSize = true;
            lblSeleccionarInsumoAModificar.Location = new Point(51, 32);
            lblSeleccionarInsumoAModificar.Name = "lblSeleccionarInsumoAModificar";
            lblSeleccionarInsumoAModificar.Size = new Size(181, 15);
            lblSeleccionarInsumoAModificar.TabIndex = 1;
            lblSeleccionarInsumoAModificar.Text = "Seleccione el insumo a modificar";
            // 
            // lblBuscarDescripcion
            // 
            lblBuscarDescripcion.AutoSize = true;
            lblBuscarDescripcion.Location = new Point(45, 480);
            lblBuscarDescripcion.Name = "lblBuscarDescripcion";
            lblBuscarDescripcion.Size = new Size(127, 15);
            lblBuscarDescripcion.TabIndex = 2;
            lblBuscarDescripcion.Text = "Buscar por descripcion";
            // 
            // txtDescripcionBuscar
            // 
            txtDescripcionBuscar.Location = new Point(45, 507);
            txtDescripcionBuscar.Name = "txtDescripcionBuscar";
            txtDescripcionBuscar.Size = new Size(187, 23);
            txtDescripcionBuscar.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(262, 507);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // cmbTipoInsumo
            // 
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
            lblFiltrarTipoInsumo.AutoSize = true;
            lblFiltrarTipoInsumo.Location = new Point(45, 72);
            lblFiltrarTipoInsumo.Name = "lblFiltrarTipoInsumo";
            lblFiltrarTipoInsumo.Size = new Size(144, 15);
            lblFiltrarTipoInsumo.TabIndex = 6;
            lblFiltrarTipoInsumo.Text = "Filtrar por tipo de insumo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(398, 115);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 7;
            label1.Text = "Seleccionado:";
            // 
            // lblDescripcionSeleccionado
            // 
            lblDescripcionSeleccionado.AutoSize = true;
            lblDescripcionSeleccionado.Location = new Point(398, 143);
            lblDescripcionSeleccionado.Name = "lblDescripcionSeleccionado";
            lblDescripcionSeleccionado.Size = new Size(12, 15);
            lblDescripcionSeleccionado.TabIndex = 8;
            lblDescripcionSeleccionado.Text = "-";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(398, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 9;
            // 
            // lblCantidadIngreso
            // 
            lblCantidadIngreso.AutoSize = true;
            lblCantidadIngreso.Location = new Point(398, 198);
            lblCantidadIngreso.Name = "lblCantidadIngreso";
            lblCantidadIngreso.Size = new Size(163, 15);
            lblCantidadIngreso.TabIndex = 10;
            lblCantidadIngreso.Text = "Ingrese la cantidad a ingresar:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(449, 429);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(136, 33);
            btnAceptar.TabIndex = 11;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // RegistrarIngresoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnAceptar);
            Controls.Add(lblCantidadIngreso);
            Controls.Add(textBox2);
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
            Name = "RegistrarIngresoForm";
            Text = "RegistrarIngresoForm";
            Load += RegistrarIngresoForm_Load;
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
        private TextBox textBox2;
        private Label lblCantidadIngreso;
        private Button btnAceptar;
    }
}