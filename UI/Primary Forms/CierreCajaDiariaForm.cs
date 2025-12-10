using BLL.DTOs;
using BLL.Implementations;
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

namespace UI.Primary_Forms
{
    public partial class CierreCajaDiariaForm : Form, ITraducible
    {
        DateTime fechaReporte;
        public CierreCajaDiariaForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = ReporteService.Current.GenerarReporteDeCajaDiaria(dtpFecha.Value);
                dgvReporte.Columns["NombreMedioPago"].HeaderText = "Medio de pago";
                dgvReporte.Columns["TotalRecaudado"].HeaderText = "Total Recaudado";
                dgvReporte.Columns["TotalRecaudado"].DefaultCellStyle.Format = "C";
                dgvReporte.Columns["CantidadDeVentas"].HeaderText = "Cantidad de ventas";
                fechaReporte = dtpFecha.Value;
                btnGenerarPDF.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CierreCajaDiariaForm_Load(object sender, EventArgs e)
        {
            try
            {
                btnGenerarPDF.Enabled = false;
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGenerarPDF_Click(object sender, EventArgs e)
        {
            try
            {
                List<ReporteCajaDTO> reporte = (List<ReporteCajaDTO>)dgvReporte.DataSource;
                Dictionary<string, string> mapeoNombres = new Dictionary<string, string>()
                {
                    {"NombreMedioPago", "Medio de pago" },
                    {"TotalRecaudado", "Total Recaudado" },
                    {"CantidadDeVentas", "Cantidad de ventas" }
                };
                List<string> propiedadesMoneda = new List<string>()
                {
                    "TotalRecaudado"
                };
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.Title = "Guardar Reporte PDF";
                    sfd.FileName = $"REPORTE_DE_CAJA_FM_({fechaReporte:dd-MM-yyyy}).pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string pathDescarga = sfd.FileName;
                        DocumentoService.DescargarPdf<ReporteCajaDTO>($"Reporte de Cierre de caja diaria del día {fechaReporte:d}",
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
