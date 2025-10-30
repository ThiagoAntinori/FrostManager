using Services.BLL.Services;
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

namespace UI.Administrative_Forms
{
    public partial class RespaldoForm : Form
    {
        public RespaldoForm()
        {
            InitializeComponent();
        }

        private void btnRespaldar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Backup files (*.bak) | *.bak";
                    saveFileDialog.Title = "Guardar respaldo de Base de datos";
                    saveFileDialog.InitialDirectory = @"C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\Backup";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        BackupService.Current.HacerBackup(saveFileDialog.FileName,
                            ConfigurationManager.ConnectionStrings["BusinessConString"].ConnectionString);
                        MessageBox.Show("La base de datos fue respaldada con éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
