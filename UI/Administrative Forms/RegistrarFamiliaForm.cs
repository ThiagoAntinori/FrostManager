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
    public partial class RegistrarFamiliaForm : Form, ITraducible
    {
        private List<Componente> componentesSeleccionados = new List<Componente>();
        public RegistrarFamiliaForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnSeleccionarPatentes_Click(object sender, EventArgs e)
        {
            try
            {
                using (SeleccionarPatentesForm seleccionarPatentes = new SeleccionarPatentesForm())
                {
                    if (seleccionarPatentes.ShowDialog() == DialogResult.OK)
                    {
                        componentesSeleccionados.AddRange(seleccionarPatentes.patentesSeleccionadas);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionarFamilias_Click(object sender, EventArgs e)
        {
            try
            {
                using (SeleccionarFamiliasForm seleccionarFamilias = new SeleccionarFamiliasForm())
                {
                    if (seleccionarFamilias.ShowDialog() == DialogResult.OK)
                    {
                        componentesSeleccionados.AddRange(seleccionarFamilias.familiasSeleccionadas);
                    }
                }
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
                Familia nuevaFamilia = new Familia()
                {
                    IdComponente = Guid.NewGuid(),
                    Nombre = txtDescripcionFamilia.Text,
                    children = componentesSeleccionados
                };
                FamiliaService.Current.Add(nuevaFamilia);
                MessageBox.Show("REGISTRADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                UIHelper.LimpiarCampos(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrarFamiliaForm_Load(object sender, EventArgs e)
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
