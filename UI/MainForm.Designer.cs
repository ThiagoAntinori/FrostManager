namespace UI
{
    partial class MainForm
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
            msMenuPrincipal = new MenuStrip();
            SuspendLayout();
            // 
            // msMenuPrincipal
            // 
            msMenuPrincipal.Location = new Point(0, 0);
            msMenuPrincipal.Name = "msMenuPrincipal";
            msMenuPrincipal.Size = new Size(800, 24);
            msMenuPrincipal.TabIndex = 0;
            msMenuPrincipal.Text = "menuStrip1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(msMenuPrincipal);
            MainMenuStrip = msMenuPrincipal;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip msMenuPrincipal;
    }
}