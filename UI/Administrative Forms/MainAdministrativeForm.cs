using Services.BLL.Extensions;
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
    public partial class MainAdministrativeForm : Form
    {
        public MainAdministrativeForm()
        {
            InitializeComponent();
        }

        private Form activeForm;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                CloseChildForm(activeForm);
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public static void CloseChildForm(Form childForm)
        {
            try
            {
                if (MessageBox.Show("¿Desea cerrar la ventana? Se perderán los datos no guardados", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    childForm.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new RegistrarUsuarioForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new ModificarUsuarioForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiarEstadoUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new CambiarEstadoUsuarioForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new VerUsuariosForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new RespaldoForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
