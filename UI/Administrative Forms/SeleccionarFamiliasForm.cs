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

namespace UI.Administrative_Forms
{
    public partial class SeleccionarFamiliasForm : Form, ITraducible
    {
        public List<Familia> familiasSeleccionadas = new List<Familia>();
        private Familia familiaToAdd;
        private Familia familiaToRemove;
        public SeleccionarFamiliasForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void SeleccionarFamiliasForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoFamilias(dgvFamiliasDisponibles, FamiliaService.Current.SelectAll());
                ActualizarListadoFamilias(dgvFamiliasSeleccionadas, familiasSeleccionadas);
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

        private void dgvFamiliasDisponibles_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFamiliasDisponibles.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvFamiliasDisponibles.SelectedRows[0];

                    familiaToAdd = filaSeleccionada.DataBoundItem as Familia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFamiliasSeleccionadas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvFamiliasSeleccionadas.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvFamiliasSeleccionadas.SelectedRows[0];

                    familiaToRemove = filaSeleccionada.DataBoundItem as Familia;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (familiaToAdd == null)
                {
                    throw new Exception("Selecciona una familia a añadir");
                }
                if (familiasSeleccionadas.Contains(familiaToAdd))
                {
                    throw new Exception("La familia a añadir ya fue seleccionada");
                }
                familiasSeleccionadas.Add(familiaToAdd);
                ActualizarListadoFamilias(dgvFamiliasSeleccionadas, familiasSeleccionadas);
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
                if (familiaToRemove == null)
                {
                    throw new Exception("Selecciona una familia a eliminar");
                }
                familiasSeleccionadas.Remove(familiaToRemove);
                ActualizarListadoFamilias(dgvFamiliasSeleccionadas, familiasSeleccionadas);
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
                this.DialogResult = DialogResult.OK;
                this.Close();
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
