using BLL.Implementations;
using Domain;
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
    public partial class RegistrarIngresoForm : Form
    {
        private Insumo insumoSeleccionado = null;
        public RegistrarIngresoForm()
        {
            InitializeComponent();
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
                    throw new ArgumentException("El campo Descripcion no puede estar vacío");
                }
                BuscarPorDescripcion(txtDescripcionBuscar.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                MovimientoStock movimientoStockIngreso = new MovimientoStock()
                {
                    IdMovimientoStock = Guid.NewGuid(),
                    Cantidad = Convert.ToInt32(txtCantidadAIngresar.Text),
                    Motivo = txtMotivo.Text,
                    FechaHora = DateTime.Now,
                    TipoMovimiento = TipoMovimientoStock.Ingreso,
                    Insumo = insumoSeleccionado
                };
                InsumoService.Current.RegistrarIngreso(insumoSeleccionado, movimientoStockIngreso);
                ActualizarListadoInsumos(dgvInsumos);
                MessageBox.Show("Se registró el ingreso correctamente");
                UIHelper.LimpiarCampos(this.Controls);
                insumoSeleccionado = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ActualizarListadoInsumos(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = InsumoService.Current.SelectAll();
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
            dgvInsumos.DataSource = null;
            dgvInsumos.DataSource = insumosPorFiltro;
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

        private void RegistrarIngresoForm_Load(object sender, EventArgs e)
        {
            try
            {
                ActualizarListadoInsumos(dgvInsumos);
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
    }
}

