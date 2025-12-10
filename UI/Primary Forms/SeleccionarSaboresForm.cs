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
    public partial class SeleccionarSaboresForm : Form, ITraducible
    {
        public List<SaborSeleccionado> saboresSeleccionados = new List<SaborSeleccionado>();
        public Sabor saborSeleccionado;
        public SeleccionarSaboresForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void SeleccionarSaboresForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarDgvSabores(SaborService.Current.SelectAll());
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

        private void ActualizarDgvSabores(IEnumerable<Sabor> dataSource)
        {
            dgvSabores.DataSource = null;
            dgvSabores.DataSource = dataSource;
            dgvSabores.Columns["StockMinimo"].Visible = false;
            dgvSabores.Columns["StockActual"].Visible = false;
            dgvSabores.Columns["IdInsumo"].Visible = false;
            btnDeshacer.Enabled = false;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (saborSeleccionado == null)
                {
                    throw new Exception("Selecciona un sabor para añadir");
                }
                if (saboresSeleccionados.Where(ss => ss.Sabor == saborSeleccionado).ToList().Count > 0)
                {
                    throw new Exception($"El sabor {saborSeleccionado.Descripcion} ya se encuentra seleccionado.");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Sabor> saboresFiltrados = string.IsNullOrEmpty(txtBuscarSabor.Text) ? 
                                                SaborService.Current.SelectAll().
                                                Where(s => s.Descripcion.StartsWith(txtBuscarSabor.Text)).ToList()
                                                : SaborService.Current.SelectAll().ToList();
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
                throw;
            }
        }
    }
}
