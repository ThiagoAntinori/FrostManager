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
    public partial class ReporteVentasForm : Form, ITraducible
    {
        DateTime fechaDesde;
        DateTime fechaHasta;
        public ReporteVentasForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnGenerarReporte_Click_1(object sender, EventArgs e)
        {
            try
            {
                var reporteVentas = ReporteService.Current.GenerarReporteVentas(dtpFechaDesde.Value, dtpFechaHasta.Value);
                fechaDesde = dtpFechaDesde.Value;
                fechaHasta = dtpFechaHasta.Value;
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = reporteVentas.Detalles;
                dgvReporte.Columns["Total"].DefaultCellStyle.Format = "C";
                dgvReporte.Columns["MedioPago"].HeaderText = "Medio de Pago";
                lblTotalRecaudadoValor.Text = reporteVentas.TotalRecaudado.ToString("C");
                lblPromedioDiarioValor.Text = reporteVentas.PromedioDiario.ToString("C");
                btnGenerarPDF.Enabled = true;
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
                List<ReporteVentasDTO> reporte = (List<ReporteVentasDTO>)dgvReporte.DataSource;
                Dictionary<string, string> mapeoNombres = new Dictionary<string, string>()
                {
                    {"MedioPago", "Medio de pago" }
                };
                List<string> propiedadesMoneda = new List<string>()
                {
                    "Total"
                };
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.Title = "Guardar Reporte PDF";
                    sfd.FileName = $"REPORTE_VENTAS_FM_Desde_{fechaDesde:dd-MM-yyyy}_Hasta_{fechaHasta:dd-MM-yyyy}.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string pathDescarga = sfd.FileName;
                        DocumentoService.DescargarPdf<ReporteVentasDTO>($"Reporte Ventas entre {fechaDesde:d} y {fechaHasta:d}",
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

        private void ReporteVentasForm_Load(object sender, EventArgs e)
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

