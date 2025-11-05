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
    public partial class VentaForm : Form, ITraducible
    {
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
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void ActualizarDataGridViewProductos(IEnumerable<Producto> newDataSource)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = newDataSource;
            dgvProductos.Columns["IdProducto"].Visible = false;
            dgvProductos.Columns["PrecioUnitario"].DefaultCellStyle.Format = "e";
        }


    }
}
