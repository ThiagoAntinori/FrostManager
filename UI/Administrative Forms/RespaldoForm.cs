using Services.BLL.Contracts;
using Services.BLL.Services;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Tools;

namespace UI.Administrative_Forms
{
    public partial class RespaldoForm : Form, ITraducible
    {
        string connectionStringSeleccionada;
        public RespaldoForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Archivos de Backup (*.bak) | *.bak";
                    saveFileDialog.Title = "Guardar respaldo de Base de datos";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        BackupService.Current.RespaldarBaseDeDatos(saveFileDialog.FileName, connectionStringSeleccionada);
                        MessageBox.Show("La base de datos fue respaldada con éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RespaldoForm_Load(object sender, EventArgs e)
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    dialog.Filter = "Archivos de Backup (*.bak)|*.bak";
                    dialog.Title = "Seleccionar archivo de backup";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string path = dialog.FileName;

                        BackupService.Current.RestaurarBaseDeDatos(path, connectionStringSeleccionada);

                        MessageBox.Show("La restauración se completó correctamente.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbtnNegocio_CheckedChanged(object sender, EventArgs e)
        {
            connectionStringSeleccionada = rbtnNegocio.Checked ?
                ConfigurationManager.ConnectionStrings["BusinessConString"].ConnectionString :
                ConfigurationManager.ConnectionStrings["ServicesConString"].ConnectionString;
        }

        private void rbtnSeguridad_CheckedChanged(object sender, EventArgs e)
        {
            connectionStringSeleccionada = rbtnNegocio.Checked ?
                ConfigurationManager.ConnectionStrings["ServicesConString"].ConnectionString :
                ConfigurationManager.ConnectionStrings["BusinessConString"].ConnectionString;
        }
    }
}
