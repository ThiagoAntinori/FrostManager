namespace UI.Primary_Forms
{
    partial class VentaForm
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
            txtBuscarProducto = new TextBox();
            lvProductos = new ListView();
            lblSeleccioneProducto = new Label();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            button1 = new Button();
            listView1 = new ListView();
            label2 = new Label();
            button2 = new Button();
            button3 = new Button();
            checkBox1 = new CheckBox();
            button4 = new Button();
            label3 = new Label();
            lblMontoTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Anchor = AnchorStyles.None;
            txtBuscarProducto.Font = new Font("Segoe UI", 9.75F);
            txtBuscarProducto.ForeColor = SystemColors.WindowText;
            txtBuscarProducto.Location = new Point(42, 67);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.PlaceholderText = "Buscar por nombre";
            txtBuscarProducto.Size = new Size(162, 25);
            txtBuscarProducto.TabIndex = 0;
            // 
            // lvProductos
            // 
            lvProductos.Anchor = AnchorStyles.None;
            lvProductos.Font = new Font("Segoe UI", 9.75F);
            lvProductos.ForeColor = SystemColors.WindowText;
            lvProductos.Location = new Point(42, 106);
            lvProductos.Name = "lvProductos";
            lvProductos.Size = new Size(162, 239);
            lvProductos.TabIndex = 1;
            lvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // lblSeleccioneProducto
            // 
            lblSeleccioneProducto.Anchor = AnchorStyles.None;
            lblSeleccioneProducto.AutoSize = true;
            lblSeleccioneProducto.Font = new Font("Segoe UI", 9.75F);
            lblSeleccioneProducto.ForeColor = SystemColors.WindowText;
            lblSeleccioneProducto.Location = new Point(41, 34);
            lblSeleccioneProducto.Name = "lblSeleccioneProducto";
            lblSeleccioneProducto.Size = new Size(200, 17);
            lblSeleccioneProducto.TabIndex = 2;
            lblSeleccioneProducto.Text = "Seleccione un producto a añadir:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = SystemColors.WindowText;
            label1.Location = new Point(41, 370);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 3;
            label1.Text = "Ingrese la cantidad:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Anchor = AnchorStyles.None;
            numericUpDown1.Font = new Font("Segoe UI", 9.75F);
            numericUpDown1.ForeColor = SystemColors.WindowText;
            numericUpDown1.Location = new Point(156, 368);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(48, 25);
            numericUpDown1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 9.75F);
            button1.ForeColor = SystemColors.WindowText;
            button1.Location = new Point(108, 418);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 5;
            button1.Text = "Añadir";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.None;
            listView1.Font = new Font("Segoe UI", 9.75F);
            listView1.ForeColor = SystemColors.WindowText;
            listView1.Location = new Point(291, 106);
            listView1.Name = "listView1";
            listView1.Size = new Size(312, 239);
            listView1.TabIndex = 6;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = SystemColors.WindowText;
            label2.Location = new Point(519, 370);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 7;
            label2.Text = "TOTAL:";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Segoe UI", 9.75F);
            button2.ForeColor = SystemColors.WindowText;
            button2.Location = new Point(291, 366);
            button2.Name = "button2";
            button2.Size = new Size(138, 23);
            button2.TabIndex = 8;
            button2.Text = "Eliminar seleccionado";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Segoe UI", 9.75F);
            button3.ForeColor = SystemColors.WindowText;
            button3.Location = new Point(291, 418);
            button3.Name = "button3";
            button3.Size = new Size(138, 23);
            button3.TabIndex = 9;
            button3.Text = "Cancelar Venta";
            button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.Anchor = AnchorStyles.None;
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F);
            checkBox1.ForeColor = SystemColors.WindowText;
            checkBox1.Location = new Point(291, 520);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 21);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "¿Es delivery?";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.Font = new Font("Segoe UI", 9.75F);
            button4.ForeColor = SystemColors.WindowText;
            button4.Location = new Point(475, 515);
            button4.Name = "button4";
            button4.Size = new Size(128, 26);
            button4.TabIndex = 12;
            button4.Text = "Confirmar";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.ForeColor = SystemColors.WindowText;
            label3.Location = new Point(295, 37);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 13;
            label3.Text = "Detalle de venta";
            // 
            // lblMontoTotal
            // 
            lblMontoTotal.Anchor = AnchorStyles.None;
            lblMontoTotal.AutoSize = true;
            lblMontoTotal.Font = new Font("Segoe UI", 9.75F);
            lblMontoTotal.ForeColor = SystemColors.WindowText;
            lblMontoTotal.Location = new Point(519, 399);
            lblMontoTotal.Name = "lblMontoTotal";
            lblMontoTotal.Size = new Size(15, 17);
            lblMontoTotal.TabIndex = 14;
            lblMontoTotal.Text = "0";
            // 
            // VentaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 561);
            Controls.Add(lblMontoTotal);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Controls.Add(lblSeleccioneProducto);
            Controls.Add(lvProductos);
            Controls.Add(txtBuscarProducto);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VentaForm";
            Text = "Form1";
            Load += VentaForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscarProducto;
        private ListView lvProductos;
        private Label lblSeleccioneProducto;
        private Label label1;
        private NumericUpDown numericUpDown1;
        private Button button1;
        private ListView listView1;
        private Label label2;
        private Button button2;
        private Button button3;
        private CheckBox checkBox1;
        private Button button4;
        private Label label3;
        private Label lblMontoTotal;
    }
}