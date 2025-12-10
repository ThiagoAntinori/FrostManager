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
    public partial class ConsultarStockActualForm : Form, ITraducible
    {
        Insumo insumoSeleccionado;
        public ConsultarStockActualForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void ConsultarStockActualForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoInsumos();
                cmbTipoInsumo.DataSource = null;
                cmbTipoInsumo.DataSource = new List<string>()
                {
                    "Envase",
                    "Sabor",
                    "(Todos)"
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListadoInsumos()
        {
            dgvStock.DataSource = null;
            dgvStock.DataSource = InsumoService.Current.SelectAll();
            dgvStock.Columns["IdInsumo"].Visible = false;
            dgvStock.Columns["StockActual"].HeaderText = "Stock Actual";
            dgvStock.Columns["StockMinimo"].HeaderText = "Stock Mínimo";
        }

        private void dgvStock_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvStock.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvStock.SelectedRows[0];

                    insumoSeleccionado = filaSeleccionada.DataBoundItem as Insumo;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTipoInsumo_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoInsumo.SelectedIndex > 0)
                {
                    FiltrarPorTipoInsumo(cmbTipoInsumo.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
            dgvStock.DataSource = null;
            dgvStock.DataSource = insumosPorFiltro;
            dgvStock.Columns["IdInsumo"].Visible = false;
            dgvStock.Columns["StockActual"].HeaderText = "Stock Actual";
            dgvStock.Columns["StockMinimo"].HeaderText = "Stock Mínimo";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(InsumoService.Current.ConsultarStock(insumoSeleccionado), "CONSULTA STOCK", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
