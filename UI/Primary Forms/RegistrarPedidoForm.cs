using BLL.Implementations;
using Domain;
using Services.BLL.Contracts;
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

namespace UI.Primary_Forms
{
    public partial class RegistrarPedidoForm : Form, ITraducible
    {
        public Cliente clienteAsociado;
        public Repartidor repartidorAsociado;
        public Venta ventaAsociada;
        public Pedido pedidoCreado;
        public RegistrarPedidoForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConsultarClienteForm consultarClienteForm = new ConsultarClienteForm())
                {
                    consultarClienteForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    var resultado = consultarClienteForm.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        clienteAsociado = consultarClienteForm.clienteBuscado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                pedidoCreado = new Pedido()
                {
                    IdPedido = Guid.NewGuid(),
                    Cliente = clienteAsociado,
                    Repartidor = repartidorAsociado,
                    Venta = ventaAsociada
                };
                PedidoService.Current.Add(pedidoCreado);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAsignarRepartidor_Click(object sender, EventArgs e)
        {
            try
            {
                using (SeleccionarRepartidorForm seleccionarRepartidorForm = new SeleccionarRepartidorForm())
                {
                    var resultado = seleccionarRepartidorForm.ShowDialog();
                    if (resultado == DialogResult.OK)
                    {
                        repartidorAsociado = seleccionarRepartidorForm.repartidorSeleccionado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrarPedidoForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
