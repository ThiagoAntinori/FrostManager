namespace UI.Administrative_Forms
{
    partial class RegistrarPatenteForm
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
            lblDatosPatente = new Label();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblMenuItemName = new Label();
            txtMenuItemName = new TextBox();
            lblFormName = new Label();
            txtFormName = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblDatosPatente
            // 
            lblDatosPatente.Anchor = AnchorStyles.None;
            lblDatosPatente.AutoSize = true;
            lblDatosPatente.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblDatosPatente.ForeColor = SystemColors.ActiveCaptionText;
            lblDatosPatente.Location = new Point(172, 76);
            lblDatosPatente.Name = "lblDatosPatente";
            lblDatosPatente.Size = new Size(200, 19);
            lblDatosPatente.TabIndex = 0;
            lblDatosPatente.Text = "Ingrese los datos de la patente:";
            // 
            // lblDescripcion
            // 
            lblDescripcion.Anchor = AnchorStyles.None;
            lblDescripcion.AutoSize = true;
            lblDescripcion.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            lblDescripcion.Location = new Point(172, 127);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(84, 19);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Anchor = AnchorStyles.None;
            txtDescripcion.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtDescripcion.ForeColor = SystemColors.ActiveCaptionText;
            txtDescripcion.Location = new Point(172, 149);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(252, 24);
            txtDescripcion.TabIndex = 2;
            // 
            // lblMenuItemName
            // 
            lblMenuItemName.Anchor = AnchorStyles.None;
            lblMenuItemName.AutoSize = true;
            lblMenuItemName.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblMenuItemName.ForeColor = SystemColors.ActiveCaptionText;
            lblMenuItemName.Location = new Point(172, 194);
            lblMenuItemName.Name = "lblMenuItemName";
            lblMenuItemName.Size = new Size(135, 19);
            lblMenuItemName.TabIndex = 3;
            lblMenuItemName.Text = "Nombre en el menú:";
            // 
            // txtMenuItemName
            // 
            txtMenuItemName.Anchor = AnchorStyles.None;
            txtMenuItemName.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtMenuItemName.ForeColor = SystemColors.ActiveCaptionText;
            txtMenuItemName.Location = new Point(172, 216);
            txtMenuItemName.Name = "txtMenuItemName";
            txtMenuItemName.Size = new Size(252, 24);
            txtMenuItemName.TabIndex = 4;
            // 
            // lblFormName
            // 
            lblFormName.Anchor = AnchorStyles.None;
            lblFormName.AutoSize = true;
            lblFormName.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblFormName.ForeColor = SystemColors.ActiveCaptionText;
            lblFormName.Location = new Point(172, 267);
            lblFormName.Name = "lblFormName";
            lblFormName.Size = new Size(153, 19);
            lblFormName.TabIndex = 5;
            lblFormName.Text = "Nombre del formulario:";
            // 
            // txtFormName
            // 
            txtFormName.Anchor = AnchorStyles.None;
            txtFormName.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtFormName.ForeColor = SystemColors.ActiveCaptionText;
            txtFormName.Location = new Point(172, 289);
            txtFormName.Name = "txtFormName";
            txtFormName.Size = new Size(252, 24);
            txtFormName.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnRegistrar.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrar.Location = new Point(318, 350);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 31);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.BackColor = Color.Brown;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnSalir.Location = new Point(490, 31);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 27);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // RegistrarPatenteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtFormName);
            Controls.Add(lblFormName);
            Controls.Add(txtMenuItemName);
            Controls.Add(lblMenuItemName);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(lblDatosPatente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarPatenteForm";
            Text = "RegistrarPatenteForm";
            Load += RegistrarPatenteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblDatosPatente;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblMenuItemName;
        private TextBox txtMenuItemName;
        private Label lblFormName;
        private TextBox txtFormName;
        private Button btnRegistrar;
        private Button btnSalir;

        #endregion
    }
}