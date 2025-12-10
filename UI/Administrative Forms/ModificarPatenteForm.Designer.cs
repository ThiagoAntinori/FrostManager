namespace UI.Administrative_Forms
{
    partial class ModificarPatenteForm
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
            dgvPatentes = new DataGridView();
            lblSeleccionePatente = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblMenuItemName = new Label();
            txtMenuItemName = new TextBox();
            lblFormName = new Label();
            txtFormName = new TextBox();
            btnModificar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatentes).BeginInit();
            SuspendLayout();
            // 
            // dgvPatentes
            // 
            dgvPatentes.Anchor = AnchorStyles.None;
            dgvPatentes.BackgroundColor = Color.GhostWhite;
            dgvPatentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatentes.Location = new Point(50, 98);
            dgvPatentes.Name = "dgvPatentes";
            dgvPatentes.ReadOnly = true;
            dgvPatentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatentes.Size = new Size(241, 278);
            dgvPatentes.TabIndex = 1;
            dgvPatentes.SelectionChanged += dgvPatentes_SelectionChanged;
            // 
            // lblSeleccionePatente
            // 
            lblSeleccionePatente.Anchor = AnchorStyles.None;
            lblSeleccionePatente.AutoSize = true;
            lblSeleccionePatente.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccionePatente.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccionePatente.Location = new Point(50, 76);
            lblSeleccionePatente.Name = "lblSeleccionePatente";
            lblSeleccionePatente.Size = new Size(192, 19);
            lblSeleccionePatente.TabIndex = 0;
            lblSeleccionePatente.Text = "Seleccione la patente a editar:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            lblDescripcion.Location = new Point(320, 98);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(84, 19);
            lblDescripcion.TabIndex = 2;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            txtDescripcion.Location = new Point(320, 120);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(230, 24);
            txtDescripcion.TabIndex = 3;
            // 
            // lblMenuItemName
            // 
            lblMenuItemName.Anchor = AnchorStyles.None;
            lblMenuItemName.AutoSize = true;
            lblMenuItemName.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblMenuItemName.ForeColor = SystemColors.ActiveCaptionText;
            lblMenuItemName.Location = new Point(320, 233);
            lblMenuItemName.Name = "lblMenuItemName";
            lblMenuItemName.Size = new Size(135, 19);
            lblMenuItemName.TabIndex = 4;
            lblMenuItemName.Text = "Nombre en el menú:";
            // 
            // txtMenuItemName
            // 
            txtMenuItemName.Anchor = AnchorStyles.None;
            txtMenuItemName.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtMenuItemName.ForeColor = SystemColors.ActiveCaptionText;
            txtMenuItemName.Location = new Point(320, 255);
            txtMenuItemName.Name = "txtMenuItemName";
            txtMenuItemName.Size = new Size(230, 24);
            txtMenuItemName.TabIndex = 5;
            // 
            // lblFormName
            // 
            lblFormName.Anchor = AnchorStyles.None;
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblFormName.ForeColor = SystemColors.ActiveCaptionText;
            lblFormName.Location = new Point(320, 164);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(153, 19);
            lblFormName.TabIndex = 6;
            lblFormName.Text = "Nombre del formulario:";
            // 
            // txtFormName
            // 
            txtFormName.Anchor = AnchorStyles.None;
            txtFormName.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtFormName.ForeColor = SystemColors.ActiveCaptionText;
            txtFormName.Location = new Point(320, 186);
            txtFormName.Name = "txtFormName";
            txtFormName.Size = new Size(230, 24);
            txtFormName.TabIndex = 7;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Location = new Point(444, 345);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(106, 31);
            btnModificar.TabIndex = 8;
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
            btnSalir.TabIndex = 9;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // ModificarPatenteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(txtFormName);
            Controls.Add(lblFormName);
            Controls.Add(txtMenuItemName);
            Controls.Add(lblMenuItemName);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblSeleccionePatente);
            Controls.Add(dgvPatentes);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarPatenteForm";
            Text = "ModificarPatenteForm";
            Load += ModificarPatenteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvPatentes;
        private Label lblSeleccionePatente;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblMenuItemName;
        private TextBox txtMenuItemName;
        private Label lblFormName;
        private TextBox txtFormName;
        private Button btnModificar;
        private Button btnSalir;

        #endregion
    }
}