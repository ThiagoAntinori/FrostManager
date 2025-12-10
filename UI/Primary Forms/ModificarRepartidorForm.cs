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
    public partial class ModificarRepartidorForm : Form, ITraducible
    {
        Repartidor repartidorSeleccionado;
        public ModificarRepartidorForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void ModificarRepartidorForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoRepartidores(RepartidorService.Current.SelectAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListadoRepartidores(IEnumerable<Repartidor> dataSource)
        {
            dgvRepartidores.DataSource = null;
            dgvRepartidores.DataSource = dataSource;
            dgvRepartidores.Columns["IdRepartidor"].Visible = false;
        }

        private void dgvRepartidores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRepartidores.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvRepartidores.SelectedRows[0];

                    Repartidor repartidorOriginal = filaSeleccionada.DataBoundItem as Repartidor;

                    repartidorSeleccionado = new Repartidor()
                    {
                        IdRepartidor = repartidorOriginal.IdRepartidor,
                        Nombre = repartidorOriginal.Nombre,
                        Apellido = repartidorOriginal.Apellido,
                        Email = repartidorOriginal.Email,
                        Activo = repartidorOriginal.Activo
                    };

                    if (repartidorSeleccionado != null)
                    {
                        txtNombre.Text = repartidorSeleccionado.Nombre;
                        txtApellido.Text = repartidorSeleccionado.Apellido;
                        txtEmail.Text = repartidorSeleccionado.Email;
                        lblEstadoValor.Text = repartidorSeleccionado.Activo ? "ACTIVO".Traducir() : "INACTIVO".Traducir();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            try
            {
                if (repartidorSeleccionado != null)
                {
                    repartidorSeleccionado.Activo = !repartidorSeleccionado.Activo;
                    lblEstadoValor.Text = repartidorSeleccionado.Activo ? "ACTIVO".Traducir() : "INACTIVO".Traducir();
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
                repartidorSeleccionado.Nombre = txtNombre.Text;
                repartidorSeleccionado.Apellido = txtApellido.Text;
                repartidorSeleccionado.Email = txtEmail.Text;
                RepartidorService.Current.Update(repartidorSeleccionado);
                MessageBox.Show("MODIFICADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                UIHelper.LimpiarCampos(this.Controls);
                ActualizarListadoRepartidores(RepartidorService.Current.SelectAll());
                repartidorSeleccionado = null;
                lblEstadoValor.Text = "-";
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
