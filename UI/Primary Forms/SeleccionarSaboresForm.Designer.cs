namespace UI.Primary_Forms
{
    partial class SeleccionarSaboresForm
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
            dgvSabores = new DataGridView();
            lblSeleccionarSabores = new Label();
            txtBuscarSabor = new TextBox();
            btnBuscar = new Button();
            btnAñadir = new Button();
            dgvSaboresSeleccionados = new DataGridView();
            lblSaboresSeleccionados = new Label();
            btnDeshacer = new Button();
            btnConfirmar = new Button();
            btnCancelarSeleccion = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSabores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaboresSeleccionados).BeginInit();
            SuspendLayout();
            // 
            // dgvSabores
            // 
            dgvSabores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSabores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSabores.Location = new Point(32, 90);
            dgvSabores.MultiSelect = false;
            dgvSabores.Name = "dgvSabores";
            dgvSabores.ReadOnly = true;
            dgvSabores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSabores.Size = new Size(244, 283);
            dgvSabores.TabIndex = 0;
            dgvSabores.SelectionChanged += dgvSabores_SelectionChanged;
            // 
            // lblSeleccionarSabores
            // 
            lblSeleccionarSabores.AutoSize = true;
            lblSeleccionarSabores.Location = new Point(32, 22);
            lblSeleccionarSabores.Name = "lblSeleccionarSabores";
            lblSeleccionarSabores.Size = new Size(202, 15);
            lblSeleccionarSabores.TabIndex = 1;
            lblSeleccionarSabores.Text = "Seleccione un sabor para el producto";
            // 
            // txtBuscarSabor
            // 
            txtBuscarSabor.Location = new Point(32, 61);
            txtBuscarSabor.Name = "txtBuscarSabor";
            txtBuscarSabor.PlaceholderText = "Buscar sabor...";
            txtBuscarSabor.Size = new Size(150, 23);
            txtBuscarSabor.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(201, 61);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAñadir
            // 
            btnAñadir.Location = new Point(282, 213);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(75, 23);
            btnAñadir.TabIndex = 4;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = true;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // dgvSaboresSeleccionados
            // 
            dgvSaboresSeleccionados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSaboresSeleccionados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaboresSeleccionados.Location = new Point(363, 90);
            dgvSaboresSeleccionados.Name = "dgvSaboresSeleccionados";
            dgvSaboresSeleccionados.ReadOnly = true;
            dgvSaboresSeleccionados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaboresSeleccionados.Size = new Size(244, 283);
            dgvSaboresSeleccionados.TabIndex = 5;
            // 
            // lblSaboresSeleccionados
            // 
            lblSaboresSeleccionados.AutoSize = true;
            lblSaboresSeleccionados.Location = new Point(363, 61);
            lblSaboresSeleccionados.Name = "lblSaboresSeleccionados";
            lblSaboresSeleccionados.Size = new Size(125, 15);
            lblSaboresSeleccionados.TabIndex = 6;
            lblSaboresSeleccionados.Text = "Sabores seleccionados";
            // 
            // btnDeshacer
            // 
            btnDeshacer.Location = new Point(282, 242);
            btnDeshacer.Name = "btnDeshacer";
            btnDeshacer.Size = new Size(75, 23);
            btnDeshacer.TabIndex = 7;
            btnDeshacer.Text = "Deshacer";
            btnDeshacer.UseVisualStyleBackColor = true;
            btnDeshacer.Click += btnDeshacer_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(499, 379);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(108, 33);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelarSeleccion
            // 
            btnCancelarSeleccion.Location = new Point(32, 383);
            btnCancelarSeleccion.Name = "btnCancelarSeleccion";
            btnCancelarSeleccion.Size = new Size(139, 33);
            btnCancelarSeleccion.TabIndex = 9;
            btnCancelarSeleccion.Text = "Cancelar seleccion";
            btnCancelarSeleccion.UseVisualStyleBackColor = true;
            btnCancelarSeleccion.Click += btnCancelarSeleccion_Click;
            // 
            // SeleccionarSaboresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 428);
            Controls.Add(btnCancelarSeleccion);
            Controls.Add(btnConfirmar);
            Controls.Add(btnDeshacer);
            Controls.Add(lblSaboresSeleccionados);
            Controls.Add(dgvSaboresSeleccionados);
            Controls.Add(btnAñadir);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarSabor);
            Controls.Add(lblSeleccionarSabores);
            Controls.Add(dgvSabores);
            Name = "SeleccionarSaboresForm";
            Text = "SeleccionarSaboresForm";
            Load += SeleccionarSaboresForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSabores).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSaboresSeleccionados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSabores;
        private Label lblSeleccionarSabores;
        private TextBox txtBuscarSabor;
        private Button btnBuscar;
        private Button btnAñadir;
        private DataGridView dgvSaboresSeleccionados;
        private Label lblSaboresSeleccionados;
        private Button btnDeshacer;
        private Button btnConfirmar;
        private Button btnCancelarSeleccion;
    }
}