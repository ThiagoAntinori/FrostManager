namespace UI.Primary_Forms
{
    partial class CobrarForm
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
            lblSeleccionarMedioPago = new Label();
            cmbMedioPago = new ComboBox();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblSeleccionarMedioPago
            // 
            lblSeleccionarMedioPago.AutoSize = true;
            lblSeleccionarMedioPago.Location = new Point(49, 46);
            lblSeleccionarMedioPago.Name = "lblSeleccionarMedioPago";
            lblSeleccionarMedioPago.Size = new Size(158, 15);
            lblSeleccionarMedioPago.TabIndex = 0;
            lblSeleccionarMedioPago.Text = "Seleccione el medio de pago";
            // 
            // cmbMedioPago
            // 
            cmbMedioPago.FormattingEnabled = true;
            cmbMedioPago.Location = new Point(49, 83);
            cmbMedioPago.Name = "cmbMedioPago";
            cmbMedioPago.Size = new Size(228, 23);
            cmbMedioPago.TabIndex = 1;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(169, 135);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(108, 23);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(49, 135);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(108, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // CobrarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 189);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(cmbMedioPago);
            Controls.Add(lblSeleccionarMedioPago);
            Name = "CobrarForm";
            Text = "CobrarForm";
            Load += CobrarForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSeleccionarMedioPago;
        private ComboBox cmbMedioPago;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}