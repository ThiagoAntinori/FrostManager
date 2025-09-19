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

        private void btnEnviarToken_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNombreUsuario.Text))
                {
                    throw new Exception("Ingrese su nombre de usuario para recuperar la contraseña");
                }
                Usuario usuarioIngresado = UsuarioService.Current.GetByNombreUsuario(txtNombreUsuario.Text);
                SesionService.RecuperarContraseña(usuarioIngresado);
                MessageBox.Show("Se envío un token de recuperación a su correo electrónico");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                SesionService.IniciarSesionToken(txtToken.Text);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
