namespace UI.Administrative_Forms
{
    partial class VerBitacoraForm
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
            lblFiltroNivel = new Label();
            cmbFiltroNivel = new ComboBox();
            dgvBitacora = new DataGridView();
            btnVerDetalles = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            SuspendLayout();
            // 
            // lblFiltroNivel
            // 
            lblFiltroNivel.Anchor = AnchorStyles.None;
            lblFiltroNivel.AutoSize = true;
            lblFiltroNivel.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblFiltroNivel.ForeColor = SystemColors.ActiveCaptionText;
            lblFiltroNivel.Location = new Point(50, 76);
            lblFiltroNivel.Name = "lblFiltroNivel";
            lblFiltroNivel.Size = new Size(107, 19);
            lblFiltroNivel.TabIndex = 0;
            lblFiltroNivel.Text = "Filtrar por Nivel:";
            // 
            // cmbFiltroNivel
            // 
            cmbFiltroNivel.Anchor = AnchorStyles.None;
            cmbFiltroNivel.Font = new Font("Microsoft YaHei UI", 9.75F);
            cmbFiltroNivel.ForeColor = SystemColors.ActiveCaptionText;
            cmbFiltroNivel.FormattingEnabled = true;
            cmbFiltroNivel.Location = new Point(162, 73);
            cmbFiltroNivel.Name = "cmbFiltroNivel";
            cmbFiltroNivel.Size = new Size(150, 27);
            cmbFiltroNivel.TabIndex = 1;
            cmbFiltroNivel.SelectedValueChanged += cmbFiltroNivel_SelectedValueChanged;
            // 
            // dgvBitacora
            // 
            dgvBitacora.Anchor = AnchorStyles.None;
            dgvBitacora.BackgroundColor = Color.GhostWhite;
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBitacora.Location = new Point(50, 110);
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBitacora.Size = new Size(500, 254);
            dgvBitacora.TabIndex = 2;
            dgvBitacora.SelectionChanged += dgvBitacora_SelectionChanged;
            // 
            // btnVerDetalles
            // 
            btnVerDetalles.Anchor = AnchorStyles.None;
            btnVerDetalles.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnVerDetalles.ForeColor = SystemColors.ActiveCaptionText;
            btnVerDetalles.Location = new Point(444, 380);
            btnVerDetalles.Name = "btnVerDetalles";
            btnVerDetalles.Size = new Size(106, 31);
            btnVerDetalles.TabIndex = 3;
            btnVerDetalles.Text = "Ver Detalles";
            btnVerDetalles.UseVisualStyleBackColor = true;
            btnVerDetalles.Click += btnVerDetalles_Click_1;
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
            btnSalir.TabIndex = 4;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // VerBitacoraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnVerDetalles);
            Controls.Add(dgvBitacora);
            Controls.Add(cmbFiltroNivel);
            Controls.Add(lblFiltroNivel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerBitacoraForm";
            Text = "Ver Bitacora";
            Load += VerBitacoraForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblFiltroNivel;
        private ComboBox cmbFiltroNivel;
        private DataGridView dgvBitacora;
        private Button btnVerDetalles;
        private Button btnSalir;

        #endregion
    }
}