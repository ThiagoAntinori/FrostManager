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
    public partial class SeleccionarPatentesForm : Form, ITraducible
    {
        public List<Patente> patentesSeleccionadas = new List<Patente>();
        private Patente patenteToAdd;
        private Patente patenteToRemove;
        public SeleccionarPatentesForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void SeleccionarPatentesForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoPatentes(dgvPatentesDisponibles, PatenteService.Current.SelectAll());
                ActualizarListadoPatentes(dgvPatentesSeleccionadas, patentesSeleccionadas);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListadoPatentes(DataGridView dgv, List<Patente> patentes)
        {
            dgv.DataSource = null;
            dgv.DataSource = patentes;
            dgv.Columns["IdComponente"].Visible = false;
            dgv.Columns["MenuItemName"].Visible = false;
            dgv.Columns["FormName"].Visible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvPatentesDisponibles_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPatentesDisponibles.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvPatentesDisponibles.SelectedRows[0];

                    patenteToAdd = filaSeleccionada.DataBoundItem as Patente;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvPatentesSeleccionadas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvPatentesSeleccionadas.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvPatentesSeleccionadas.SelectedRows[0];

                    patenteToRemove = filaSeleccionada.DataBoundItem as Patente;
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
                if (patenteToAdd == null)
                {
                    throw new Exception("Selecciona una patente a añadir");
                }
                if (patentesSeleccionadas.Contains(patenteToAdd))
                {
                    throw new Exception("La patente a añadir ya fue seleccionada");
                }
                patentesSeleccionadas.Add(patenteToAdd);
                ActualizarListadoPatentes(dgvPatentesSeleccionadas, patentesSeleccionadas);
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
                if (patenteToRemove == null)
                {
                    throw new Exception("Selecciona una patente a eliminar");
                }
                patentesSeleccionadas.Remove(patenteToRemove);
                ActualizarListadoPatentes(dgvPatentesSeleccionadas, patentesSeleccionadas);
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
