namespace UI.Primary_Forms
{
    partial class RegistrarPedidoForm
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
            btnBuscarCliente = new Button();
            btnAsignarRepartidor = new Button();
            btnConfirmar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.Location = new Point(72, 67);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(192, 34);
            btnBuscarCliente.TabIndex = 0;
            btnBuscarCliente.Text = "Buscar Cliente";
            btnBuscarCliente.UseVisualStyleBackColor = true;
            btnBuscarCliente.Click += btnBuscarCliente_Click;
            // 
            // btnAsignarRepartidor
            // 
            btnAsignarRepartidor.Location = new Point(72, 107);
            btnAsignarRepartidor.Name = "btnAsignarRepartidor";
            btnAsignarRepartidor.Size = new Size(192, 34);
            btnAsignarRepartidor.TabIndex = 1;
            btnAsignarRepartidor.Text = "Asignar Repartidor";
            btnAsignarRepartidor.UseVisualStyleBackColor = true;
            btnAsignarRepartidor.Click += btnAsignarRepartidor_Click;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(72, 208);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(192, 34);
            btnConfirmar.TabIndex = 2;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(72, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(192, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // RegistrarPedidoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 321);
            Controls.Add(btnCancelar);
            Controls.Add(btnConfirmar);
            Controls.Add(btnAsignarRepartidor);
            Controls.Add(btnBuscarCliente);
            Name = "RegistrarPedidoForm";
            Text = "RegistrarPedidoForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBuscarCliente;
        private Button btnAsignarRepartidor;
        private Button btnConfirmar;
        private Button btnCancelar;
    }
}