namespace UI.Primary_Forms
{
    partial class ConsultarClienteForm
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
            lblIngresarDni = new Label();
            txtDni = new TextBox();
            btnBuscar = new Button();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblNombreBuscado = new Label();
            lblApellidoBuscado = new Label();
            lblDniBuscado = new Label();
            lblTelefonoBuscado = new Label();
            lblDireccionBuscado = new Label();
            btnModificarDatos = new Button();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // lblIngresarDni
            // 
            lblIngresarDni.AutoSize = true;
            lblIngresarDni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblIngresarDni.Location = new Point(72, 60);
            lblIngresarDni.Name = "lblIngresarDni";
            lblIngresarDni.Size = new Size(220, 17);
            lblIngresarDni.TabIndex = 0;
            lblIngresarDni.Text = "Ingrese el DNI del Cliente a buscar:";
            // 
            // txtDni
            // 
            txtDni.BorderStyle = BorderStyle.FixedSingle;
            txtDni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtDni.Location = new Point(72, 80);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(248, 25);
            txtDni.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnBuscar.Location = new Point(339, 80);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(97, 25);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblNombre.Location = new Point(72, 148);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(58, 17);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblApellido.Location = new Point(72, 203);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(57, 17);
            lblApellido.TabIndex = 4;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDni.Location = new Point(72, 257);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(31, 17);
            lblDni.TabIndex = 5;
            lblDni.Text = "DNI";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblTelefono.Location = new Point(72, 305);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 17);
            lblTelefono.TabIndex = 6;
            lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblDireccion.Location = new Point(72, 360);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(63, 17);
            lblDireccion.TabIndex = 7;
            lblDireccion.Text = "Dirección";
            // 
            // lblNombreBuscado
            // 
            lblNombreBuscado.AutoSize = true;
            lblNombreBuscado.Location = new Point(187, 150);
            lblNombreBuscado.Name = "lblNombreBuscado";
            lblNombreBuscado.Size = new Size(12, 15);
            lblNombreBuscado.TabIndex = 8;
            lblNombreBuscado.Text = "-";
            // 
            // lblApellidoBuscado
            // 
            lblApellidoBuscado.AutoSize = true;
            lblApellidoBuscado.Location = new Point(187, 205);
            lblApellidoBuscado.Name = "lblApellidoBuscado";
            lblApellidoBuscado.Size = new Size(12, 15);
            lblApellidoBuscado.TabIndex = 9;
            lblApellidoBuscado.Text = "-";
            // 
            // lblDniBuscado
            // 
            lblDniBuscado.AutoSize = true;
            lblDniBuscado.Location = new Point(187, 259);
            lblDniBuscado.Name = "lblDniBuscado";
            lblDniBuscado.Size = new Size(12, 15);
            lblDniBuscado.TabIndex = 10;
            lblDniBuscado.Text = "-";
            // 
            // lblTelefonoBuscado
            // 
            lblTelefonoBuscado.AutoSize = true;
            lblTelefonoBuscado.Location = new Point(187, 307);
            lblTelefonoBuscado.Name = "lblTelefonoBuscado";
            lblTelefonoBuscado.Size = new Size(12, 15);
            lblTelefonoBuscado.TabIndex = 11;
            lblTelefonoBuscado.Text = "-";
            // 
            // lblDireccionBuscado
            // 
            lblDireccionBuscado.AutoSize = true;
            lblDireccionBuscado.Location = new Point(187, 362);
            lblDireccionBuscado.Name = "lblDireccionBuscado";
            lblDireccionBuscado.Size = new Size(12, 15);
            lblDireccionBuscado.TabIndex = 12;
            lblDireccionBuscado.Text = "-";
            // 
            // btnModificarDatos
            // 
            btnModificarDatos.Location = new Point(72, 490);
            btnModificarDatos.Name = "btnModificarDatos";
            btnModificarDatos.Size = new Size(149, 31);
            btnModificarDatos.TabIndex = 13;
            btnModificarDatos.Text = "Modificar Datos";
            btnModificarDatos.UseVisualStyleBackColor = true;
            // 
            // btnConfirmar
            // 
            btnConfirmar.Location = new Point(392, 490);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(149, 31);
            btnConfirmar.TabIndex = 14;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.UseVisualStyleBackColor = true;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // ConsultarClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(btnConfirmar);
            Controls.Add(btnModificarDatos);
            Controls.Add(lblDireccionBuscado);
            Controls.Add(lblTelefonoBuscado);
            Controls.Add(lblDniBuscado);
            Controls.Add(lblApellidoBuscado);
            Controls.Add(lblNombreBuscado);
            Controls.Add(lblDireccion);
            Controls.Add(lblTelefono);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtDni);
            Controls.Add(lblIngresarDni);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConsultarClienteForm";
            Text = "ConsultarClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngresarDni;
        private TextBox txtDni;
        private Button btnBuscar;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblNombreBuscado;
        private Label lblApellidoBuscado;
        private Label lblDniBuscado;
        private Label lblTelefonoBuscado;
        private Label lblDireccionBuscado;
        private Button btnModificarDatos;
        private Button btnConfirmar;
    }
}