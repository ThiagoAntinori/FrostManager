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
    public partial class VerDetallesBitacoraForm : Form, ITraducible
    {
        public LogEntry logSeleccionado;
        public VerDetallesBitacoraForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void VerDetallesBitacoraForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                if (logSeleccionado == null)
                {
                    throw new Exception("No fue posible mostrar los detalles");
                }
                rtxtDetalle.Text = FormatearLog(logSeleccionado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string FormatearLog(LogEntry logEntry)
        {
            StringBuilder detalle = new StringBuilder();

            detalle.AppendLine("--- DETALLES DE ENTRADA DE BITÁCORA ---");
            detalle.AppendLine($"Fecha y hora: {logEntry.Timestamp:F}");
            detalle.AppendLine($"Nivel: {logEntry.Level.ToString().ToUpper()}");
            detalle.AppendLine($"Mensaje: {logEntry.Message}");

            if (logEntry.Usuario != null)
            {
                detalle.AppendLine("--- USUARIO RESPONSABLE ---");
                detalle.AppendLine($"ID: {logEntry.Usuario.IdUsuario}");
                detalle.AppendLine($"Nombre: {logEntry.Usuario.Nombre}");
            }
            else
            {
                detalle.AppendLine("--- USUARIO RESPONSABLE: NO LOGUEADO/SISTEMA ---");
            }

            if (logEntry.Exception != null)
            {
                detalle.AppendLine("--- DETALLES DE EXCEPCIÓN ---");
                detalle.AppendLine($"Tipo de Excepción: {logEntry.Exception.GetType().FullName}");
                detalle.AppendLine($"Mensaje: {logEntry.Exception.Message}");
                detalle.AppendLine($"StackTrace: {logEntry.Exception.StackTrace}");
            }

            return detalle.ToString();
        }

        private void btnCopiarPortapapeles_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(rtxtDetalle.Text);
            MessageBox.Show("Texto copiado al portapapeles");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            this.Close();
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
