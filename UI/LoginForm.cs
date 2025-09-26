using Services.BLL.Services;
using Services.Domain.Security;
using Services.Domain.Logging;
using Services.BLL.Contracts;

namespace UI
{
    public partial class LoginForm : Form, ITraducible
    {
        public LoginForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        public void CambiarIdioma()
        {
            try
            {
                TraducirControles(this.Controls);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                SesionService.Login(txtNombreUsuario.Text, txtPassword.Text);
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TraducirControles(Control.ControlCollection controles)
        {
            try
            {
                foreach (Control ctrl in controles)
                {
                    if (ctrl.Name != null)
                    {
                        if (ctrl.Visible == true)
                        {
                            if (ctrl is Button || ctrl is Label)
                            {
                                ctrl.Text = IdiomaService.Current.Traducir(ctrl.Name);
                            }
                        }
                    }
                    if (ctrl.HasChildren)
                    {
                        TraducirControles(ctrl.Controls);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void linkOlvideContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                RecuperarContraseñaForm recuperarContraseñaForm = new RecuperarContraseñaForm();
                recuperarContraseñaForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
