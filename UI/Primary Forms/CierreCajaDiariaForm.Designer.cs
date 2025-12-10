namespace UI.Primary_Forms
{
    partial class CierreCajaDiariaForm
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
            lblTitulo = new Label();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            dgvReporte = new DataGridView();
            btnGenerarPDF = new Button();
            btnGenerarReporte = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.None;
            btnSalir.ForeColor = SystemColors.WindowText;
            btnSalir.Location = new Point(524, 22);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 0;
            btnSalir.Text = "X";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.WindowText;
            lblTitulo.Location = new Point(40, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(149, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Cierre de Caja Diaria";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 9.75F);
            lblFecha.ForeColor = SystemColors.WindowText;
            lblFecha.Location = new Point(40, 70);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(121, 17);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Seleccione la fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(165, 68);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(120, 23);
            dtpFecha.TabIndex = 3;
            // 
            // dgvReporte
            // 
            dgvReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvReporte.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(40, 115);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(544, 340);
            dgvReporte.TabIndex = 4;
            // 
            // btnGenerarPDF
            // 
            btnGenerarPDF.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerarPDF.BackColor = Color.IndianRed;
            btnGenerarPDF.FlatStyle = FlatStyle.Popup;
            btnGenerarPDF.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarPDF.ForeColor = SystemColors.Window;
            btnGenerarPDF.Location = new Point(445, 485);
            btnGenerarPDF.Name = "btnGenerarPDF";
            btnGenerarPDF.Size = new Size(139, 35);
            btnGenerarPDF.TabIndex = 5;
            btnGenerarPDF.Text = "Descargar PDF";
            btnGenerarPDF.UseVisualStyleBackColor = false;
            btnGenerarPDF.Click += btnGenerarPDF_Click;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.Lavender;
            btnGenerarReporte.FlatStyle = FlatStyle.Popup;
            btnGenerarReporte.Location = new Point(310, 67);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(120, 25);
            btnGenerarReporte.TabIndex = 6;
            btnGenerarReporte.Text = "Generar Reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // CierreCajaDiariaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnGenerarReporte);
            Controls.Add(btnGenerarPDF);
            Controls.Add(dgvReporte);
            Controls.Add(dtpFecha);
            Controls.Add(lblFecha);
            Controls.Add(lblTitulo);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CierreCajaDiariaForm";
            Text = "CierreCajaDiariaForm";
            Load += CierreCajaDiariaForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblTitulo;
        private Label lblFecha;
        private DateTimePicker dtpFecha;
        private DataGridView dgvReporte;
        private Button btnGenerarPDF;
        private Button btnGenerarReporte;
    }
}