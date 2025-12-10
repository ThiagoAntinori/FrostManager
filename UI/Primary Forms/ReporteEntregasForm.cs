using BLL.DTOs;
using BLL.Implementations;
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

namespace UI.Primary_Forms
{
    public partial class ReporteEntregasForm : Form, ITraducible
    {
        DateTime fechaDesde;
        DateTime fechaHasta;
        public ReporteEntregasForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = ReporteService.Current.GenerarReporteDeEntregas(dtpFechaDesde.Value, dtpFechaHasta.Value);
                dgvReporte.Columns["FechaPedido"].HeaderText = "Fecha";
                dgvReporte.Columns["NombreCliente"].HeaderText = "Nombre Cliente";
                dgvReporte.Columns["NombreRepartidor"].HeaderText = "Nombre Repartidor";
                dgvReporte.Columns["TiempoEntrega"].HeaderText = "Tiempo de entrega";
                dgvReporte.Columns["MontoTotal"].HeaderText = "Monto total";
                dgvReporte.Columns["MontoTotal"].DefaultCellStyle.Format = "C";
                fechaDesde = dtpFechaDesde.Value;
                fechaHasta = dtpFechaHasta.Value;
                btnGenerarPDF.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReporteEntregasForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                btnGenerarPDF.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                List<ReportePedidosDTO> reporte = (List<ReportePedidosDTO>)dgvReporte.DataSource;
                Dictionary<string, string> mapeoNombres = new Dictionary<string, string>()
                {
                    {"FechaPedido", "Fecha" },
                    {"NombreCliente", "Nombre Cliente" },
                    {"NombreRepartidor", "Nombre Repartidor" },
                    {"TiempoEntrega", "Tiempo de entrega" },
                    {"MontoTotal", "Monto total" }
                };
                List<string> propiedadesMoneda = new List<string>()
                {
                    "MontoTotal"
                };
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.Title = "Guardar Reporte PDF";
                    sfd.FileName = $"REPORTE_ENTREGAS_FM_Desde_({fechaDesde:dd-MM-yyyy})_Hasta_({fechaHasta:dd-MM-yyyy}).pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string pathDescarga = sfd.FileName;
                        DocumentoService.DescargarPdf<ReportePedidosDTO>($"Reporte Entregas entre {fechaDesde:d} y {fechaHasta:d}",
                            reporte, pathDescarga, mapeoNombres, propiedadesMoneda);
                        MessageBox.Show("PDF generado correctamente");
                    }
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
