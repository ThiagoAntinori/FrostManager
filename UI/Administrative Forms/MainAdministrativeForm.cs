using Services.BLL.Contracts;
using Services.BLL.Extensions;
using Services.BLL.Services;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Tools;

namespace UI.Administrative_Forms
{
    public partial class MainAdministrativeForm : Form, ITraducible
    {
        public MainAdministrativeForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
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

        private void btnRegistrarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new RegistrarFamiliaForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new ModificarFamiliaForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new EliminarFamiliaForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new RegistrarPatenteForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new ModificarPatenteForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarPatente_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new EliminarPatenteForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerBitacora_Click(object sender, EventArgs e)
        {
            try
            {
                OpenChildForm(new VerBitacoraForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CambiarIdioma()
        {
            try
            {
                UIHelper.TraducirControles(this.Controls);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void MainAdministrativeForm_Load(object sender, EventArgs e)
        {
            try
            {
                if(UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
