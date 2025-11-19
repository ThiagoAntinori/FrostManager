namespace UI.Primary_Forms
{
    partial class SeleccionarRepartidorForm
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
            lblTitulo = new Label();
            dgvRepartidores = new DataGridView();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblBuscar = new Label();
            txtBuscarDni = new TextBox();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.WindowText;
            lblTitulo.Location = new Point(25, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(241, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Seleccionar Repartidor Disponible";
            // 
            // dgvRepartidores
            // 
            dgvRepartidores.Anchor = AnchorStyles.None;
            dgvRepartidores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRepartidores.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRepartidores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRepartidores.Location = new Point(25, 60);
            dgvRepartidores.MultiSelect = false;
            dgvRepartidores.Name = "dgvRepartidores";
            dgvRepartidores.ReadOnly = true;
            dgvRepartidores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRepartidores.Size = new Size(400, 214);
            dgvRepartidores.TabIndex = 1;
            dgvRepartidores.SelectionChanged += dgvRepartidores_SelectionChanged;
            // 
            // btnAceptar
            // 
            btnAceptar.Anchor = AnchorStyles.None;
            btnAceptar.BackColor = Color.LightGreen;
            btnAceptar.FlatStyle = FlatStyle.Popup;
            btnAceptar.ForeColor = SystemColors.WindowText;
            btnAceptar.Location = new Point(325, 345);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 30);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.None;
            btnCancelar.BackColor = Color.LightCoral;
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = SystemColors.WindowText;
            btnCancelar.Location = new Point(210, 345);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscar.Location = new Point(25, 284);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(89, 15);
            lblBuscar.TabIndex = 4;
            lblBuscar.Text = "Buscar por DNI:";
            // 
            // txtBuscarDni
            // 
            txtBuscarDni.Location = new Point(25, 302);
            txtBuscarDni.Name = "txtBuscarDni";
            txtBuscarDni.Size = new Size(180, 23);
            txtBuscarDni.TabIndex = 5;
            // 
            // btnBuscar
            // 
            btnBuscar.ForeColor = SystemColors.ActiveCaptionText;
            btnBuscar.Location = new Point(211, 302);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(70, 23);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // SeleccionarRepartidorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 400);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscarDni);
            Controls.Add(lblBuscar);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(dgvRepartidores);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SeleccionarRepartidorForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Selección de Repartidor";
            Load += SeleccionarRepartidorForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRepartidores).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvRepartidores;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblBuscar;
        private TextBox txtBuscarDni;
        private Button btnBuscar;
    }
}