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

namespace UI.Primary_Forms
{
    public partial class SeleccionarSaboresForm : Form
    {
        public List<SaborSeleccionado> saboresSeleccionados = new List<SaborSeleccionado>();
        public Sabor saborSeleccionado;
        public SeleccionarSaboresForm()
        {
            InitializeComponent();
        }

        private void SeleccionarSaboresForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvSabores.DataSource = null;
                dgvSabores.DataSource = SaborService.Current.SelectAll();
                dgvSabores.Columns["StockMinimo"].Visible = false;
                dgvSabores.Columns["StockActual"].Visible = false;
                dgvSabores.Columns["IdInsumo"].HeaderText = "ID";
                btnDeshacer.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarDgvSaboresSeleccionados()
        {
            dgvSaboresSeleccionados.DataSource = null;
            dgvSaboresSeleccionados.DataSource = saboresSeleccionados;
            dgvSaboresSeleccionados.Columns["IdDetalleVenta"].Visible = false;
            dgvSaboresSeleccionados.Columns["CantidadEnGramos"].Visible = false;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (saborSeleccionado == null)
                {
                    throw new Exception("Selecciona un sabor para añadir");
                }
                saboresSeleccionados.Add(new SaborSeleccionado()
                {
                    Sabor = saborSeleccionado,
                    CantidadEnGramos = 0
                });
                ActualizarDgvSaboresSeleccionados();
                btnDeshacer.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSabores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSabores.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvSabores.SelectedRows[0];

                    saborSeleccionado = filaSeleccionada.DataBoundItem as Sabor;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            try
            {
                saboresSeleccionados.RemoveAt(saboresSeleccionados.Count - 1);
                ActualizarDgvSaboresSeleccionados();
                if (saboresSeleccionados.Count == 0)
                {
                    btnDeshacer.Enabled = false;
                }
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
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelarSeleccion_Click(object sender, EventArgs e)
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
    }
}
