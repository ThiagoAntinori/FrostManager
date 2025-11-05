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
            txtBuscarProducto.Location = new Point(42, 67);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "Buscar por nombre";
            txtBuscarProducto.Size = new Size(142, 25);
            txtBuscarProducto.TabIndex = 0;
            // 
            // lblSeleccioneProducto
            // 
            lblSeleccioneProducto.Anchor = AnchorStyles.None;
            lblSeleccioneProducto.AutoSize = true;
            lblSeleccioneProducto.Font = new Font("Segoe UI", 9.75F);
            lblSeleccioneProducto.ForeColor = SystemColors.WindowText;
            lblSeleccioneProducto.Location = new Point(41, 34);
            lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            lblSeleccioneProducto.Size = new Size(200, 17);
            lblSeleccioneProducto.TabIndex = 2;
            lblSeleccioneProducto.Text = "Seleccione un producto a añadir:";
            // 
            // lblIngresarCantidad
            // 
            lblIngresarCantidad.Anchor = AnchorStyles.None;
            lblIngresarCantidad.AutoSize = true;
            lblIngresarCantidad.Font = new Font("Segoe UI", 9.75F);
            lblIngresarCantidad.ForeColor = SystemColors.WindowText;
            lblIngresarCantidad.Location = new Point(41, 370);
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
            numCantidad.Location = new Point(169, 368);
            numCantidad.Name = "numCantidad";
            numCantidad.Size = new Size(48, 25);
            numCantidad.TabIndex = 4;
            // 
            // btnAñadir
            // 
            btnAñadir.Anchor = AnchorStyles.None;
            btnAñadir.Font = new Font("Segoe UI", 9.75F);
            btnAñadir.ForeColor = SystemColors.WindowText;
            btnAñadir.Location = new Point(145, 418);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(96, 23);
            btnAñadir.TabIndex = 5;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.None;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F);
            lblTotal.ForeColor = SystemColors.WindowText;
            lblTotal.Location = new Point(519, 369);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 17);
            lblTotal.TabIndex = 7;
            lblTotal.Text = "TOTAL:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Segoe UI", 9.75F);
            btnEliminar.ForeColor = SystemColors.WindowText;
            btnEliminar.Location = new Point(291, 366);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(138, 23);
            btnEliminar.TabIndex = 8;
            btnEliminar.Text = "Eliminar seleccionado";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnCancelarVenta
            // 
            btnCancelarVenta.Anchor = AnchorStyles.None;
            btnCancelarVenta.Font = new Font("Segoe UI", 9.75F);
            btnCancelarVenta.ForeColor = SystemColors.WindowText;
            btnCancelarVenta.Location = new Point(291, 418);
            btnCancelarVenta.Name = "btnCancelarVenta";
            btnCancelarVenta.Size = new Size(138, 23);
            btnCancelarVenta.TabIndex = 9;
            btnCancelarVenta.Text = "Cancelar Venta";
            btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // checkDelivery
            // 
            checkDelivery.Anchor = AnchorStyles.None;
            checkDelivery.AutoSize = true;
            checkDelivery.Font = new Font("Segoe UI", 9.75F);
            checkDelivery.ForeColor = SystemColors.WindowText;
            checkDelivery.Location = new Point(291, 496);
            checkDelivery.Name = "checkDelivery";
            checkDelivery.Size = new Size(101, 21);
            checkDelivery.TabIndex = 11;
            checkDelivery.Text = "¿Es delivery?";
            checkDelivery.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.None;
            btnConfirmar.Font = new Font("Segoe UI", 9.75F);
            btnConfirmar.ForeColor = SystemColors.WindowText;
            btnConfirmar.Location = new Point(475, 491);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(128, 26);
            btnConfirmar.TabIndex = 12;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            // 
            // lblDetalleVenta
            // 
            lblDetalleVenta.Anchor = AnchorStyles.None;
            lblDetalleVenta.AutoSize = true;
            lblDetalleVenta.Font = new Font("Segoe UI", 9.75F);
            lblDetalleVenta.ForeColor = SystemColors.WindowText;
            lblDetalleVenta.Location = new Point(295, 37);
            lblDetalleVenta.Name = "lblDetalleVenta";
            lblDetalleVenta.Size = new Size(102, 17);
            lblDetalleVenta.TabIndex = 13;
            lblDetalleVenta.Text = "Detalle de venta";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.Anchor = AnchorStyles.None;
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 9.75F);
            lblMontoTotal.ForeColor = SystemColors.WindowText;
            lblMontoTotal.Location = new Point(519, 399);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(15, 17);
            lblMontoTotal.TabIndex = 14;
            lblMontoTotal.Text = "0";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(190, 69);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(51, 23);
            btnBuscar.TabIndex = 15;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(42, 106);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.Size = new Size(199, 239);
            dgvProductos.TabIndex = 16;
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Location = new Point(295, 106);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.Size = new Size(308, 239);
            dgvDetalleVenta.TabIndex = 17;
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