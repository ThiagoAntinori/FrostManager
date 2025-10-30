using BLL.Implementations;
using Domain;
using Services.BLL.Extensions;
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
    public partial class CrearProductoForm : Form
    {
        public CrearProductoForm()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevoProducto = new Producto()
                {
                    IdProducto = Guid.NewGuid(),
                    Descripcion = txtNombre.Text,
                    CapacidadEnGramos = Convert.ToInt32(txtCapacidad.Text),
                    PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text),
                    EnvaseNecesario = (Envase)cmbEnvaseNecesario.SelectedValue
                };

                ProductoService.Current.Add(nuevoProducto);
                MessageBox.Show("Producto registrado exitosamente");
                UIHelper.LimpiarCampos(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void CrearProductoForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbEnvaseNecesario.DataSource = EnvaseService.Current.SelectAll();
                cmbEnvaseNecesario.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
