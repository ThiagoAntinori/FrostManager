using Services.BLL.Contracts;
using Services.BLL.DTOs;
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

namespace UI
{
    public partial class SettingsForm : Form, ITraducible
    {
        public SettingsForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                if (UsuarioLogueado.Current.Usuario == null)
                {
                    throw new Exception("No se encontró al usuario logueado.");
                }
                txtCorreo.Text = UsuarioLogueado.Current.Usuario.CorreoElectronico;
                ConfigurarComboIdiomas();
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
                    usuarioLogueado.CorreoElectronico = txtCorreo.Text;
                    UsuarioService.Current.Update(usuarioLogueado);
                    MessageBox.Show("El correo electrónico fue actualizado con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if(cmbIdioma.SelectedValue != null)
                {
                    if (MessageBox.Show($"¿Desea cambiar el idioma a {cmbIdioma.Text}?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        IdiomaService.Current.CambiarIdioma((string)cmbIdioma.SelectedValue);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarContraseña_Click(object sender, EventArgs e)
        {
            try
            {
                SesionService.CambiarContraseña(UsuarioLogueado.Current.Usuario.Nombre, txtContraseñaActual.Text, txtNuevaContraseña.Text);
                MessageBox.Show("Contraseña cambiada correctamente");
                UIHelper.LimpiarCampos(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfigurarComboIdiomas()
        {
            List<IdiomaDTO> idiomas = IdiomaService.Current.ObtenerIdiomasParaDisplay();
            cmbIdioma.DataSource = idiomas;
            cmbIdioma.DisplayMember = "NombreDisplay";
            cmbIdioma.ValueMember = "CodigoCultura";
            string culturaActual = UsuarioLogueado.Current.IdiomaSeleccionado;
            cmbIdioma.SelectedValue = culturaActual;
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
    }
}
