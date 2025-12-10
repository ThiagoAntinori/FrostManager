using System.Windows.Forms;

namespace UI.Primary_Forms
{
    partial class GestionarPedidosForm
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
            dgvPedidos = new DataGridView();
            lblTituloPedidos = new Label();
            btnSalir = new Button();
            lblNuevoEstado = new Label();
            cmbNuevoEstado = new ComboBox();
            btnActualizarEstado = new Button();
            btnCancelarPedido = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            SuspendLayout();
            // 
            // dgvPedidos
            // 
            dgvPedidos.Anchor = AnchorStyles.None;
            dgvPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvPedidos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(45, 115);
            dgvPedidos.MultiSelect = false;
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPedidos.Size = new Size(530, 250);
            dgvPedidos.TabIndex = 0;
            dgvPedidos.SelectionChanged += dgvPedidos_SelectionChanged;
            // 
            // lblTituloPedidos
            // 
            lblTituloPedidos.Anchor = AnchorStyles.None;
            lblTituloPedidos.AutoSize = true;
            lblTituloPedidos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPedidos.ForeColor = SystemColors.WindowText;
            lblTituloPedidos.Location = new Point(45, 72);
            lblTituloPedidos.Name = "lblTituloPedidos";
            lblTituloPedidos.Size = new Size(109, 17);
            lblTituloPedidos.TabIndex = 1;
            lblTituloPedidos.Text = "Pedidos actuales";
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblNuevoEstado
            // 
            lblNuevoEstado.Anchor = AnchorStyles.None;
            lblNuevoEstado.AutoSize = true;
            lblNuevoEstado.ForeColor = SystemColors.ActiveCaptionText;
            lblNuevoEstado.Location = new Point(255, 385);
            lblNuevoEstado.Name = "lblNuevoEstado";
            lblNuevoEstado.Size = new Size(83, 15);
            lblNuevoEstado.TabIndex = 5;
            lblNuevoEstado.Text = "Nuevo Estado:";
            // 
            // cmbNuevoEstado
            // 
            cmbNuevoEstado.Anchor = AnchorStyles.None;
            cmbNuevoEstado.FormattingEnabled = true;
            cmbNuevoEstado.Location = new Point(255, 403);
            cmbNuevoEstado.Name = "cmbNuevoEstado";
            cmbNuevoEstado.Size = new Size(180, 23);
            cmbNuevoEstado.TabIndex = 6;
            // 
            // btnActualizarEstado
            // 
            btnActualizarEstado.Anchor = AnchorStyles.None;
            btnActualizarEstado.BackColor = Color.Lavender;
            btnActualizarEstado.FlatStyle = FlatStyle.Popup;
            btnActualizarEstado.ForeColor = SystemColors.WindowText;
            btnActualizarEstado.Location = new Point(453, 397);
            btnActualizarEstado.Name = "btnActualizarEstado";
            btnActualizarEstado.Size = new Size(126, 29);
            btnActualizarEstado.TabIndex = 7;
            btnActualizarEstado.Text = "Actualizar Estado";
            btnActualizarEstado.UseVisualStyleBackColor = false;
            btnActualizarEstado.Click += btnActualizarEstado_Click;
            // 
            // btnCancelarPedido
            // 
            btnCancelarPedido.Anchor = AnchorStyles.None;
            btnCancelarPedido.BackColor = Color.LightCoral;
            btnCancelarPedido.FlatStyle = FlatStyle.Popup;
            btnCancelarPedido.ForeColor = SystemColors.WindowText;
            btnCancelarPedido.Location = new Point(453, 450);
            btnCancelarPedido.Name = "btnCancelarPedido";
            btnCancelarPedido.Size = new Size(126, 29);
            btnCancelarPedido.TabIndex = 8;
            btnCancelarPedido.Text = "Cancelar Pedido";
            btnCancelarPedido.UseVisualStyleBackColor = false;
            btnCancelarPedido.Click += btnCancelarPedido_Click_1;
            // 
            // GestionarPedidosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnCancelarPedido);
            Controls.Add(btnActualizarEstado);
            Controls.Add(cmbNuevoEstado);
            Controls.Add(lblNuevoEstado);
            Controls.Add(btnSalir);
            Controls.Add(lblTituloPedidos);
            Controls.Add(dgvPedidos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GestionarPedidosForm";
            Text = "VerPedidosForm";
            Load += GestionarPedidosForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPedidos;
        private Label lblTituloPedidos;
        private Button btnSalir;
        private Label lblNuevoEstado;
        private ComboBox cmbNuevoEstado;
        private Button btnActualizarEstado;
        private Button btnCancelarPedido;
    }
}