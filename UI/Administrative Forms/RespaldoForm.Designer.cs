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
            SuspendLayout();
            // 
            // btnRespaldar
            // 
            btnRespaldar.Location = new Point(203, 85);
            btnRespaldar.Name = "btnRespaldar";
            btnRespaldar.Size = new Size(186, 42);
            btnRespaldar.TabIndex = 0;
            btnRespaldar.Text = "Respaldar Datos";
            btnRespaldar.UseVisualStyleBackColor = true;
            btnRespaldar.Click += btnRespaldar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(203, 173);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(186, 42);
            btnRestaurar.TabIndex = 1;
            btnRestaurar.Text = "Restaurar Datos";
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // RespaldoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(600, 450);
            Controls.Add(btnRestaurar);
            Controls.Add(btnRespaldar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RespaldoForm";
            Text = "RespaldoForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRespaldar;
        private Button btnRestaurar;
    }
}