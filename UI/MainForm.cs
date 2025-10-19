using Services.BLL.Contracts;
using Services.BLL.Services;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Administrative_Forms;
using UI.Primary_Forms;

namespace UI
{
    public partial class MainForm : Form, ITraducible
    {
        public MainForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMenu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarMenu()
        {
            try
            {
                if (UsuarioLogueado.Current == null || UsuarioLogueado.Current.Usuario == null)
                {
                    throw new Exception("Error al mostrar permisos. Contacte al admistrador.");
                }
                List<Patente> patentesUsuario = UsuarioLogueado.Current.Usuario.GetAllPatentes().ToList();
                if (patentesUsuario.Count == 0)
                {
                    throw new Exception("No se le asignó ningún permiso. Contacte al administrador.");
                }
                foreach (Control ctrl in panelSideMenu.Controls)
                {
                    if (ctrl is Button)
                    {
                        ctrl.Visible = patentesUsuario.Select(p => p.MenuItemName).Contains(ctrl.Name);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                closeChildForm(activeForm);
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

        public static void closeChildForm(Form childForm)
        {
            if (MessageBox.Show("¿Desea cerrar la ventana? Se perderán los datos no guardados", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                childForm.Close();
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new AltaClienteForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

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

        public static void TraducirControles(Control.ControlCollection controles)
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
                                string nuevoTexto = IdiomaService.Current.Traducir(ctrl.Name);
                                ctrl.Text = nuevoTexto == null ? ctrl.Text : nuevoTexto;
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

        public static void LimpiarCampos(Control.ControlCollection controles)
        {
            try
            {
                foreach (Control ctrl in controles)
                {
                    if (ctrl.Name != null)
                    {
                        if (ctrl.Visible == true)
                        {
                            if (ctrl is TextBox)
                            {
                                ctrl.Text = string.Empty;
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

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea cambiar de idioma a Inglés?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    IdiomaService.Current.CambiarIdioma("en-US");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
                UsuarioLogueado.CerrarSesion();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new VentaForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRespaldarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Backup files (*.bak) | *.bak";
                    saveFileDialog.Title = "Guardar respaldo de Base de datos";
                    saveFileDialog.InitialDirectory = @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        BackupService.Current.HacerBackup(saveFileDialog.FileName,
                            ConfigurationManager.ConnectionStrings["BusinessConString"].ConnectionString);
                        MessageBox.Show("La base de datos fue respaldada con éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAbrirPanelAdministrativo_Click(object sender, EventArgs e)
        {
            try
            {
                MainAdministrativeForm mainAdminForm = new MainAdministrativeForm();
                this.WindowState = FormWindowState.Minimized;
                mainAdminForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
