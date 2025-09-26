namespace UI.Administrative_Forms
{
    partial class ModificarUsuarioForm
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
            btnModificar = new Button();
            txtCorreoElectronico = new TextBox();
            txtNombreUsuario = new TextBox();
            lblCorreoElectronico = new Label();
            lblNombreUsuario = new Label();
            lblDatosUsuario = new Label();
            lblSeleccioneUsuario = new Label();
            dgvUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
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
            btnSalir.TabIndex = 17;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Anchor = AnchorStyles.None;
            btnModificar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnModificar.ForeColor = SystemColors.ActiveCaptionText;
            btnModificar.Location = new Point(471, 343);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(106, 31);
            btnModificar.TabIndex = 16;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // txtCorreoElectronico
            // 
            txtCorreoElectronico.Anchor = AnchorStyles.None;
            txtCorreoElectronico.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtCorreoElectronico.ForeColor = SystemColors.ActiveCaptionText;
            txtCorreoElectronico.Location = new Point(325, 209);
            txtCorreoElectronico.Name = "txtCorreoElectronico";
            txtCorreoElectronico.Size = new Size(252, 24);
            txtCorreoElectronico.TabIndex = 13;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Anchor = AnchorStyles.None;
            txtNombreUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtNombreUsuario.ForeColor = SystemColors.ActiveCaptionText;
            txtNombreUsuario.Location = new Point(325, 142);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(252, 24);
            txtNombreUsuario.TabIndex = 12;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.Anchor = AnchorStyles.None;
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblCorreoElectronico.ForeColor = SystemColors.ActiveCaptionText;
            lblCorreoElectronico.Location = new Point(325, 187);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(126, 19);
            lblCorreoElectronico.TabIndex = 11;
            lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // lblNombreUsuario
            // 
            lblNombreUsuario.Anchor = AnchorStyles.None;
            lblNombreUsuario.AutoSize = true;
            lblNombreUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblNombreUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblNombreUsuario.Location = new Point(325, 120);
            lblNombreUsuario.Name = "lblNombreUsuario";
            lblNombreUsuario.Size = new Size(131, 19);
            lblNombreUsuario.TabIndex = 10;
            lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // lblDatosUsuario
            // 
            lblDatosUsuario.Anchor = AnchorStyles.None;
            lblDatosUsuario.AutoSize = true;
            lblDatosUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblDatosUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblDatosUsuario.Location = new Point(325, 79);
            lblDatosUsuario.Name = "lblDatosUsuario";
            lblDatosUsuario.Size = new Size(235, 19);
            lblDatosUsuario.TabIndex = 9;
            lblDatosUsuario.Text = "Ingrese los nuevos datos del usuario:";
            // 
            // lblSeleccioneUsuario
            // 
            lblSeleccioneUsuario.Anchor = AnchorStyles.None;
            lblSeleccioneUsuario.AutoSize = true;
            lblSeleccioneUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccioneUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccioneUsuario.Location = new Point(41, 79);
            lblSeleccioneUsuario.Name = "lblSeleccioneUsuario";
            lblSeleccioneUsuario.Size = new Size(213, 19);
            lblSeleccioneUsuario.TabIndex = 18;
            lblSeleccioneUsuario.Text = "Seleccione el usuario a modificar:";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = AnchorStyles.None;
            dgvUsuarios.BackgroundColor = Color.GhostWhite;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(41, 120);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(243, 254);
            dgvUsuarios.TabIndex = 19;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // ModificarUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblSeleccioneUsuario);
            Controls.Add(btnSalir);
            Controls.Add(btnModificar);
            Controls.Add(txtCorreoElectronico);
            Controls.Add(txtNombreUsuario);
            Controls.Add(lblCorreoElectronico);
            Controls.Add(lblNombreUsuario);
            Controls.Add(lblDatosUsuario);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(600, 450);
            Name = "ModificarUsuarioForm";
            Text = "ModificarUsuarioForm";
            Load += ModificarUsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnModificar;
        private TextBox txtCorreoElectronico;
        private TextBox txtNombreUsuario;
        private Label lblCorreoElectronico;
        private Label lblNombreUsuario;
        private Label lblDatosUsuario;
        private Label lblSeleccioneUsuario;
        private DataGridView dgvUsuarios;
    }
}