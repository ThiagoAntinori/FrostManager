namespace UI.Primary_Forms
{
    partial class ReporteSaboresForm
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
            lblReporteSabores = new Label();
            lblFechaDesde = new Label();
            dtpFechaDesde = new DateTimePicker();
            dgvReporte = new DataGridView();
            btnGenerarPDF = new Button();
            lblFechaHasta = new Label();
            dtpFechaHasta = new DateTimePicker();
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
            lblReporteSabores.AutoSize = true;
            lblReporteSabores.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReporteSabores.ForeColor = SystemColors.WindowText;
            lblReporteSabores.Location = new Point(40, 25);
            lblReporteSabores.Name = "lblReporteSabores";
            lblReporteSabores.Size = new Size(142, 20);
            lblReporteSabores.TabIndex = 1;
            lblReporteSabores.Text = "Reporte de Sabores";
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
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // ReporteSaboresForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnGenerarReporte);
            Controls.Add(dtpFechaHasta);
            Controls.Add(lblFechaHasta);
            Controls.Add(btnGenerarPDF);
            Controls.Add(dgvReporte);
            Controls.Add(dtpFechaDesde);
            Controls.Add(lblFechaDesde);
            Controls.Add(lblReporteSabores);
            Controls.Add(btnSalir);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ReporteSaboresForm";
            Text = "ReporteSaboresForm";
            Load += ReporteSaboresForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Label lblReporteSabores;
        private Label lblFechaDesde;
        private DateTimePicker dtpFechaDesde;
        private DataGridView dgvReporte;
        private Button btnGenerarPDF;
        private Label lblFechaHasta;
        private DateTimePicker dtpFechaHasta;
        private Button btnGenerarReporte;
    }
}