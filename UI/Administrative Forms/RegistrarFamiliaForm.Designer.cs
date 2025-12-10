namespace UI.Administrative_Forms
{
    partial class RegistrarFamiliaForm
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
            lblDescripcionFamilia = new Label();
            txtDescripcionFamilia = new TextBox();
            btnRegistrar = new Button();
            btnSalir = new Button();
            btnSeleccionarPatentes = new Button();
            btnSeleccionarFamilias = new Button();
            SuspendLayout();
            // 
            // lblDescripcionFamilia
            // 
            lblDescripcionFamilia.Anchor = AnchorStyles.None;
            lblDescripcionFamilia.AutoSize = true;
            lblDescripcionFamilia.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblDescripcionFamilia.ForeColor = SystemColors.ActiveCaptionText;
            lblDescripcionFamilia.Location = new Point(123, 81);
            lblDescripcionFamilia.Name = "lblDescripcionFamilia";
            lblDescripcionFamilia.Size = new Size(161, 19);
            lblDescripcionFamilia.TabIndex = 0;
            lblDescripcionFamilia.Text = "Descripción de la familia:";
            // 
            // txtDescripcionFamilia
            // 
            txtDescripcionFamilia.Anchor = AnchorStyles.None;
            txtDescripcionFamilia.Font = new Font("Microsoft YaHei UI", 9.75F);
            txtDescripcionFamilia.ForeColor = SystemColors.ActiveCaptionText;
            txtDescripcionFamilia.Location = new Point(123, 103);
            txtDescripcionFamilia.Name = "txtDescripcionFamilia";
            txtDescripcionFamilia.Size = new Size(373, 24);
            txtDescripcionFamilia.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Anchor = AnchorStyles.None;
            btnRegistrar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnRegistrar.ForeColor = SystemColors.ActiveCaptionText;
            btnRegistrar.Location = new Point(390, 342);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(106, 31);
            btnRegistrar.TabIndex = 4;
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
            btnSalir.Location = new Point(513, 12);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 27);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnSeleccionarPatentes
            // 
            btnSeleccionarPatentes.Anchor = AnchorStyles.None;
            btnSeleccionarPatentes.Location = new Point(123, 165);
            btnSeleccionarPatentes.Name = "btnSeleccionarPatentes";
            btnSeleccionarPatentes.Size = new Size(199, 39);
            btnSeleccionarPatentes.TabIndex = 6;
            btnSeleccionarPatentes.Text = "Seleccionar Patentes";
            btnSeleccionarPatentes.UseVisualStyleBackColor = true;
            btnSeleccionarPatentes.Click += btnSeleccionarPatentes_Click;
            // 
            // btnSeleccionarFamilias
            // 
            btnSeleccionarFamilias.Anchor = AnchorStyles.None;
            btnSeleccionarFamilias.Location = new Point(123, 210);
            btnSeleccionarFamilias.Name = "btnSeleccionarFamilias";
            btnSeleccionarFamilias.Size = new Size(199, 39);
            btnSeleccionarFamilias.TabIndex = 7;
            btnSeleccionarFamilias.Text = "Seleccionar Familias";
            btnSeleccionarFamilias.UseVisualStyleBackColor = true;
            btnSeleccionarFamilias.Click += btnSeleccionarFamilias_Click;
            // 
            // RegistrarFamiliaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSeleccionarFamilias);
            Controls.Add(btnSeleccionarPatentes);
            Controls.Add(btnSalir);
            Controls.Add(btnRegistrar);
            Controls.Add(txtDescripcionFamilia);
            Controls.Add(lblDescripcionFamilia);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrarFamiliaForm";
            Text = "RegistrarFamiliaForm";
            Load += RegistrarFamiliaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblDescripcionFamilia;
        private TextBox txtDescripcionFamilia;
        private Button btnRegistrar;
        private Button btnSalir;

        #endregion

        private Button btnSeleccionarPatentes;
        private Button btnSeleccionarFamilias;
    }
}