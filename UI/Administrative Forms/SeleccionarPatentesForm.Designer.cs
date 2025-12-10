namespace UI.Administrative_Forms
{
    partial class SeleccionarPatentesForm
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
            dgvPatentesDisponibles = new DataGridView();
            lblPatentesDisponibles = new Label();
            lblPatentesSeleccionadas = new Label();
            dgvPatentesSeleccionadas = new DataGridView();
            btnAñadir = new Button();
            btnEliminar = new Button();
            btnConfirmar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatentesDisponibles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPatentesSeleccionadas).BeginInit();
            SuspendLayout();
            // 
            // dgvPatentesDisponibles
            // 
            dgvPatentesDisponibles.AllowUserToAddRows = false;
            dgvPatentesDisponibles.AllowUserToDeleteRows = false;
            dgvPatentesDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvPatentesDisponibles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatentesDisponibles.BackgroundColor = Color.White;
            dgvPatentesDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatentesDisponibles.Location = new Point(30, 80);
            dgvPatentesDisponibles.MultiSelect = false;
            dgvPatentesDisponibles.Name = "dgvPatentesDisponibles";
            dgvPatentesDisponibles.ReadOnly = true;
            dgvPatentesDisponibles.RowHeadersVisible = false;
            dgvPatentesDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatentesDisponibles.Size = new Size(320, 340);
            dgvPatentesDisponibles.TabIndex = 0;
            dgvPatentesDisponibles.SelectionChanged += dgvPatentesDisponibles_SelectionChanged;
            // 
            // lblPatentesDisponibles
            // 
            lblPatentesDisponibles.AutoSize = true;
            lblPatentesDisponibles.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatentesDisponibles.ForeColor = Color.FromArgb(0, 50, 100);
            lblPatentesDisponibles.Location = new Point(30, 40);
            lblPatentesDisponibles.Name = "lblPatentesDisponibles";
            lblPatentesDisponibles.Size = new Size(162, 21);
            lblPatentesDisponibles.TabIndex = 1;
            lblPatentesDisponibles.Text = "Patentes Disponibles";
            // 
            // lblPatentesSeleccionadas
            // 
            lblPatentesSeleccionadas.AutoSize = true;
            lblPatentesSeleccionadas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPatentesSeleccionadas.ForeColor = Color.FromArgb(0, 50, 100);
            lblPatentesSeleccionadas.Location = new Point(410, 40);
            lblPatentesSeleccionadas.Name = "lblPatentesSeleccionadas";
            lblPatentesSeleccionadas.Size = new Size(180, 21);
            lblPatentesSeleccionadas.TabIndex = 2;
            lblPatentesSeleccionadas.Text = "Patentes Seleccionadas";
            // 
            // dgvPatentesSeleccionadas
            // 
            dgvPatentesSeleccionadas.AllowUserToAddRows = false;
            dgvPatentesSeleccionadas.AllowUserToDeleteRows = false;
            dgvPatentesSeleccionadas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            dgvPatentesSeleccionadas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatentesSeleccionadas.BackgroundColor = Color.White;
            dgvPatentesSeleccionadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatentesSeleccionadas.Location = new Point(410, 80);
            dgvPatentesSeleccionadas.MultiSelect = false;
            dgvPatentesSeleccionadas.Name = "dgvPatentesSeleccionadas";
            dgvPatentesSeleccionadas.ReadOnly = true;
            dgvPatentesSeleccionadas.RowHeadersVisible = false;
            dgvPatentesSeleccionadas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatentesSeleccionadas.Size = new Size(320, 340);
            dgvPatentesSeleccionadas.TabIndex = 3;
            dgvPatentesSeleccionadas.SelectionChanged += dgvPatentesSeleccionadas_SelectionChanged;
            // 
            // btnAñadir
            // 
            btnAñadir.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAñadir.BackColor = Color.FromArgb(0, 150, 255);
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
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
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
            btnConfirmar.BackColor = Color.FromArgb(40, 167, 69);
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
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(760, 500);
            Controls.Add(btnConfirmar);
            Controls.Add(btnEliminar);
            Controls.Add(btnAñadir);
            Controls.Add(dgvPatentesSeleccionadas);
            Controls.Add(lblPatentesSeleccionadas);
            Controls.Add(lblPatentesDisponibles);
            Controls.Add(dgvPatentesDisponibles);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(776, 539);
            Name = "SeleccionarPatentesForm";
            Text = "ADMINISTRACIÓN | Seleccionar Patentes";
            Load += SeleccionarPatentesForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatentesDisponibles).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPatentesSeleccionadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPatentesDisponibles;
        private Label lblPatentesDisponibles;
        private Label lblPatentesSeleccionadas;
        private DataGridView dgvPatentesSeleccionadas;
        private Button btnAñadir;
        private Button btnEliminar;
        private Button btnConfirmar;
    }
}