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
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarCorreo_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCorreo.Text != UsuarioLogueado.Current.Usuario.CorreoElectronico)
                {
                    Usuario usuarioLogueado = UsuarioLogueado.Current.Usuario;
                    UsuarioService.Current.Update(usuarioLogueado);
                    MessageBox.Show("El correo electrónico fue actualizado con exito");
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
