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
    public partial class AjustarStockForm : Form, ITraducible
    {
        Insumo insumoSeleccionado;
        public AjustarStockForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void AjustarStockForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                cmbTipoInsumo.DataSource = new List<string>()
                {
                    "Envase",
                    "Sabor",
                    "(Todos)"
                };
                ActualizarListadoInsumos(InsumoService.Current.SelectAll());
                cmbTipoInsumo.SelectedIndex = -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ActualizarListadoInsumos(IEnumerable<Insumo> dataSource)
        {
            dgvInsumos.DataSource = null;
            dgvInsumos.DataSource = dataSource;
            dgvInsumos.Columns["IdInsumo"].Visible = false;
        }

        private void FiltrarPorTipoInsumo(string tipoInsumo)
        {
            List<Insumo> insumosPorFiltro = new List<Insumo>();
            if (tipoInsumo == "Envase")
            {
                insumosPorFiltro = InsumoService.Current.SelectAll().Where(i => i is Envase).ToList();
            }
            else if (tipoInsumo == "Sabor")
            {
                insumosPorFiltro = InsumoService.Current.SelectAll().Where(i => i is Sabor).ToList();
            }
            else
            {
                insumosPorFiltro = (List<Insumo>)InsumoService.Current.SelectAll();
            }
            ActualizarListadoInsumos(insumosPorFiltro);
        }

        private void BuscarPorDescripcion(string descripcion)
        {
            List<Insumo> listado = (List<Insumo>)dgvInsumos.DataSource;
            dgvInsumos.DataSource = null;
            dgvInsumos.DataSource = listado.Where(i => i.Descripcion.StartsWith(descripcion)).ToList();
            if (dgvInsumos.Rows.Count == 0)
            {
                throw new Exception("No se encontraron coincidencias");
            }
        }

        private void cmbTipoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FiltrarPorTipoInsumo(cmbTipoInsumo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescripcionBuscar.Text))
                {
                    throw new ArgumentNullException("El campo Descripcion no puede estar vacío");
                }
                BuscarPorDescripcion(txtDescripcionBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptarAjuste_Click(object sender, EventArgs e)
        {
            try
            {
                MovimientoStock movimientoStockIngreso = new MovimientoStock()
                {
                    IdMovimientoStock = Guid.NewGuid(),
                    Cantidad = Convert.ToInt32(txtCantidadAjustar.Text),
                    Motivo = txtMotivo.Text,
                    FechaHora = DateTime.Now,
                    TipoMovimiento = TipoMovimientoStock.Ajuste,
                    Insumo = insumoSeleccionado
                };
                InsumoService.Current.ActualizarStock(insumoSeleccionado, movimientoStockIngreso);
                ActualizarListadoInsumos(InsumoService.Current.SelectAll());
                MessageBox.Show("REGISTRADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                UIHelper.LimpiarCampos(this.Controls);
                insumoSeleccionado = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInsumos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvInsumos.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvInsumos.SelectedRows[0];

                    insumoSeleccionado = filaSeleccionada.DataBoundItem as Insumo;

                    if (insumoSeleccionado != null)
                    {
                        lblDescripcionSeleccionado.Text = insumoSeleccionado.Descripcion;
                    }
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
