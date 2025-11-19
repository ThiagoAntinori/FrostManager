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

namespace UI
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.Usuario == null)
                {
                    throw new Exception("No se encontró al usuario logueado.");
                }
                txtCorreo.Text = UsuarioLogueado.Current.Usuario.CorreoElectronico;
                cmbIdioma.Items.Add("es-ES");
                cmbIdioma.Items.Add("en-US");
            }
            catch (Exception ex)
            {
                ex.Handle();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCorreo.Text != UsuarioLogueado.Current.Usuario.CorreoElectronico)
                {
                    Usuario usuarioLogueado = UsuarioLogueado.Current.Usuario;
                    UsuarioService.Current.Update(usuarioLogueado);
                    MessageBox.Show("El correo electrónico fue actualizado con exito");
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show($"¿Desea cambiar el idioma a {cmbIdioma.SelectedItem}?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    IdiomaService.Current.CambiarIdioma((string)cmbIdioma.SelectedItem);
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                SesionService.CambiarContraseña(UsuarioLogueado.Current.Usuario.Nombre, txtContraseñaActual.Text, txtNuevaContraseña.Text);
                MessageBox.Show("Contraseña cambiada correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
