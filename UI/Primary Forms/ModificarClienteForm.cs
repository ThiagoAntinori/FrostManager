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
    public partial class ModificarClienteForm : Form, ITraducible
    {
        public Cliente clienteAModificar;
        public ModificarClienteForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                clienteAModificar = ClienteService.Current.SelectByDNI(txtDni.Text);
                PoblarCampos(clienteAModificar);
                txtDni.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PoblarCampos(Cliente cliente)
        {
            try
            {
                txtNombre.Text = cliente.Nombre;
                txtApellido.Text = cliente.Apellido;
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
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
                MessageBox.Show("MODIFICADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ModificarClienteForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                if (clienteAModificar != null)
                {
                    PoblarCampos(clienteAModificar);
                }
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
