namespace UI.Primary_Forms
{
    partial class VentaForm
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
            txtBuscarProducto = new TextBox();
            lblSeleccioneProducto = new Label();
            lblIngresarCantidad = new Label();
            numCantidad = new NumericUpDown();
            btnAñadir = new Button();
            lblTotal = new Label();
            btnEliminar = new Button();
            btnCancelarVenta = new Button();
            checkDelivery = new CheckBox();
            btnConfirmar = new Button();
            lblDetalleVenta = new Label();
            lblMontoTotal = new Label();
            btnBuscar = new Button();
            dgvProductos = new DataGridView();
            dgvDetalleVenta = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)numCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Anchor = AnchorStyles.None;
            txtBuscarProducto.Font = new Font("Segoe UI", 9.75F);
            txtBuscarProducto.ForeColor = SystemColors.WindowText;
            txtBuscarProducto.Location = new Point(40, 67);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "Buscar por nombre";
            txtBuscarProducto.Size = new Size(130, 25);
            txtBuscarProducto.TabIndex = 0;
            // 
            // lblSeleccioneProducto
            // 
            lblSeleccioneProducto.Anchor = AnchorStyles.None;
            lblSeleccioneProducto.AutoSize = true;
            lblSeleccioneProducto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblSeleccioneProducto.ForeColor = SystemColors.WindowText;
            lblSeleccioneProducto.Location = new Point(40, 40);
            lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            lblSeleccioneProducto.Size = new Size(207, 17);
            lblSeleccioneProducto.TabIndex = 2;
            lblSeleccioneProducto.Text = "Seleccione un producto a añadir:";
            // 
            // lblIngresarCantidad
            // 
            lblIngresarCantidad.Anchor = AnchorStyles.None;
            lblIngresarCantidad.AutoSize = true;
            lblIngresarCantidad.Font = new Font("Segoe UI", 9.75F);
            lblIngresarCantidad.ForeColor = SystemColors.WindowText;
            lblIngresarCantidad.Location = new Point(40, 370);
            lblIngresarCantidad.Name = "lblIngresarCantidad";
            lblIngresarCantidad.Size = new Size(122, 17);
            lblIngresarCantidad.TabIndex = 3;
            lblIngresarCantidad.Text = "Ingrese la cantidad:";
            // 
            // numCantidad
            // 
            numCantidad.Anchor = AnchorStyles.None;
            numCantidad.Font = new Font("Segoe UI", 9.75F);
            numCantidad.ForeColor = SystemColors.WindowText;
            numCantidad.Location = new Point(172, 368);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(69, 25);
            numCantidad.TabIndex = 4;
            // 
            // btnAñadir
            // 
            btnAñadir.Anchor = AnchorStyles.None;
            btnAñadir.Font = new Font("Segoe UI", 9.75F);
            btnAñadir.ForeColor = SystemColors.WindowText;
            btnAñadir.Location = new Point(145, 410);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(96, 30);
            btnAñadir.TabIndex = 5;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTotal.ForeColor = SystemColors.WindowText;
            lblTotal.Location = new Point(530, 372);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(60, 21);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Segoe UI", 9.75F);
            btnEliminar.ForeColor = SystemColors.WindowText;
            btnEliminar.Location = new Point(340, 368);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(140, 30);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Anchor = AnchorStyles.None;
            btnCancelarVenta.Font = new Font("Segoe UI", 9.75F);
            btnCancelarVenta.ForeColor = SystemColors.WindowText;
            btnCancelarVenta.Location = new Point(340, 410);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(140, 30);
            btnCancelarVenta.TabIndex = 9;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            btnCancelarVenta.Click += btnCancelarVenta_Click;
            // 
            // checkDelivery
            // 
            checkDelivery.Anchor = AnchorStyles.None;
            checkDelivery.AutoSize = true;
            checkDelivery.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            checkDelivery.ForeColor = SystemColors.WindowText;
            checkDelivery.Location = new Point(40, 490);
            checkDelivery.Name = "checkDelivery";
            checkDelivery.Size = new Size(117, 24);
            checkDelivery.TabIndex = 11;
            checkDelivery.Text = "¿Es delivery?";
            checkDelivery.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnConfirmar.ForeColor = SystemColors.WindowText;
            btnConfirmar.Location = new Point(480, 485);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(110, 35);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.Anchor = AnchorStyles.None;
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDetalleVenta.ForeColor = SystemColors.WindowText;
            lblDetalleVenta.Location = new Point(340, 40);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(106, 17);
            lblDetalleVenta.TabIndex = 13;
            lblDetalleVenta.Text = "Detalle de venta";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.Anchor = AnchorStyles.None;
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblMontoTotal.ForeColor = SystemColors.WindowText;
            lblMontoTotal.Location = new Point(530, 393);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(19, 21);
            lblMontoTotal.TabIndex = 14;
            lblMontoTotal.Text = "0";
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.Font = new Font("Segoe UI", 9.75F);
            btnBuscar.Location = new Point(175, 68);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(66, 23);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.None;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(40, 106);
            dgvProductos.MultiSelect = false;
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersVisible = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(201, 239);
            dgvProductos.TabIndex = 16;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.Anchor = AnchorStyles.None;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(340, 67);
            dgvDetalleVenta.MultiSelect = false;
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.ReadOnly = true;
            dgvDetalleVenta.RowHeadersVisible = false;
            dgvDetalleVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetalleVenta.Size = new Size(250, 278);
            dgvDetalleVenta.TabIndex = 17;
            dgvDetalleVenta.SelectionChanged += dgvDetalleVenta_SelectionChanged;
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(dgvProductos);
            Controls.Add(btnBuscar);
            Controls.Add(lblMontoTotal);
            Controls.Add(lblDetalleVenta);
            Controls.Add(btnConfirmar);
            Controls.Add(checkDelivery);
            Controls.Add(btnCancelarVenta);
            Controls.Add(btnEliminar);
            Controls.Add(lblTotal);
            Controls.Add(btnAñadir);
            Controls.Add(numCantidad);
            Controls.Add(lblIngresarCantidad);
            Controls.Add(lblSeleccioneProducto);
            Controls.Add(txtBuscarProducto);
            ForeColor = SystemColors.WindowText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaForm";
            Text = "Form1";
            Load += VentaForm_Load;
            ((System.ComponentModel.ISupportInitialize)numCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarProducto;
        private ListView lvProductos;
        private Label lblSeleccioneProducto;
        private Label lblIngresarCantidad;
        private NumericUpDown numCantidad;
        private Button btnEliminar;
        private ListView listView1;
        private Label lblTotal;
        private Button btnAñadir;
        private Button btnCancelarVenta;
        private CheckBox checkDelivery;
        private Button btnConfirmar;
        private Label lblDetalleVenta;
        private Label lblMontoTotal;
        private Button btnBuscar;
        private DataGridView dgvProductos;
        private DataGridView dgvDetalleVenta;
    }
}