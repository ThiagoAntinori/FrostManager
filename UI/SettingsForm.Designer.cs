namespace UI
{
    partial class SettingsForm
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
            gbIdioma = new GroupBox();
            btnAplicar = new Button();
            cmbIdioma = new ComboBox();
            lblSeleccionarIdioma = new Label();
            gbCorreo = new GroupBox();
            btnModificarCorreo = new Button();
            txtCorreo = new TextBox();
            lblCorreoElectronico = new Label();
            gbCambiarContraseña = new GroupBox();
            btnModificarContraseña = new Button();
            txtNuevaContraseña = new TextBox();
            txtContraseñaActual = new TextBox();
            lblNuevaContraseña = new Label();
            lblContraseñaActual = new Label();
            gbIdioma.SuspendLayout();
            gbCorreo.SuspendLayout();
            gbCambiarContraseña.SuspendLayout();
            SuspendLayout();
            // 
            // gbIdioma
            // 
            gbIdioma.Anchor = AnchorStyles.None;
            gbIdioma.Controls.Add(btnAplicar);
            gbIdioma.Controls.Add(cmbIdioma);
            gbIdioma.Controls.Add(lblSeleccionarIdioma);
            gbIdioma.Location = new Point(73, 43);
            gbIdioma.Name = "gbIdioma";
            gbIdioma.Size = new Size(467, 105);
            gbIdioma.TabIndex = 0;
            gbIdioma.TabStop = false;
            gbIdioma.Text = "IDIOMA";
            // 
            // btnAplicar
            // 
            btnAplicar.Location = new Point(357, 42);
            btnAplicar.Name = "btnAplicar";
            btnAplicar.Size = new Size(75, 23);
            btnAplicar.TabIndex = 2;
            btnAplicar.Text = "Aplicar";
            btnAplicar.UseVisualStyleBackColor = true;
            btnAplicar.Click += btnAplicar_Click;
            // 
            // cmbIdioma
            // 
            cmbIdioma.FormattingEnabled = true;
            cmbIdioma.Location = new Point(181, 42);
            cmbIdioma.Name = "cmbIdioma";
            cmbIdioma.Size = new Size(151, 23);
            cmbIdioma.TabIndex = 1;
            // 
            // lblSeleccionarIdioma
            // 
            lblSeleccionarIdioma.AutoSize = true;
            lblSeleccionarIdioma.Location = new Point(35, 45);
            lblSeleccionarIdioma.Name = "lblSeleccionarIdioma";
            lblSeleccionarIdioma.Size = new Size(118, 15);
            lblSeleccionarIdioma.TabIndex = 0;
            lblSeleccionarIdioma.Text = "Seleccione el idioma:";
            // 
            // gbCorreo
            // 
            gbCorreo.Anchor = AnchorStyles.None;
            gbCorreo.Controls.Add(btnModificarCorreo);
            gbCorreo.Controls.Add(txtCorreo);
            gbCorreo.Controls.Add(lblCorreoElectronico);
            gbCorreo.Location = new Point(73, 185);
            gbCorreo.Name = "gbCorreo";
            gbCorreo.Size = new Size(467, 97);
            gbCorreo.TabIndex = 1;
            gbCorreo.TabStop = false;
            gbCorreo.Text = "CAMBIAR CORREO ELECTRONICO";
            // 
            // btnModificarCorreo
            // 
            btnModificarCorreo.Location = new Point(357, 40);
            btnModificarCorreo.Name = "btnModificarCorreo";
            btnModificarCorreo.Size = new Size(75, 23);
            btnModificarCorreo.TabIndex = 4;
            btnModificarCorreo.Text = "Modificar";
            btnModificarCorreo.UseVisualStyleBackColor = true;
            btnModificarCorreo.Click += btnModificarCorreo_Click;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(181, 40);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(151, 23);
            txtCorreo.TabIndex = 1;
            // 
            // lblCorreoElectronico
            // 
            lblCorreoElectronico.AutoSize = true;
            lblCorreoElectronico.Location = new Point(35, 43);
            lblCorreoElectronico.Name = "lblCorreoElectronico";
            lblCorreoElectronico.Size = new Size(108, 15);
            lblCorreoElectronico.TabIndex = 0;
            lblCorreoElectronico.Text = "Correo electrónico:";
            // 
            // gbCambiarContraseña
            // 
            gbCambiarContraseña.Anchor = AnchorStyles.None;
            gbCambiarContraseña.Controls.Add(btnModificarContraseña);
            gbCambiarContraseña.Controls.Add(txtNuevaContraseña);
            gbCambiarContraseña.Controls.Add(txtContraseñaActual);
            gbCambiarContraseña.Controls.Add(lblNuevaContraseña);
            gbCambiarContraseña.Controls.Add(lblContraseñaActual);
            gbCambiarContraseña.Location = new Point(73, 322);
            gbCambiarContraseña.Name = "gbCambiarContraseña";
            gbCambiarContraseña.Size = new Size(467, 122);
            gbCambiarContraseña.TabIndex = 2;
            gbCambiarContraseña.TabStop = false;
            gbCambiarContraseña.Text = "CAMBIAR CONTRASEÑA";
            // 
            // btnModificarContraseña
            // 
            btnModificarContraseña.Location = new Point(357, 68);
            btnModificarContraseña.Name = "btnModificarContraseña";
            btnModificarContraseña.Size = new Size(75, 23);
            btnModificarContraseña.TabIndex = 4;
            btnModificarContraseña.Text = "Modificar";
            btnModificarContraseña.UseVisualStyleBackColor = true;
            btnModificarContraseña.Click += btnModificarContraseña_Click;
            // 
            // txtNuevaContraseña
            // 
            txtNuevaContraseña.Location = new Point(181, 65);
            txtNuevaContraseña.Name = "txtNuevaContraseña";
            txtNuevaContraseña.Size = new Size(151, 23);
            txtNuevaContraseña.TabIndex = 3;
            // 
            // txtContraseñaActual
            // 
            txtContraseñaActual.Location = new Point(181, 33);
            txtContraseñaActual.Name = "txtContraseñaActual";
            txtContraseñaActual.Size = new Size(151, 23);
            txtContraseñaActual.TabIndex = 2;
            // 
            // lblNuevaContraseña
            // 
            lblNuevaContraseña.AutoSize = true;
            lblNuevaContraseña.Location = new Point(35, 68);
            lblNuevaContraseña.Name = "lblNuevaContraseña";
            lblNuevaContraseña.Size = new Size(105, 15);
            lblNuevaContraseña.TabIndex = 1;
            lblNuevaContraseña.Text = "Nueva contraseña:";
            // 
            // lblContraseñaActual
            // 
            lblContraseñaActual.AutoSize = true;
            lblContraseñaActual.Location = new Point(35, 36);
            lblContraseñaActual.Name = "lblContraseñaActual";
            lblContraseñaActual.Size = new Size(105, 15);
            lblContraseñaActual.TabIndex = 0;
            lblContraseñaActual.Text = "Contraseña actual:";
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(gbCambiarContraseña);
            Controls.Add(gbCorreo);
            Controls.Add(gbIdioma);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            Load += SettingsForm_Load;
            gbIdioma.ResumeLayout(false);
            gbIdioma.PerformLayout();
            gbCorreo.ResumeLayout(false);
            gbCorreo.PerformLayout();
            gbCambiarContraseña.ResumeLayout(false);
            gbCambiarContraseña.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbIdioma;
        private Button btnAplicar;
        private ComboBox cmbIdioma;
        private Label lblSeleccionarIdioma;
        private GroupBox gbCorreo;
        private Button btnModificarCorreo;
        private TextBox txtCorreo;
        private Label lblCorreoElectronico;
        private GroupBox gbCambiarContraseña;
        private Label lblNuevaContraseña;
        private Label lblContraseñaActual;
        private Button btnModificarContraseña;
        private TextBox txtNuevaContraseña;
        private TextBox txtContraseñaActual;
    }
}