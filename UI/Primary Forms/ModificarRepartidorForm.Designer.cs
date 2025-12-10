namespace UI.Primary_Forms
{
    partial class ModificarRepartidorForm
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
            lblDatosRepartidor = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnModificar = new Button();
            btnSalir = new Button();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            dgvRepartidores = new DataGridView();
            lblBuscar = new Label();
            txtBuscarDni = new TextBox();
            btnBuscar = new Button();
            btnCambiarEstado = new Button();
            lblEstadoValor = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).BeginInit();
            SuspendLayout();
            // 
            // lblDatosRepartidor
            // 
            lblDatosRepartidor.Anchor = AnchorStyles.None;
            lblDatosRepartidor.AutoSize = true;
            lblDatosRepartidor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDatosRepartidor.ForeColor = SystemColors.WindowText;
            lblDatosRepartidor.Location = new Point(350, 81);
            lblDatosRepartidor.Name = "lblDatosRepartidor";
            lblDatosRepartidor.Size = new Size(184, 17);
            lblDatosRepartidor.TabIndex = 0;
            lblDatosRepartidor.Text = "Modifique los datos actuales:";
            // 
            // lblNombre
            // 
            lblNombre.Anchor = AnchorStyles.None;
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.WindowText;
            lblNombre.Location = new Point(350, 122);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Anchor = AnchorStyles.None;
            txtNombre.ForeColor = SystemColors.WindowText;
            txtNombre.Location = new Point(350, 142);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(225, 23);
            txtNombre.TabIndex = 2;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.BackColor = Color.Lavender;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 9.75F);
            btnModificar.ForeColor = SystemColors.WindowText;
            btnModificar.Location = new Point(449, 477);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(126, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            txtApellido.Anchor = AnchorStyles.None;
            txtApellido.ForeColor = SystemColors.WindowText;
            txtApellido.Location = new Point(350, 208);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(225, 23);
            txtApellido.TabIndex = 6;
            // 
            // lblApellido
            // 
            lblApellido.Anchor = AnchorStyles.None;
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.WindowText;
            lblApellido.Location = new Point(350, 188);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 17);
            lblApellido.TabIndex = 5;
            lblApellido.Text = "Apellido";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.ForeColor = SystemColors.WindowText;
            txtEmail.Location = new Point(350, 276);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(225, 23);
            txtEmail.TabIndex = 10;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.None;
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.WindowText;
            lblEmail.Location = new Point(350, 256);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(40, 17);
            lblEmail.TabIndex = 9;
            lblEmail.Text = "Email";
            // 
            // dgvRepartidores
            // 
            dgvRepartidores.Anchor = AnchorStyles.None;
            dgvRepartidores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRepartidores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRepartidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepartidores.Location = new Point(45, 115);
            dgvRepartidores.MultiSelect = false;
            dgvRepartidores.Name = "dgvRepartidores";
            dgvRepartidores.ReadOnly = true;
            dgvRepartidores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepartidores.Size = new Size(270, 321);
            dgvRepartidores.TabIndex = 13;
            dgvRepartidores.SelectionChanged += dgvRepartidores_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Anchor = AnchorStyles.None;
            lblBuscar.AutoSize = true;
            lblBuscar.Font = new Font("Segoe UI", 9.75F);
            lblBuscar.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscar.Location = new Point(45, 456);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(100, 17);
            lblBuscar.TabIndex = 14;
            lblBuscar.Text = "Buscar por DNI:";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Anchor = AnchorStyles.None;
            txtBuscarDni.Location = new Point(45, 483);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(187, 23);
            txtBuscarDni.TabIndex = 15;
            // 
            // btnBuscar
            // 
            btnBuscar.Anchor = AnchorStyles.None;
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(240, 483);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 16;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Anchor = AnchorStyles.None;
            btnCambiarEstado.BackColor = Color.LightCyan;
            btnCambiarEstado.FlatStyle = FlatStyle.Popup;
            btnCambiarEstado.Font = new Font("Segoe UI", 9.75F);
            btnCambiarEstado.ForeColor = SystemColors.WindowText;
            btnCambiarEstado.Location = new Point(459, 332);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(116, 30);
            btnCambiarEstado.TabIndex = 17;
            btnCambiarEstado.Text = "Cambiar estado";
            btnCambiarEstado.UseVisualStyleBackColor = false;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
            // 
            // lblEstadoValor
            // 
            lblEstadoValor.Anchor = AnchorStyles.None;
            lblEstadoValor.AutoSize = true;
            lblEstadoValor.Location = new Point(350, 341);
            lblEstadoValor.Name = "lblEstadoValor";
            lblEstadoValor.Size = new Size(12, 15);
            lblEstadoValor.TabIndex = 18;
            lblEstadoValor.Text = "-";
            // 
            // ModificarRepartidorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(lblEstadoValor);
            Controls.Add(btnCambiarEstado);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarDni);
            Controls.Add(lblBuscar);
            Controls.Add(dgvRepartidores);
            Controls.Add(txtEmail);
            Controls.Add(lblEmail);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosRepartidor);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarRepartidorForm";
            Text = "ModificarRepartidorForm";
            Load += ModificarRepartidorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatosRepartidor;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnModificar;
        private Button btnSalir;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtEmail;
        private Label lblEmail;
        private DataGridView dgvRepartidores;
        private Label lblBuscar;
        private TextBox txtBuscarDni;
        private Button btnBuscar;
        private Button btnCambiarEstado;
        private Label lblEstadoValor;
    }
}