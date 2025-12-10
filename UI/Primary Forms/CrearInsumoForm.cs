using BLL.Factory;
using BLL.Implementations;
using BLL.Tools;
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
    public partial class CrearInsumoForm : Form, ITraducible
    {
        public CrearInsumoForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void CrearInsumoForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbTipoInsumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCapacidad.Visible = cmbTipoInsumo.SelectedItem == "Envase";
            lblCapacidad.Visible = cmbTipoInsumo.SelectedItem == "Envase";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                InsumoFactory insumoFactory = null;
                ValidationHelper.NotNull(cmbTipoInsumo.SelectedItem, "TipoInsumo");
                if(cmbTipoInsumo.SelectedItem == "Envase")
                {
                    insumoFactory = new EnvaseFactory();
                }
                else if(cmbTipoInsumo.SelectedItem == "Sabor")
                {
                    insumoFactory = new SaborFactory();
                }
                Insumo nuevoInsumo = insumoFactory.CrearInsumo();
                nuevoInsumo.IdInsumo = Guid.NewGuid();
                nuevoInsumo.StockActual = Convert.ToInt32(txtStockInicial.Text);
                nuevoInsumo.StockMinimo = Convert.ToInt32(txtStockMinimo.Text);
                if(nuevoInsumo is Envase envase)
                {
                    envase.Descripcion = txtDescripcion.Text;
                    envase.CapacidadEnGramos = Convert.ToInt32(txtCapacidad.Text);
                }
                if(nuevoInsumo is Sabor sabor)
                {
                    sabor.Descripcion = txtDescripcion.Text;
                }
                InsumoService.Current.Add(nuevoInsumo);
                MessageBox.Show("REGISTRADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                UIHelper.LimpiarCampos(this.Controls);
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
