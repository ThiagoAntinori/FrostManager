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
    public partial class ConsultarClienteForm : Form, ITraducible
    {
        public Cliente clienteBuscado = null;
        public ConsultarClienteForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
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
                        using (RegistrarClienteForm registrarClienteForm = new RegistrarClienteForm())
                        {
                            if (registrarClienteForm.ShowDialog() == DialogResult.OK)
                            {
                                clienteBuscado = registrarClienteForm.NuevoCliente;
                            }
                        }
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
            if (clienteBuscado != null)
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

        private void btnModificarDatos_Click(object sender, EventArgs e)
        {
            try
            {
                if (clienteBuscado == null)
                {
                    throw new Exception("Selecciona un usuario para modificar");
                }
                using (ModificarClienteForm modificarClienteForm = new ModificarClienteForm())
                {
                    modificarClienteForm.clienteAModificar = clienteBuscado;
                    if (modificarClienteForm.ShowDialog() == DialogResult.OK)
                    {
                        clienteBuscado = modificarClienteForm.clienteAModificar;
                        ActualizarLabels(clienteBuscado);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConsultarClienteForm_Load(object sender, EventArgs e)
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
