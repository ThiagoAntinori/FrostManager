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
    public partial class ModificarClienteForm : Form
    {
        Cliente clienteAModificar = new Cliente();
        public ModificarClienteForm()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteAModificar = ClienteService.Current.SelectByDNI(txtDni.Text);
                txtNombre.Text = clienteAModificar.Nombre;
                txtApellido.Text = clienteAModificar.Apellido;
                txtTelefono.Text = clienteAModificar.Telefono;
                txtDireccion.Text = clienteAModificar.Direccion;
                txtDni.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteAModificar.Nombre = txtNombre.Text;
                clienteAModificar.Apellido = txtApellido.Text;
                clienteAModificar.Telefono = txtTelefono.Text;
                clienteAModificar.Direccion = txtDireccion.Text;
                ClienteService.Current.Update(clienteAModificar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
