using BLL.Implementations;
using Domain;
using Services.BLL.Contracts;
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

namespace UI.Primary_Forms
{
    public partial class GestionarPedidosForm : Form, ITraducible
    {
        Pedido pedidoSeleccionado;
        public GestionarPedidosForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void GestionarPedidosForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarDgvPedidos(PedidoService.Current.SelectAll());
                cmbNuevoEstado.DataSource = Enum.GetValues(typeof(EstadoPedido)).Cast<EstadoPedido>().Where(e => e != EstadoPedido.Cancelado).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarDgvPedidos(IEnumerable<Pedido> dataSource)
        {
            dgvPedidos.DataSource = null;
            dgvPedidos.DataSource = dataSource;
            dgvPedidos.Columns["IdPedido"].Visible = false;
            dgvPedidos.Columns["Venta"].Visible = false;
            dgvPedidos.Columns["HoraEnvio"].HeaderText = "Hora de envío";
            dgvPedidos.Columns["HoraEntrega"].HeaderText = "Hora de entrega";
            dgvPedidos.Columns["Estado"].HeaderText = "Estado";
            dgvPedidos.Columns["Cliente"].HeaderText = "Cliente";
            dgvPedidos.Columns["Repartidor"].HeaderText = "Repartidor asignado";
        }

        private void dgvPedidos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvPedidos.SelectedRows[0];

                    pedidoSeleccionado = filaSeleccionada.DataBoundItem as Pedido;

                    if (pedidoSeleccionado != null)
                    {
                        //cmbNuevoEstado.SelectedItem = pedidoSeleccionado.Estado;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoService.Current.CambiarEstado(pedidoSeleccionado, (EstadoPedido)cmbNuevoEstado.SelectedItem);
                MessageBox.Show("Pedido actualizado correctamente");
                ActualizarDgvPedidos(PedidoService.Current.SelectAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarPedido_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea cancelar el pedido seleccionado?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    PedidoService.Current.CambiarEstado(pedidoSeleccionado, EstadoPedido.Cancelado);
                    MessageBox.Show("Pedido cancelado exitosamente");
                    ActualizarDgvPedidos(PedidoService.Current.SelectAll());
                }
            }
            catch(Exception ex)
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
