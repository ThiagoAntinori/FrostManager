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

namespace UI.Administrative_Forms
{
    public partial class CambiarEstadoUsuarioForm : Form
    {
        public CambiarEstadoUsuarioForm()
        {
            InitializeComponent();
        }

        private Usuario usuarioSeleccionado = null;

        private void CambiarEstadoUsuarioForm_Load(object sender, EventArgs e)
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

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvUsuarios.CurrentRow != null && dgvUsuarios.CurrentRow.DataBoundItem is Usuario usuario)
                {
                    usuarioSeleccionado = usuario;
                    lblUsuarioSeleccionado.Text = usuario.Nombre;
                    lblEstadoActualUsuario.Text = usuario.EstaHabilitado ? "ACTIVO" : "INACTIVO";
                    lblEstadoActualUsuario.ForeColor = usuario.EstaHabilitado ? Color.Green : Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioService.Current.CambiarEstado(usuarioSeleccionado);
                MessageBox.Show("Se actualizó el usuario correctamente");
                ModificarUsuarioForm.CargarDataGridUsuarios(dgvUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                MainAdministrativeForm.CloseChildForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
