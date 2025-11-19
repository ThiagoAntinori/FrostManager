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
    public partial class CobrarForm : Form
    {
        public MedioPago medioPagoSeleccionado;
        public CobrarForm()
        {
            InitializeComponent();
        }

        private void CobrarForm_Load(object sender, EventArgs e)
        {
            try
            {
                cmbMedioPago.DataSource = null;
                cmbMedioPago.DataSource = Enum.GetValues(typeof(MedioPago)).Cast<MedioPago>().ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                medioPagoSeleccionado = (MedioPago)cmbMedioPago.SelectedItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
