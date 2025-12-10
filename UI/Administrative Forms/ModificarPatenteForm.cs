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

namespace UI.Administrative_Forms
{
    public partial class ModificarPatenteForm : Form, ITraducible
    {
        Patente patenteSeleccionada;
        public ModificarPatenteForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void ModificarPatenteForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoPatentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListadoPatentes()
        {
            dgvPatentes.DataSource = null;
            dgvPatentes.DataSource = PatenteService.Current.SelectAll();
            dgvPatentes.Columns["IdComponente"].Visible = false;
            dgvPatentes.Columns["MenuItemName"].HeaderText = "Nombre de menú";
            dgvPatentes.Columns["FormName"].HeaderText = "Nombre de formulario";
        }

        private void dgvPatentes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPatentes.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvPatentes.SelectedRows[0];

                    patenteSeleccionada = filaSeleccionada.DataBoundItem as Patente;

                    if (patenteSeleccionada != null)
                    {
                        txtDescripcion.Text = patenteSeleccionada.Nombre;
                        txtFormName.Text = patenteSeleccionada.FormName;
                        txtMenuItemName.Text = patenteSeleccionada.MenuItemName;
                    }
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
                patenteSeleccionada.Nombre = txtDescripcion.Text;
                patenteSeleccionada.FormName = txtFormName.Text;
                patenteSeleccionada.MenuItemName = txtMenuItemName.Text;
                PatenteService.Current.Update(patenteSeleccionada);
                MessageBox.Show("MODIFICADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListadoPatentes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MainAdministrativeForm.CloseChildForm(this);
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
