namespace UI.Primary_Forms
{
    partial class EliminarProductoForm
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
            dgvProductos = new DataGridView();
            lblTitulo = new Label();
            lblBuscar = new Label();
            txtBuscarNombre = new TextBox();
            btnBuscar = new Button();
            btnEliminar = new Button();
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
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
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
            dgvProductos.Size = new Size(530, 321);
            dgvProductos.TabIndex = 1;
            dgvProductos.SelectionChanged += dgvProductos_SelectionChanged;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.WindowText;
            lblTitulo.Location = new Point(45, 72);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(207, 17);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Seleccione el Producto a Eliminar";
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.None;
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscar.Location = new Point(45, 456);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(113, 15);
            lblBuscar.TabIndex = 3;
            lblBuscar.Text = "Buscar por Nombre:";
            // 
            // txtBuscarNombre
            // 
            txtBuscarNombre.Anchor = AnchorStyles.None;
            txtBuscarNombre.Location = new Point(45, 483);
            txtBuscarNombre.Name = "txtBuscarNombre";
            txtBuscarNombre.Size = new Size(187, 23);
            txtBuscarNombre.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(240, 483);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BackColor = Color.LightCoral;
            btnEliminar.FlatStyle = FlatStyle.Popup;
            btnEliminar.ForeColor = SystemColors.WindowText;
            btnEliminar.Location = new Point(449, 485);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(126, 29);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // EliminarProductoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnEliminar);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarNombre);
            Controls.Add(lblBuscar);
            Controls.Add(lblTitulo);
            Controls.Add(dgvProductos);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EliminarProductoForm";
            Text = "EliminarProductoForm";
            Load += EliminarProductoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private DataGridView dgvProductos;
        private Label lblTitulo;
        private Label lblBuscar;
        private TextBox txtBuscarNombre;
        private Button btnBuscar;
        private Button btnEliminar;
    }
}