using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Administrative_Forms
{
    public partial class VerUsuariosForm : Form
    {
        public VerUsuariosForm()
        {
            InitializeComponent();
        }

        private void VerUsuariosForm_Load(object sender, EventArgs e)
        {
            try
            {
                ModificarUsuarioForm.CargarDataGridUsuarios(dgvUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
