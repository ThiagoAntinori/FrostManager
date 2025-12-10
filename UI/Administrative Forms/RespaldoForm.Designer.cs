namespace UI.Administrative_Forms
{
    partial class RespaldoForm
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
            btnRespaldar = new Button();
            btnRestaurar = new Button();
            rbtnNegocio = new RadioButton();
            rbtnSeguridad = new RadioButton();
            gbSeleccionarBase = new GroupBox();
            gbSeleccionarBase.SuspendLayout();
            SuspendLayout();
            // 
            // btnRespaldar
            // 
            btnRespaldar.Anchor = AnchorStyles.None;
            btnRespaldar.Location = new Point(81, 258);
            btnRespaldar.Name = "btnRespaldar";
            btnRespaldar.Size = new Size(186, 42);
            btnRespaldar.TabIndex = 0;
            btnRespaldar.Text = "Respaldar Datos";
            btnRespaldar.UseVisualStyleBackColor = true;
            btnRespaldar.Click += btnRespaldar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.None;
            btnRestaurar.Location = new Point(333, 258);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(186, 42);
            btnRestaurar.TabIndex = 1;
            btnRestaurar.Text = "Restaurar Datos";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // rbtnNegocio
            // 
            rbtnNegocio.AutoSize = true;
            rbtnNegocio.Location = new Point(27, 36);
            rbtnNegocio.Name = "rbtnNegocio";
            rbtnNegocio.Size = new Size(159, 19);
            rbtnNegocio.TabIndex = 2;
            rbtnNegocio.TabStop = true;
            rbtnNegocio.Text = "Base de datos de negocio";
            rbtnNegocio.UseVisualStyleBackColor = true;
            rbtnNegocio.CheckedChanged += rbtnNegocio_CheckedChanged;
            // 
            // rbtnSeguridad
            // 
            rbtnSeguridad.AutoSize = true;
            rbtnSeguridad.Location = new Point(27, 61);
            rbtnSeguridad.Name = "rbtnSeguridad";
            rbtnSeguridad.Size = new Size(168, 19);
            rbtnSeguridad.TabIndex = 3;
            rbtnSeguridad.TabStop = true;
            rbtnSeguridad.Text = "Base de datos de seguridad";
            rbtnSeguridad.UseVisualStyleBackColor = true;
            rbtnSeguridad.CheckedChanged += rbtnSeguridad_CheckedChanged;
            // 
            // gbSeleccionarBase
            // 
            gbSeleccionarBase.Anchor = AnchorStyles.None;
            gbSeleccionarBase.Controls.Add(rbtnSeguridad);
            gbSeleccionarBase.Controls.Add(rbtnNegocio);
            gbSeleccionarBase.Location = new Point(81, 72);
            gbSeleccionarBase.Name = "gbSeleccionarBase";
            gbSeleccionarBase.Size = new Size(438, 110);
            gbSeleccionarBase.TabIndex = 4;
            gbSeleccionarBase.TabStop = false;
            gbSeleccionarBase.Text = "Selecciona la base de datos";
            // 
            // RespaldoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(gbSeleccionarBase);
            Controls.Add(btnRestaurar);
            Controls.Add(btnRespaldar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RespaldoForm";
            Text = "RespaldoForm";
            Load += RespaldoForm_Load;
            gbSeleccionarBase.ResumeLayout(false);
            gbSeleccionarBase.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRespaldar;
        private Button btnRestaurar;
        private RadioButton rbtnNegocio;
        private RadioButton rbtnSeguridad;
        private GroupBox gbSeleccionarBase;
    }
}