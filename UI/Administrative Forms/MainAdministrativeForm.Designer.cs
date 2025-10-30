namespace UI.Administrative_Forms
{
    partial class MainAdministrativeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdministrativeForm));
            panelSideMenu = new Panel();
            btnVerUsuarios = new Button();
            btnCambiarEstadoUsuario = new Button();
            btnEditarUsuario = new Button();
            btnRegistrarUsuario = new Button();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panelChildForm = new Panel();
            pictureBox2 = new PictureBox();
            btnRespaldo = new Button();
            panelSideMenu.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.Controls.Add(btnRespaldo);
            panelSideMenu.Controls.Add(btnVerUsuarios);
            panelSideMenu.Controls.Add(btnCambiarEstadoUsuario);
            panelSideMenu.Controls.Add(btnEditarUsuario);
            panelSideMenu.Controls.Add(btnRegistrarUsuario);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(200, 450);
            panelSideMenu.TabIndex = 0;
            // 
            // btnVerUsuarios
            // 
            btnVerUsuarios.Dock = DockStyle.Top;
            btnVerUsuarios.FlatAppearance.BorderSize = 0;
            btnVerUsuarios.FlatStyle = FlatStyle.Flat;
            btnVerUsuarios.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVerUsuarios.ForeColor = SystemColors.ControlLightLight;
            btnVerUsuarios.Location = new Point(0, 247);
            btnVerUsuarios.Name = "btnVerUsuarios";
            btnVerUsuarios.Size = new Size(200, 40);
            btnVerUsuarios.TabIndex = 4;
            btnVerUsuarios.Text = "Ver Usuarios";
            btnVerUsuarios.UseVisualStyleBackColor = true;
            btnVerUsuarios.Click += btnVerUsuarios_Click;
            // 
            // btnCambiarEstadoUsuario
            // 
            btnCambiarEstadoUsuario.Dock = DockStyle.Top;
            btnCambiarEstadoUsuario.FlatAppearance.BorderSize = 0;
            btnCambiarEstadoUsuario.FlatStyle = FlatStyle.Flat;
            btnCambiarEstadoUsuario.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCambiarEstadoUsuario.ForeColor = SystemColors.ControlLightLight;
            btnCambiarEstadoUsuario.Location = new Point(0, 207);
            btnCambiarEstadoUsuario.Name = "btnCambiarEstadoUsuario";
            btnCambiarEstadoUsuario.Size = new Size(200, 40);
            btnCambiarEstadoUsuario.TabIndex = 3;
            btnCambiarEstadoUsuario.Text = "Cambiar Estado Usuario";
            btnCambiarEstadoUsuario.UseVisualStyleBackColor = true;
            btnCambiarEstadoUsuario.Click += btnCambiarEstadoUsuario_Click;
            // 
            // btnEditarUsuario
            // 
            btnEditarUsuario.Dock = DockStyle.Top;
            btnEditarUsuario.FlatAppearance.BorderSize = 0;
            btnEditarUsuario.FlatStyle = FlatStyle.Flat;
            btnEditarUsuario.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarUsuario.ForeColor = SystemColors.ControlLightLight;
            btnEditarUsuario.Location = new Point(0, 167);
            btnEditarUsuario.Name = "btnEditarUsuario";
            btnEditarUsuario.Size = new Size(200, 40);
            btnEditarUsuario.TabIndex = 2;
            btnEditarUsuario.Text = "Modificar Usuario";
            btnEditarUsuario.UseVisualStyleBackColor = true;
            btnEditarUsuario.Click += btnEditarUsuario_Click;
            // 
            // btnRegistrarUsuario
            // 
            btnRegistrarUsuario.Dock = DockStyle.Top;
            btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            btnRegistrarUsuario.FlatStyle = FlatStyle.Flat;
            btnRegistrarUsuario.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrarUsuario.ForeColor = SystemColors.ControlLightLight;
            btnRegistrarUsuario.Location = new Point(0, 127);
            btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            btnRegistrarUsuario.Size = new Size(200, 40);
            btnRegistrarUsuario.TabIndex = 1;
            btnRegistrarUsuario.Text = "Registrar Usuario";
            btnRegistrarUsuario.UseVisualStyleBackColor = true;
            btnRegistrarUsuario.Click += btnRegistrarUsuario_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 127);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.FrostManagerLogo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.DarkBlue;
            panelChildForm.Controls.Add(pictureBox2);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(200, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(600, 450);
            panelChildForm.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.FrostManagerLogo;
            pictureBox2.Location = new Point(160, 107);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(311, 213);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnRespaldo
            // 
            btnRespaldo.Dock = DockStyle.Top;
            btnRespaldo.FlatAppearance.BorderSize = 0;
            btnRespaldo.FlatStyle = FlatStyle.Flat;
            btnRespaldo.Font = new Font("Microsoft JhengHei UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRespaldo.ForeColor = SystemColors.ControlLightLight;
            btnRespaldo.Location = new Point(0, 287);
            btnRespaldo.Name = "btnRespaldo";
            btnRespaldo.Size = new Size(200, 40);
            btnRespaldo.TabIndex = 5;
            btnRespaldo.Text = "Respaldar Datos";
            btnRespaldo.UseVisualStyleBackColor = true;
            btnRespaldo.Click += btnRespaldo_Click;
            // 
            // MainAdministrativeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainAdministrativeForm";
            Text = "MainAdministrativeForm";
            panelSideMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSideMenu;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnVerUsuarios;
        private Button btnCambiarEstadoUsuario;
        private Button btnEditarUsuario;
        private Button btnRegistrarUsuario;
        private Panel panelChildForm;
        private PictureBox pictureBox2;
        private Button btnRespaldo;
    }
}