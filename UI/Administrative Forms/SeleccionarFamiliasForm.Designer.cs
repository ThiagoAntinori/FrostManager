namespace UI.Administrative_Forms
{
    partial class SeleccionarFamiliasForm
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
            dgvFamiliasDisponibles = new DataGridView();
            lblFamiliasDisponibles = new Label();
            lblFamiliasSeleccionadas = new Label();
            dgvFamiliasSeleccionadas = new DataGridView();
            btnAñadir = new Button();
            btnEliminar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFamiliasDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFamiliasSeleccionadas).BeginInit();
            SuspendLayout();
            // 
            // dgvPatentesDisponibles
            // 
            dgvFamiliasDisponibles.AllowUserToAddRows = false;
            dgvFamiliasDisponibles.AllowUserToDeleteRows = false;
            dgvFamiliasDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvFamiliasDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFamiliasDisponibles.BackgroundColor = Color.White;
            dgvFamiliasDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFamiliasDisponibles.Location = new Point(30, 80);
            dgvFamiliasDisponibles.MultiSelect = false;
            dgvFamiliasDisponibles.Name = "dgvFamiliasDisponibles";
            dgvFamiliasDisponibles.ReadOnly = true;
            dgvFamiliasDisponibles.RowHeadersVisible = false;
            dgvFamiliasDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFamiliasDisponibles.Size = new Size(320, 340);
            dgvFamiliasDisponibles.TabIndex = 0;
            dgvFamiliasDisponibles.SelectionChanged += dgvFamiliasDisponibles_SelectionChanged;
            // 
            // lblPatentesDisponibles
            // 
            lblFamiliasDisponibles.AutoSize = true;
            lblFamiliasDisponibles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFamiliasDisponibles.ForeColor = Color.FromArgb(0, 50, 100); // Azul Oscuro
            lblFamiliasDisponibles.Location = new Point(30, 40);
            lblFamiliasDisponibles.Name = "lblFamiliasDisponibles";
            lblFamiliasDisponibles.Size = new Size(168, 21);
            lblFamiliasDisponibles.TabIndex = 1;
            lblFamiliasDisponibles.Text = "Familias Disponibles";
            // 
            // lblPatentesSeleccionadas
            // 
            lblFamiliasSeleccionadas.AutoSize = true;
            lblFamiliasSeleccionadas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFamiliasSeleccionadas.ForeColor = Color.FromArgb(0, 50, 100); // Azul Oscuro
            lblFamiliasSeleccionadas.Location = new Point(410, 40);
            lblFamiliasSeleccionadas.Name = "lblFamiliasSeleccionadas";
            lblFamiliasSeleccionadas.Size = new Size(190, 21);
            lblFamiliasSeleccionadas.TabIndex = 2;
            lblFamiliasSeleccionadas.Text = "Familias Seleccionadas";
            // 
            // dgvPatentesSeleccionadas
            // 
            dgvFamiliasSeleccionadas.AllowUserToAddRows = false;
            dgvFamiliasSeleccionadas.AllowUserToDeleteRows = false;
            dgvFamiliasSeleccionadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvFamiliasSeleccionadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFamiliasSeleccionadas.BackgroundColor = Color.White;
            dgvFamiliasSeleccionadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFamiliasSeleccionadas.Location = new Point(410, 80);
            dgvFamiliasSeleccionadas.MultiSelect = false;
            dgvFamiliasSeleccionadas.Name = "dgvFamiliasSeleccionadas";
            dgvFamiliasSeleccionadas.ReadOnly = true;
            dgvFamiliasSeleccionadas.RowHeadersVisible = false;
            dgvFamiliasSeleccionadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFamiliasSeleccionadas.Size = new Size(320, 340);
            dgvFamiliasSeleccionadas.TabIndex = 3;
            dgvFamiliasSeleccionadas.SelectionChanged += dgvFamiliasSeleccionadas_SelectionChanged;
            // 
            // btnAñadir
            // 
            btnAñadir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAñadir.BackColor = Color.FromArgb(0, 150, 255); // Azul Primario
            btnAñadir.FlatAppearance.BorderSize = 0;
            btnAñadir.FlatStyle = FlatStyle.Flat;
            btnAñadir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAñadir.ForeColor = Color.White;
            btnAñadir.Location = new Point(256, 435);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(94, 35);
            btnAñadir.TabIndex = 4;
            btnAñadir.Text = "Añadir";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69); // Rojo de Peligro
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(410, 435);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 35);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnConfirmar.BackColor = Color.FromArgb(40, 167, 69); // Verde de Éxito
            btnConfirmar.FlatAppearance.BorderSize = 0;
            btnConfirmar.FlatStyle = FlatStyle.Flat;
            btnConfirmar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirmar.ForeColor = Color.White;
            btnConfirmar.Location = new Point(578, 435);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(152, 35);
            btnConfirmar.TabIndex = 6;
            btnConfirmar.Text = "CONFIRMAR CAMBIOS";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // SeleccionarPatentesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke; // Fondo administrativo
            ClientSize = new Size(760, 500); // Ajuste de tamaño para mejor simetría
            Controls.Add(btnConfirmar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAñadir);
            Controls.Add(dgvFamiliasSeleccionadas);
            Controls.Add(lblFamiliasSeleccionadas);
            Controls.Add(lblFamiliasDisponibles);
            Controls.Add(dgvFamiliasDisponibles);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(776, 539);
            Name = "SeleccionarFamiliasForm";
            Text = "ADMINISTRACIÓN | Seleccionar Familias";
            Load += SeleccionarFamiliasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFamiliasDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFamiliasSeleccionadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFamiliasDisponibles;
        private Label lblFamiliasDisponibles;
        private Label lblFamiliasSeleccionadas;
        private DataGridView dgvFamiliasSeleccionadas;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnConfirmar;
    }
}