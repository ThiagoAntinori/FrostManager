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
    public partial class ModificarFamiliaForm : Form, ITraducible
    {
        Familia familiaSeleccionada;
        List<Familia> familiasHijas = new List<Familia>();
        List<Patente> patentesHijas = new List<Patente>();
        public ModificarFamiliaForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void ModificarFamiliaForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                ActualizarListadoFamilias(dgvFamilias, FamiliaService.Current.SelectAll());
                btnSeleccionarFamilias.Enabled = false;
                btnSeleccionarPatentes.Enabled = false;
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
                        txtDescripcionFamilia.Text = familiaSeleccionada.Nombre;
                        btnSeleccionarPatentes.Enabled = true;
                        btnSeleccionarFamilias.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionarPatentes_Click(object sender, EventArgs e)
        {
            try
            {
                using (SeleccionarPatentesForm seleccionarPatentes = new SeleccionarPatentesForm())
                {
                    seleccionarPatentes.patentesSeleccionadas = familiaSeleccionada.GetChildren().OfType<Patente>().ToList();
                    if (seleccionarPatentes.ShowDialog() == DialogResult.OK)
                    {
                        patentesHijas = seleccionarPatentes.patentesSeleccionadas;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        private void btnSeleccionarFamilias_Click(object sender, EventArgs e)
        {
            try
            {
                using (SeleccionarFamiliasForm seleccionarFamilias = new SeleccionarFamiliasForm())
                {
                    seleccionarFamilias.familiasSeleccionadas = familiaSeleccionada.GetChildren().OfType<Familia>().ToList();
                    if (seleccionarFamilias.ShowDialog() == DialogResult.OK)
                    {
                        familiasHijas = seleccionarFamilias.familiasSeleccionadas;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                familiaSeleccionada.Nombre = txtDescripcionFamilia.Text;
                familiaSeleccionada.children = patentesHijas.Concat<Componente>(familiasHijas).Cast<Componente>().ToList();
                FamiliaService.Current.Update(familiaSeleccionada);
                MessageBox.Show("MODIFICADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarListadoFamilias(dgvFamilias, FamiliaService.Current.SelectAll());
                familiaSeleccionada = null;
                txtDescripcionFamilia.Text = string.Empty;
                btnSeleccionarPatentes.Enabled = false;
                btnSeleccionarFamilias.Enabled = false;
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
