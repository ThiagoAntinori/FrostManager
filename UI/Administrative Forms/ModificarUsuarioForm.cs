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
    public partial class ModificarUsuarioForm : Form
    {
        private Usuario usuarioSeleccionado = null;
        public ModificarUsuarioForm()
        {
            InitializeComponent();
        }

        private void ModificarUsuarioForm_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDataGridUsuarios(dgvUsuarios);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public static void CargarDataGridUsuarios(DataGridView dgvUsuarios)
        {
            try
            {
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = UsuarioService.Current.SelectAll();
                dgvUsuarios.Columns["IdUsuario"].HeaderText = "ID";
                dgvUsuarios.Columns["CorreoElectronico"].HeaderText = "Correo electrónico";
                dgvUsuarios.Columns["Password"].Visible = false;
                dgvUsuarios.Columns["EstaHabilitado"].HeaderText = "Está habilitado";
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
                    txtNombreUsuario.Text = usuario.Nombre;
                    txtCorreoElectronico.Text = usuario.CorreoElectronico;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                usuarioSeleccionado.Nombre = txtNombreUsuario.Text;
                usuarioSeleccionado.CorreoElectronico = txtCorreoElectronico.Text;
                UsuarioService.Current.Update(usuarioSeleccionado);
                MessageBox.Show("Se modificó el usuario correctamente");
                txtNombreUsuario.Text = string.Empty;
                txtCorreoElectronico.Text = string.Empty;
                CargarDataGridUsuarios(dgvUsuarios);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MainAdministrativeForm.CloseChildForm(this);
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {

        }
    }
}
