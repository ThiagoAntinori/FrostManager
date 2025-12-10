namespace UI.Administrative_Forms
{
    partial class EliminarFamiliaForm
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
            dgvFamilias = new DataGridView();
            lblSeleccioneFamiliaEliminar = new Label();
            lblFamiliaSeleccionada = new Label();
            btnEliminar = new Button();
            btnSalir = new Button();
            lblFamiliaSeleccionadaNombre = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFamilias).BeginInit();
            SuspendLayout();
            // 
            // dgvFamilias
            // 
            dgvFamilias.Anchor = AnchorStyles.None;
            dgvFamilias.BackgroundColor = Color.GhostWhite;
            dgvFamilias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFamilias.Location = new Point(50, 98);
            dgvFamilias.Name = "dgvFamilias";
            dgvFamilias.ReadOnly = true;
            dgvFamilias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFamilias.Size = new Size(250, 279);
            dgvFamilias.TabIndex = 1;
            dgvFamilias.SelectionChanged += dgvFamilias_SelectionChanged;
            // 
            // lblSeleccioneFamiliaEliminar
            // 
            lblSeleccioneFamiliaEliminar.Anchor = AnchorStyles.None;
            lblSeleccioneFamiliaEliminar.AutoSize = true;
            lblSeleccioneFamiliaEliminar.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccioneFamiliaEliminar.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccioneFamiliaEliminar.Location = new Point(50, 76);
            lblSeleccioneFamiliaEliminar.Name = "lblSeleccioneFamiliaEliminar";
            lblSeleccioneFamiliaEliminar.Size = new Size(198, 19);
            lblSeleccioneFamiliaEliminar.TabIndex = 0;
            lblSeleccioneFamiliaEliminar.Text = "Seleccione la familia a eliminar:";
            // 
            // lblFamiliaSeleccionada
            // 
            lblFamiliaSeleccionada.Anchor = AnchorStyles.None;
            lblFamiliaSeleccionada.AutoSize = true;
            lblFamiliaSeleccionada.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblFamiliaSeleccionada.ForeColor = SystemColors.ActiveCaptionText;
            lblFamiliaSeleccionada.Location = new Point(331, 98);
            lblFamiliaSeleccionada.Name = "lblFamiliaSeleccionada";
            lblFamiliaSeleccionada.Size = new Size(136, 19);
            lblFamiliaSeleccionada.TabIndex = 2;
            lblFamiliaSeleccionada.Text = "Familia seleccionada:";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(444, 346);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(106, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.Brown;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnSalir.Location = new Point(513, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 27);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // lblFamiliaSeleccionadaNombre
            // 
            lblFamiliaSeleccionadaNombre.AutoSize = true;
            lblFamiliaSeleccionadaNombre.Location = new Point(331, 134);
            lblFamiliaSeleccionadaNombre.Name = "lblFamiliaSeleccionadaNombre";
            lblFamiliaSeleccionadaNombre.Size = new Size(12, 15);
            lblFamiliaSeleccionadaNombre.TabIndex = 8;
            lblFamiliaSeleccionadaNombre.Text = "-";
            // 
            // EliminarFamiliaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(lblFamiliaSeleccionadaNombre);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(lblFamiliaSeleccionada);
            Controls.Add(lblSeleccioneFamiliaEliminar);
            Controls.Add(dgvFamilias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EliminarFamiliaForm";
            Text = "ModificarFamiliaForm";
            Load += EliminarFamiliaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFamilias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvFamilias;
        private Label lblSeleccioneFamiliaEliminar;
        private Label lblFamiliaSeleccionada;
        private Button btnEliminar;
        private Button btnSalir;

        #endregion

        private Label lblFamiliaSeleccionadaNombre;
    }
}