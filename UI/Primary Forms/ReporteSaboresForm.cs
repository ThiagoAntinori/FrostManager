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
    public partial class ReporteSaboresForm : Form, ITraducible
    {
        DateTime fechaDesde;
        DateTime fechaHasta;
        public ReporteSaboresForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                dgvReporte.DataSource = null;
                dgvReporte.DataSource = ReporteService.Current.GenerarReporteDeSaboresMasVendidos(dtpFechaDesde.Value, dtpFechaHasta.Value);
                dgvReporte.Columns["NombreSabor"].HeaderText = "Sabor";
                dgvReporte.Columns["CantidadDeVecesVendido"].HeaderText = "Cantidad de veces vendido";
                dgvReporte.Columns["CantidadVendidaEnGramos"].HeaderText = "Cantidad vendida en gramos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ReporteSaboresForm_Load(object sender, EventArgs e)
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
                List<ReporteSaboresDTO> reporte = (List<ReporteSaboresDTO>)dgvReporte.DataSource;
                Dictionary<string, string> mapeoNombres = new Dictionary<string, string>()
                {
                    {"NombreSabor", "Sabor" },
                    {"CantidadDeVecesVendido", "Cantidad de veces vendido" },
                    {"CantidadVendidaEnGramos", "Cantidad vendida en gramos" }
                };
                List<string> propiedadesMoneda = new List<string>();
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "PDF Files (*.pdf)|*.pdf";
                    sfd.Title = "Guardar Reporte PDF";
                    sfd.FileName = $"REPORTE_SABORES_FM_Desde_{fechaDesde:dd-MM-yyyy}_Hasta_{fechaHasta:dd-MM-yyyy}.pdf";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        string pathDescarga = sfd.FileName;
                        DocumentoService.DescargarPdf<ReporteSaboresDTO>($"Reporte Sabores entre {fechaDesde:d} y {fechaHasta:d}",
                            reporte, pathDescarga, mapeoNombres, propiedadesMoneda);
                        MessageBox.Show("PDF generado correctamente");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
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
