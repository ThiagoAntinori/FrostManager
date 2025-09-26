namespace UI.Administrative_Forms
{
    partial class CambiarEstadoUsuarioForm
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
            dgvUsuarios = new DataGridView();
            lblSeleccioneUsuario = new Label();
            lblSeleccionado = new Label();
            lblUsuarioSeleccionado = new Label();
            lblEstadoActual = new Label();
            lblEstadoActualUsuario = new Label();
            btnCambiarEstado = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.Anchor = AnchorStyles.None;
            dgvUsuarios.BackgroundColor = Color.GhostWhite;
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(57, 110);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(290, 254);
            dgvUsuarios.TabIndex = 21;
            dgvUsuarios.SelectionChanged += dgvUsuarios_SelectionChanged;
            // 
            // lblSeleccioneUsuario
            // 
            lblSeleccioneUsuario.Anchor = AnchorStyles.None;
            lblSeleccioneUsuario.AutoSize = true;
            lblSeleccioneUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccioneUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccioneUsuario.Location = new Point(57, 69);
            lblSeleccioneUsuario.Name = "lblSeleccioneUsuario";
            lblSeleccioneUsuario.Size = new Size(213, 19);
            lblSeleccioneUsuario.TabIndex = 20;
            lblSeleccioneUsuario.Text = "Seleccione el usuario a modificar:";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.Anchor = AnchorStyles.None;
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccionado.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccionado.Location = new Point(393, 110);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(93, 19);
            lblSeleccionado.TabIndex = 22;
            lblSeleccionado.Text = "Seleccionado:";
            // 
            // lblUsuarioSeleccionado
            // 
            lblUsuarioSeleccionado.Anchor = AnchorStyles.None;
            lblUsuarioSeleccionado.AutoSize = true;
            lblUsuarioSeleccionado.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblUsuarioSeleccionado.ForeColor = SystemColors.ActiveCaptionText;
            lblUsuarioSeleccionado.Location = new Point(393, 139);
            lblUsuarioSeleccionado.Name = "lblUsuarioSeleccionado";
            lblUsuarioSeleccionado.Size = new Size(15, 19);
            lblUsuarioSeleccionado.TabIndex = 23;
            lblUsuarioSeleccionado.Text = "-";
            // 
            // lblEstadoActual
            // 
            lblEstadoActual.AutoSize = true;
            lblEstadoActual.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstadoActual.Location = new Point(393, 194);
            lblEstadoActual.Name = "lblEstadoActual";
            lblEstadoActual.Size = new Size(94, 19);
            lblEstadoActual.TabIndex = 24;
            lblEstadoActual.Text = "Estado actual:";
            // 
            // lblEstadoActualUsuario
            // 
            lblEstadoActualUsuario.Anchor = AnchorStyles.None;
            lblEstadoActualUsuario.AutoSize = true;
            lblEstadoActualUsuario.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblEstadoActualUsuario.ForeColor = SystemColors.ActiveCaptionText;
            lblEstadoActualUsuario.Location = new Point(393, 220);
            lblEstadoActualUsuario.Name = "lblEstadoActualUsuario";
            lblEstadoActualUsuario.Size = new Size(15, 19);
            lblEstadoActualUsuario.TabIndex = 25;
            lblEstadoActualUsuario.Text = "-";
            // 
            // btnCambiarEstado
            // 
            btnCambiarEstado.Anchor = AnchorStyles.None;
            btnCambiarEstado.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnCambiarEstado.ForeColor = SystemColors.ActiveCaptionText;
            btnCambiarEstado.Location = new Point(444, 333);
            btnCambiarEstado.Name = "btnCambiarEstado";
            btnCambiarEstado.Size = new Size(117, 31);
            btnCambiarEstado.TabIndex = 26;
            btnCambiarEstado.Text = "Cambiar Estado";
            btnCambiarEstado.UseVisualStyleBackColor = true;
            btnCambiarEstado.Click += btnCambiarEstado_Click;
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
            btnSalir.TabIndex = 27;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // CambiarEstadoUsuarioForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnCambiarEstado);
            Controls.Add(lblEstadoActualUsuario);
            Controls.Add(lblEstadoActual);
            Controls.Add(lblUsuarioSeleccionado);
            Controls.Add(lblSeleccionado);
            Controls.Add(dgvUsuarios);
            Controls.Add(lblSeleccioneUsuario);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(600, 450);
            Name = "CambiarEstadoUsuarioForm";
            Text = "CambiarEstadoUsuarioForm";
            Load += CambiarEstadoUsuarioForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private Label lblSeleccioneUsuario;
        private Label lblSeleccionado;
        private Label lblUsuarioSeleccionado;
        private Label lblEstadoActual;
        private Label lblEstadoActualUsuario;
        private Button btnCambiarEstado;
        private Button btnSalir;
    }
}