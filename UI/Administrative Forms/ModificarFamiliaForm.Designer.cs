namespace UI.Administrative_Forms
{
    partial class ModificarFamiliaForm
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
            lblSeleccioneFamilia = new Label();
            lblDescripcionFamilia = new Label();
            txtDescripcionFamilia = new TextBox();
            btnModificar = new Button();
            btnSalir = new Button();
            btnSeleccionarFamilias = new Button();
            btnSeleccionarPatentes = new Button();
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
            // lblSeleccioneFamilia
            // 
            lblSeleccioneFamilia.Anchor = AnchorStyles.None;
            lblSeleccioneFamilia.AutoSize = true;
            lblSeleccioneFamilia.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccioneFamilia.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccioneFamilia.Location = new Point(50, 76);
            lblSeleccioneFamilia.Name = "lblSeleccioneFamilia";
            lblSeleccioneFamilia.Size = new Size(185, 19);
            lblSeleccioneFamilia.TabIndex = 0;
            lblSeleccioneFamilia.Text = "Seleccione la familia a editar:";
            // 
            // lblDescripcionFamilia
            // 
            lblDescripcionFamilia.Anchor = AnchorStyles.None;
            lblDescripcionFamilia.AutoSize = true;
            lblDescripcionFamilia.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblDescripcionFamilia.ForeColor = SystemColors.ActiveCaptionText;
            lblDescripcionFamilia.Location = new Point(331, 98);
            lblDescripcionFamilia.Name = "lblDescripcionFamilia";
            lblDescripcionFamilia.Size = new Size(161, 19);
            lblDescripcionFamilia.TabIndex = 2;
            lblDescripcionFamilia.Text = "Descripción de la familia:";
            // 
            // txtDescripcionFamilia
            // 
            txtDescripcionFamilia.Anchor = AnchorStyles.None;
            txtDescripcionFamilia.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtDescripcionFamilia.ForeColor = SystemColors.ActiveCaptionText;
            txtDescripcionFamilia.Location = new Point(331, 120);
            txtDescripcionFamilia.Name = "txtDescripcionFamilia";
            txtDescripcionFamilia.Size = new Size(220, 24);
            txtDescripcionFamilia.TabIndex = 3;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Location = new Point(444, 346);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(106, 31);
            btnModificar.TabIndex = 6;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
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
            // btnSeleccionarFamilias
            // 
            btnSeleccionarFamilias.Anchor = AnchorStyles.None;
            btnSeleccionarFamilias.Location = new Point(331, 217);
            btnSeleccionarFamilias.Name = "btnSeleccionarFamilias";
            btnSeleccionarFamilias.Size = new Size(199, 39);
            btnSeleccionarFamilias.TabIndex = 9;
            btnSeleccionarFamilias.Text = "Seleccionar Familias";
            btnSeleccionarFamilias.UseVisualStyleBackColor = true;
            btnSeleccionarFamilias.Click += btnSeleccionarFamilias_Click;
            // 
            // btnSeleccionarPatentes
            // 
            btnSeleccionarPatentes.Anchor = AnchorStyles.None;
            btnSeleccionarPatentes.Location = new Point(331, 172);
            btnSeleccionarPatentes.Name = "btnSeleccionarPatentes";
            btnSeleccionarPatentes.Size = new Size(199, 39);
            btnSeleccionarPatentes.TabIndex = 8;
            btnSeleccionarPatentes.Text = "Seleccionar Patentes";
            btnSeleccionarPatentes.UseVisualStyleBackColor = true;
            btnSeleccionarPatentes.Click += btnSeleccionarPatentes_Click;
            // 
            // ModificarFamiliaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSeleccionarFamilias);
            Controls.Add(btnSeleccionarPatentes);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(txtDescripcionFamilia);
            Controls.Add(lblDescripcionFamilia);
            Controls.Add(lblSeleccioneFamilia);
            Controls.Add(dgvFamilias);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarFamiliaForm";
            Text = "ModificarFamiliaForm";
            Load += ModificarFamiliaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFamilias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvFamilias;
        private Label lblSeleccioneFamilia;
        private Label lblDescripcionFamilia;
        private TextBox txtDescripcionFamilia;
        private Button btnModificar;
        private Button btnSalir;

        #endregion

        private Button btnSeleccionarFamilias;
        private Button btnSeleccionarPatentes;
    }
}