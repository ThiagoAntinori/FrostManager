namespace UI.Administrative_Forms
{
    partial class VerDetallesBitacoraForm
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
            lblDetallesEntrada = new Label();
            btnConfirmar = new Button();
            btnCopiarPortapapeles = new Button();
            rtxtDetalle = new RichTextBox();
            SuspendLayout();
            // 
            // lblDetallesEntrada
            // 
            lblDetallesEntrada.AutoSize = true;
            lblDetallesEntrada.Location = new Point(58, 21);
            lblDetallesEntrada.Name = "lblDetallesEntrada";
            lblDetallesEntrada.Size = new Size(122, 15);
            lblDetallesEntrada.TabIndex = 1;
            lblDetallesEntrada.Text = "Detalles de la entrada:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(313, 272);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(100, 27);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCopiarPortapapeles
            // 
            btnCopiarPortapapeles.Location = new Point(58, 272);
            btnCopiarPortapapeles.Name = "btnCopiarPortapapeles";
            btnCopiarPortapapeles.Size = new Size(137, 27);
            btnCopiarPortapapeles.TabIndex = 3;
            btnCopiarPortapapeles.Text = "Copiar al portapapeles";
            btnCopiarPortapapeles.UseVisualStyleBackColor = true;
            btnCopiarPortapapeles.Click += btnCopiarPortapapeles_Click;
            // 
            // rtxtDetalle
            // 
            rtxtDetalle.Font = new Font("Consolas", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtxtDetalle.Location = new Point(58, 54);
            rtxtDetalle.Name = "rtxtDetalle";
            rtxtDetalle.ReadOnly = true;
            rtxtDetalle.Size = new Size(354, 184);
            rtxtDetalle.TabIndex = 4;
            rtxtDetalle.Text = "";
            // 
            // VerDetallesBitacoraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 321);
            Controls.Add(rtxtDetalle);
            Controls.Add(btnCopiarPortapapeles);
            Controls.Add(btnConfirmar);
            Controls.Add(lblDetallesEntrada);
            Name = "VerDetallesBitacoraForm";
            Text = "DETALLES BITACORA";
            Load += VerDetallesBitacoraForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDetallesEntrada;
        private Button btnConfirmar;
        private Button btnCopiarPortapapeles;
        private RichTextBox rtxtDetalle;
    }
}