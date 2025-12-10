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
    public partial class EliminarFamiliaForm : Form, ITraducible
    {
        public EliminarFamiliaForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        Familia familiaSeleccionada;
        List<Familia> familiasHijas = new List<Familia>();
        List<Patente> patentesHijas = new List<Patente>();

        private void EliminarFamiliaForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoFamilias(dgvFamilias, FamiliaService.Current.SelectAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListadoFamilias(DataGridView dgv, List<Familia> familias)
        {
            dgv.DataSource = null;
            dgv.DataSource = familias;
            dgv.Columns["IdComponente"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvFamilias_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFamilias.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvFamilias.SelectedRows[0];

                    familiaSeleccionada = filaSeleccionada.DataBoundItem as Familia;

                    if (familiaSeleccionada != null)
                    {
                        lblFamiliaSeleccionadaNombre.Text = familiaSeleccionada.Nombre;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                FamiliaService.Current.Delete(familiaSeleccionada);
                MessageBox.Show("ELIMINADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListadoFamilias(dgvFamilias, FamiliaService.Current.SelectAll());
                familiaSeleccionada = null;
                lblFamiliaSeleccionadaNombre.Text = "-";
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
