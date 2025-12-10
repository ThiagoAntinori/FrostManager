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
    public partial class ModificarProductoForm : Form, ITraducible
    {
        Producto productoSeleccionado;
        public ModificarProductoForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void ModificarProductoForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoProductos(ProductoService.Current.SelectAll());
                cmbEnvaseNecesario.DataSource = EnvaseService.Current.SelectAll();
                cmbEnvaseNecesario.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListadoProductos(IEnumerable<Producto> dataSource)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = dataSource;
            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["PrecioUnitario"].DefaultCellStyle.Format = "C";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarNombre.Text))
                {
                    ActualizarListadoProductos(ProductoService.Current.SelectAll().
                        Where(p => p.Descripcion.StartsWith(txtBuscarNombre.Text)));
                }
                else
                {
                    ActualizarListadoProductos(ProductoService.Current.SelectAll());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                productoSeleccionado.Descripcion = txtNombre.Text;
                productoSeleccionado.CapacidadEnGramos = Convert.ToInt32(txtCapacidad.Text);
                productoSeleccionado.PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                productoSeleccionado.EnvaseNecesario = (Envase)cmbEnvaseNecesario.SelectedItem;
                ProductoService.Current.Update(productoSeleccionado);
                MessageBox.Show("MODIFICADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                UIHelper.LimpiarCampos(this.Controls);
                ActualizarListadoProductos(ProductoService.Current.SelectAll());
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
                if(dgvProductos.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvProductos.SelectedRows[0];

                    productoSeleccionado = filaSeleccionada.DataBoundItem as Producto;
                    
                    if(productoSeleccionado != null)
                    {
                        txtNombre.Text = productoSeleccionado.Descripcion;
                        txtCapacidad.Text = productoSeleccionado.CapacidadEnGramos.ToString();
                        txtPrecioUnitario.Text = productoSeleccionado.PrecioUnitario.ToString();
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
