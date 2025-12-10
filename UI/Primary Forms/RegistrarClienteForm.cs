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
    public partial class RegistrarClienteForm : Form, ITraducible
    {
        public Cliente NuevoCliente;
        public RegistrarClienteForm()
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
                throw ex;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaClienteForm_Load(object sender, EventArgs e)
        {
            if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
            {
                CambiarIdioma();
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente clienteARegistrar = new Cliente
                {
                    IdCliente = Guid.NewGuid(),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    DNI = txtDni.Text,
                    Telefono = txtTelefono.Text,
                    Direccion = txtDireccion.Text
                };
                ClienteService.Current.Add(clienteARegistrar);
                MessageBox.Show("REGISTRADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                NuevoCliente = clienteARegistrar;
                UIHelper.LimpiarCampos(this.Controls);
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
