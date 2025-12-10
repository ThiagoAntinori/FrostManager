using Domain;
using Services.BLL.Contracts;
using Services.BLL.Services;
using Services.Domain.Logging;
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
    public partial class VerBitacoraForm : Form, ITraducible
    {
        LogEntry logSeleccionado;
        public VerBitacoraForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void VerBitacoraForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                CargarComboNiveles();
                ActualizarListadoLogs(LoggerService.GetLogger().GetLogs().OrderByDescending(l => l.Timestamp).ToList());
                btnVerDetalles.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ActualizarListadoLogs(List<LogEntry> source)
        {
            dgvBitacora.DataSource = null;
            dgvBitacora.DataSource = source;
        }

        private void CargarComboNiveles()
        {
            cmbFiltroNivel.DataSource = null;
            cmbFiltroNivel.DataSource = Enum.GetValues(typeof(LogLevel)).Cast<LogLevel>().ToList();
            cmbFiltroNivel.SelectedIndex = -1;
        }

        private void dgvBitacora_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvBitacora.SelectedRows.Count > 0)
                {
                    var filaSeleccionada = dgvBitacora.SelectedRows[0];

                    logSeleccionado = filaSeleccionada.DataBoundItem as LogEntry;

                    if(logSeleccionado != null)
                    {
                        btnVerDetalles.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbFiltroNivel_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if(cmbFiltroNivel.SelectedIndex < 0)
                {
                    ActualizarListadoLogs(LoggerService.GetLogger().GetLogs().OrderByDescending(l => l.Timestamp).ToList());
                }
                if (cmbFiltroNivel.SelectedValue != null)
                {
                    List<LogEntry> logsPorNivel = LoggerService.GetLogger().GetLogs()
                        .Where(l => l.Level == (LogLevel)cmbFiltroNivel.SelectedValue)
                        .OrderByDescending(l => l.Timestamp)
                        .ToList();
                    ActualizarListadoLogs(logsPorNivel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerDetalles_Click_1(object sender, EventArgs e)
        {
            try
            {
                using(VerDetallesBitacoraForm verDetallesForm = new VerDetallesBitacoraForm())
                {
                    verDetallesForm.logSeleccionado = logSeleccionado;
                    verDetallesForm.ShowDialog();
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
