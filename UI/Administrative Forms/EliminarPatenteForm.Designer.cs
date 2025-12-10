namespace UI.Administrative_Forms
{
    partial class EliminarPatenteForm
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
            lblSeleccionado = new Label();
            lblPatenteSeleccionada = new Label();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPatentes).BeginInit();
            SuspendLayout();
            // 
            // dgvPatentes
            // 
            dgvPatentes.Anchor = AnchorStyles.None;
            dgvPatentes.BackgroundColor = Color.GhostWhite;
            dgvPatentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatentes.Location = new Point(57, 110);
            dgvPatentes.Name = "dgvPatentes";
            dgvPatentes.ReadOnly = true;
            dgvPatentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatentes.Size = new Size(290, 254);
            dgvPatentes.TabIndex = 1;
            dgvPatentes.SelectionChanged += dgvPatentes_SelectionChanged;
            // 
            // lblSeleccionePatente
            // 
            lblSeleccionePatente.Anchor = AnchorStyles.None;
            lblSeleccionePatente.AutoSize = true;
            lblSeleccionePatente.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccionePatente.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccionePatente.Location = new Point(57, 69);
            lblSeleccionePatente.Name = "lblSeleccionePatente";
            lblSeleccionePatente.Size = new Size(205, 19);
            lblSeleccionePatente.TabIndex = 0;
            lblSeleccionePatente.Text = "Seleccione la patente a eliminar:";
            // 
            // lblSeleccionado
            // 
            lblSeleccionado.Anchor = AnchorStyles.None;
            lblSeleccionado.AutoSize = true;
            lblSeleccionado.Font = new Font("Microsoft YaHei UI", 9.75F);
            lblSeleccionado.ForeColor = SystemColors.ActiveCaptionText;
            lblSeleccionado.Location = new Point(393, 110);
            lblSeleccionado.Name = "lblSeleccionado";
            lblSeleccionado.Size = new Size(92, 19);
            lblSeleccionado.TabIndex = 2;
            lblSeleccionado.Text = "Seleccionada:";
            // 
            // lblPatenteSeleccionada
            // 
            lblPatenteSeleccionada.Anchor = AnchorStyles.None;
            lblPatenteSeleccionada.AutoSize = true;
            lblPatenteSeleccionada.Font = new Font("Microsoft YaHei UI", 9.75F, FontStyle.Bold);
            lblPatenteSeleccionada.ForeColor = Color.DarkRed;
            lblPatenteSeleccionada.Location = new Point(393, 139);
            lblPatenteSeleccionada.Name = "lblPatenteSeleccionada";
            lblPatenteSeleccionada.Size = new Size(15, 19);
            lblPatenteSeleccionada.TabIndex = 3;
            lblPatenteSeleccionada.Text = "-";
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.Font = new Font("Microsoft YaHei UI", 9.75F);
            btnEliminar.ForeColor = SystemColors.ActiveCaptionText;
            btnEliminar.Location = new Point(444, 333);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(117, 31);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
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
            // EliminarPatenteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(lblPatenteSeleccionada);
            Controls.Add(lblSeleccionado);
            Controls.Add(dgvPatentes);
            Controls.Add(lblSeleccionePatente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EliminarPatenteForm";
            Text = "EliminarPatenteForm";
            Load += EliminarPatenteForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPatentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvPatentes;
        private Label lblSeleccionePatente;
        private Label lblSeleccionado;
        private Label lblPatenteSeleccionada;
        private Button btnEliminar;
        private Button btnSalir;

        #endregion
    }
}