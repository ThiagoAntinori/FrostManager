namespace UI.Primary_Forms
{
    partial class ReporteVentasForm
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
            lblReporteVentas = new Label();
            lblFechaDesde = new Label();
            dtpFechaDesde = new DateTimePicker();
            dgvReporte = new DataGridView();
            btnGenerarPDF = new Button();
            lblFechaHasta = new Label();
            dtpFechaHasta = new DateTimePicker();
            btnGenerarReporte = new Button();
            lblTotalRecaudadoTexto = new Label();
            lblTotalRecaudadoValor = new Label();
            lblPromedioDiarioTexto = new Label();
            lblPromedioDiarioValor = new Label();
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
            lblReporteVentas.AutoSize = true;
            lblReporteVentas.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReporteVentas.ForeColor = SystemColors.WindowText;
            lblReporteVentas.Location = new Point(40, 25);
            lblReporteVentas.Name = "lblReporteVentas";
            lblReporteVentas.Size = new Size(133, 20);
            lblReporteVentas.TabIndex = 1;
            lblReporteVentas.Text = "Reporte de Ventas";
            // 
            // lblFechaDesde
            // 
            lblFechaDesde.AutoSize = true;
            lblFechaDesde.Font = new Font("Segoe UI", 9.75F);
            lblFechaDesde.ForeColor = SystemColors.WindowText;
            lblFechaDesde.Location = new Point(40, 70);
            lblFechaDesde.Name = "lblFechaDesde";
            lblFechaDesde.Size = new Size(85, 17);
            lblFechaDesde.TabIndex = 2;
            lblFechaDesde.Text = "Fecha Desde:";
            // 
            // dtpFechaDesde
            // 
            dtpFechaDesde.Format = DateTimePickerFormat.Short;
            dtpFechaDesde.Location = new Point(128, 68);
            dtpFechaDesde.Name = "dtpFechaDesde";
            dtpFechaDesde.Size = new Size(120, 23);
            dtpFechaDesde.TabIndex = 3;
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
            dgvReporte.Size = new Size(544, 300);
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
            // lblFechaHasta
            // 
            lblFechaHasta.AutoSize = true;
            lblFechaHasta.Font = new Font("Segoe UI", 9.75F);
            lblFechaHasta.ForeColor = SystemColors.WindowText;
            lblFechaHasta.Location = new Point(275, 70);
            lblFechaHasta.Name = "lblFechaHasta";
            lblFechaHasta.Size = new Size(81, 17);
            lblFechaHasta.TabIndex = 6;
            lblFechaHasta.Text = "Fecha Hasta:";
            // 
            // dtpFechaHasta
            // 
            dtpFechaHasta.Format = DateTimePickerFormat.Short;
            dtpFechaHasta.Location = new Point(358, 68);
            dtpFechaHasta.Name = "dtpFechaHasta";
            dtpFechaHasta.Size = new Size(120, 23);
            dtpFechaHasta.TabIndex = 7;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.Lavender;
            btnGenerarReporte.FlatStyle = FlatStyle.Popup;
            btnGenerarReporte.Location = new Point(504, 67);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(80, 25);
            btnGenerarReporte.TabIndex = 8;
            btnGenerarReporte.Text = "Generar";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click_1;
            // 
            // lblTotalRecaudadoTexto
            // 
            lblTotalRecaudadoTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRecaudadoTexto.AutoSize = true;
            lblTotalRecaudadoTexto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecaudadoTexto.ForeColor = SystemColors.WindowText;
            lblTotalRecaudadoTexto.Location = new Point(40, 430);
            lblTotalRecaudadoTexto.Name = "lblTotalRecaudadoTexto";
            lblTotalRecaudadoTexto.Size = new Size(111, 17);
            lblTotalRecaudadoTexto.TabIndex = 9;
            lblTotalRecaudadoTexto.Text = "Total Recaudado:";
            // 
            // lblTotalRecaudadoValor
            // 
            lblTotalRecaudadoValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblTotalRecaudadoValor.AutoSize = true;
            lblTotalRecaudadoValor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalRecaudadoValor.ForeColor = SystemColors.WindowText;
            lblTotalRecaudadoValor.Location = new Point(165, 430);
            lblTotalRecaudadoValor.Name = "lblTotalRecaudadoValor";
            lblTotalRecaudadoValor.Size = new Size(43, 17);
            lblTotalRecaudadoValor.TabIndex = 10;
            lblTotalRecaudadoValor.Text = "$ 0.00";
            // 
            // lblPromedioDiarioTexto
            // 
            lblPromedioDiarioTexto.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPromedioDiarioTexto.AutoSize = true;
            lblPromedioDiarioTexto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPromedioDiarioTexto.ForeColor = SystemColors.WindowText;
            lblPromedioDiarioTexto.Location = new Point(40, 460);
            lblPromedioDiarioTexto.Name = "lblPromedioDiarioTexto";
            lblPromedioDiarioTexto.Size = new Size(109, 17);
            lblPromedioDiarioTexto.TabIndex = 11;
            lblPromedioDiarioTexto.Text = "Promedio Diario:";
            // 
            // lblPromedioDiarioValor
            // 
            lblPromedioDiarioValor.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblPromedioDiarioValor.AutoSize = true;
            lblPromedioDiarioValor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPromedioDiarioValor.ForeColor = SystemColors.WindowText;
            lblPromedioDiarioValor.Location = new Point(165, 460);
            lblPromedioDiarioValor.Name = "lblPromedioDiarioValor";
            lblPromedioDiarioValor.Size = new Size(43, 17);
            lblPromedioDiarioValor.TabIndex = 12;
            lblPromedioDiarioValor.Text = "$ 0.00";
            // 
            // ReporteVentasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(lblPromedioDiarioValor);
            Controls.Add(lblPromedioDiarioTexto);
            Controls.Add(lblTotalRecaudadoValor);
            Controls.Add(lblTotalRecaudadoTexto);
            Controls.Add(btnGenerarReporte);
            Controls.Add(dtpFechaHasta);
            Controls.Add(lblFechaHasta);
            Controls.Add(btnGenerarPDF);
            Controls.Add(dgvReporte);
            Controls.Add(dtpFechaDesde);
            Controls.Add(lblFechaDesde);
            Controls.Add(lblReporteVentas);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteVentasForm";
            Text = "ReporteVentasForm";
            Load += ReporteVentasForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblReporteVentas;
        private Label lblFechaDesde;
        private DateTimePicker dtpFechaDesde;
        private DataGridView dgvReporte;
        private Button btnGenerarPDF;
        private Label lblFechaHasta;
        private DateTimePicker dtpFechaHasta;
        private Button btnGenerarReporte;
        // Nuevas declaraciones
        private Label lblTotalRecaudadoTexto;
        private Label lblTotalRecaudadoValor;
        private Label lblPromedioDiarioTexto;
        private Label lblPromedioDiarioValor;
    }
}