using BLL.Implementations;
using DAL.Implementations.Factory;
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
    public partial class VentaForm : Form, ITraducible
    {
        Producto productoSeleccionado;
        Venta ventaEnCurso;
        DetalleVenta detalleVentaSeleccionado;
        public VentaForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
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

        private void VentaForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarDataGridViewProductos(ProductoService.Current.SelectAll());
                if(VentaService.Current.SelectVentaEnCurso() != null)
                {
                    if(MessageBox.Show("Hay una venta en curso, ¿Desea continuarla?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ventaEnCurso = VentaService.Current.SelectVentaEnCurso();
                        ActualizarDataGridViewDetalles(DetalleVentaService.Current.GetByIdVenta(ventaEnCurso.IdVenta));
                    }
                    else
                    {
                        ventaEnCurso = new Venta()
                        {
                            IdVenta = Guid.NewGuid()
                        };
                        VentaService.Current.Add(ventaEnCurso);
                    }
                }
                else
                {
                    ventaEnCurso = new Venta()
                    {
                        IdVenta = Guid.NewGuid()
                    };
                    VentaService.Current.Add(ventaEnCurso);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarDataGridViewProductos(IEnumerable<Producto> newDataSource)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = newDataSource;
            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C";
            dgvProductos.Columns["PrecioUnitario"].HeaderText = "Precio";
            dgvProductos.Columns["EnvaseNecesario"].Visible = false;
        }

        private void ActualizarDataGridViewDetalles(IEnumerable<DetalleVenta> newDataSource)
        {
            dgvDetalleVenta.DataSource = null;
            dgvDetalleVenta.DataSource = newDataSource;
            dgvDetalleVenta.Columns["IdDetalleVenta"].Visible = false;
            dgvDetalleVenta.Columns["IdVenta"].Visible = false;
            dgvDetalleVenta.Columns["Producto"].DataPropertyName = "Producto.Descripcion";
            lblMontoTotal.Text = ventaEnCurso.CalcularTotal().ToString("C");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                ventaEnCurso.EsDelivery = checkDelivery.Checked;
                VentaService.Current.ConfirmarVenta(ventaEnCurso);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleVenta nuevoDetalle = new DetalleVenta()
                {
                    IdDetalleVenta = Guid.NewGuid(),
                    Producto = productoSeleccionado,
                    Cantidad = (int)numCantidad.Value,
                    IdVenta = ventaEnCurso.IdVenta
                };
                DetalleVentaService.Current.Add(nuevoDetalle);
                ventaEnCurso.AgregarDetalle(nuevoDetalle);
                //Selección de sabores
                ActualizarDataGridViewDetalles(DetalleVentaService.Current.GetByIdVenta(ventaEnCurso.IdVenta));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvProductos.SelectedRows[0];

                    productoSeleccionado = filaSeleccionada.DataBoundItem as Producto;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDetalleVenta_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalleVenta.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvDetalleVenta.SelectedRows[0];

                    detalleVentaSeleccionado = filaSeleccionada.DataBoundItem as DetalleVenta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DetalleVentaService.Current.Delete(detalleVentaSeleccionado);
                ventaEnCurso.RemoverDetalle(detalleVentaSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("¿Desea cancelar la venta en curso?", "Atención", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    VentaService.Current.Delete(ventaEnCurso);
                    MainForm.closeChildForm(this);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
