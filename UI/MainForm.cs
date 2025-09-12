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
using UI.Primary_Forms;

namespace UI
{
    public partial class MainForm : Form
    {
        private Dictionary<string, Button> mapaPermisos;
        public MainForm()
        {
            InitializeComponent();
            mapaPermisos = new Dictionary<string, Button>()
            {
                {"REGISTRAR_VENTA", btnRegistrarVenta },
                {"REGISTRAR_CLIENTE", btnRegistrarCliente },
                {"MODIFICAR_CLIENTE", btnModificarCliente },
                {"CONSULTAR_CLIENTE", btnConsultarCliente },
                {"VER_PEDIDOS", btnVerPedidos },
                {"ACTUALIZAR_PEDIDO", btnActualizarPedido },
                {"CANCELAR_PEDIDO", btnCancelarPedido },
                {"REGISTAR_INGRESO", btnRegistrarIngreso },
                {"REGISTRAR_EGRESO", btnRegistrarEgreso },
                {"REGISTRAR_INSUMO", btnRegistrarInsumo },
                {"AJUSTAR_STOCK", btnAjustarStock },
                {"CONSULTAR_STOCK", btnConsultarStock },
                {"REPORTE_VENTAS", btnReporteVentas },
                {"CIERRE_CAJA", btnCierreCaja },
                {"REPORTE_SABORES", btnReporteSabores },
                {"REPORTE_ENTREGAS", btnReporteEntregas },
                {"REPORTE_PROYECCION", btnReporteProyecciones }
            };
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
                List<string> nombresPatente = UsuarioLogueado.Current.Usuario.GetAllPatentes().Select(p => p.Nombre).ToList();
                if (nombresPatente.Count == 0)
                {
                    throw new Exception("No se le asignó ningún permiso. Contacte al administrador.");
                }
                foreach (var keyValue in mapaPermisos)
                {
                    keyValue.Value.Visible = nombresPatente.Contains(keyValue.Key);
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
                activeForm.Close();
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

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                openChildForm(new AltaClienteForm());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
