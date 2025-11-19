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
    public partial class ConsultarClienteForm : Form
    {
        public Cliente clienteBuscado = null;
        public ConsultarClienteForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteBuscado = ClienteService.Current.SelectByDNI(txtDni.Text);
                if (clienteBuscado == null)
                {
                    if (MessageBox.Show($"No se encontró un cliente con el DNI {txtDni.Text}, ¿Desea crearlo?", "Atención", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                    }
                }
                ActualizarLabels(clienteBuscado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarLabels(Cliente clienteBuscado)
        {
            if(clienteBuscado != null)
            {
                lblNombreBuscado.Text = clienteBuscado.Nombre;
                lblApellidoBuscado.Text = clienteBuscado.Apellido;
                lblDniBuscado.Text = clienteBuscado.DNI;
                lblTelefonoBuscado.Text = clienteBuscado.Telefono;
                lblDireccionBuscado.Text = clienteBuscado.Direccion;
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
    }
}
