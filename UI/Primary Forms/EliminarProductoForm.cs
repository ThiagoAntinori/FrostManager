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
    public partial class EliminarProductoForm : Form, ITraducible
    {
        Producto productoSeleccionado;
        public EliminarProductoForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
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

        private void EliminarProductoForm_Load(object sender, EventArgs e)
        {
            try
            {
                if(UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoProductos(ProductoService.Current.SelectAll());
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show($"¿Desea eliminar el producto seleccionado ({productoSeleccionado.Descripcion})?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ProductoService.Current.Delete(productoSeleccionado);
                    MessageBox.Show("ELIMINADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarListadoProductos(ProductoService.Current.SelectAll());
                    productoSeleccionado = null;
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
