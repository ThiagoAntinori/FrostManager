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
    public partial class RecuperarContraseñaForm : Form
    {
        public RecuperarContraseñaForm()
        {
            InitializeComponent();
        }

        private void btnSolicitarToken_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtUsuarioSolicitud.Text))
                {
                    throw new Exception("Ingrese su nombre de usuario para recuperar la contraseña");
                }
                Usuario usuarioIngresado = UsuarioService.Current.GetByNombreUsuario(txtUsuarioSolicitud.Text);
                SesionService.RecuperarContraseña(usuarioIngresado);
                MessageBox.Show("Se envío un token de recuperación a su correo electrónico");
                txtUsuarioSolicitud.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRestablecerContrasena_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNuevaPassword.Text != txtConfirmarNuevaPassword.Text)
                {
                    throw new Exception("Las contraseñas no coinciden");
                }
                SesionService.CambiarContraseña(txtToken.Text, txtNuevaPassword.Text);
                MessageBox.Show("La contraseña fue cambiada correctamente. Regresa a la pantalla principal para iniciar sesión.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
