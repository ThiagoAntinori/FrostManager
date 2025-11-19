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
    public partial class SeleccionarRepartidorForm : Form
    {
        public Repartidor repartidorSeleccionado;
        public SeleccionarRepartidorForm()
        {
            InitializeComponent();
        }

        private void SeleccionarRepartidorForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvRepartidores.DataSource = null;
                dgvRepartidores.DataSource = RepartidorService.Current.SelectAll();
                dgvRepartidores.Columns["IdRepartidor"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvRepartidores_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvRepartidores.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvRepartidores.SelectedRows[0];

                    repartidorSeleccionado = filaSeleccionada.DataBoundItem as Repartidor;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
