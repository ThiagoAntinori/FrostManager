using Services.BLL.Contracts;
using Services.BLL.Extensions;
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
using UI.Tools;

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

        public static Form activeForm = null;

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
            childForm.Close();
            activeForm = null;
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new RegistrarClienteForm());
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
                UIHelper.TraducirControles(this.Controls);
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioLogueado.CerrarSesion();
                this.DialogResult = DialogResult.Retry;
                this.Close();
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

        private void btnConfiguracion_Click_1(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new SettingsForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {

            try
            {
                openChildForm(new CrearProductoForm());
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        private void btnRegistrarInsumo_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new CrearInsumoForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                openChildForm(new ModificarClienteForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarIngreso_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new RegistrarIngresoForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ConsultarClienteForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new GestionarPedidosForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAjustarStock_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new AjustarStockForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConsultarStock_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ConsultarStockActualForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ModificarProductoForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new EliminarProductoForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new RegistrarRepartidorForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new CierreCajaDiariaForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ReporteVentasForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReporteSabores_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ReporteSaboresForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReporteEntregas_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ReporteEntregasForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarRepartidor_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new ModificarRepartidorForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrarEgreso_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new RegistrarEgresoForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
