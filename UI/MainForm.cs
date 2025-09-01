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

namespace UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                CargarMenu();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarMenu()
        {
            try
            {
                if (UsuarioLogueado.Current.Usuario == null)
                {
                    throw new Exception("Error al mostrar permisos. Contacte al admistrador.");
                }
                List<Patente> patentesUsuario = UsuarioLogueado.Current.Usuario.GetAllPatentes();
                if (patentesUsuario.Count == 0)
                {
                    throw new Exception("No se le asignó ningún permiso. Contacte al administrador.");
                }
                foreach (var patente in patentesUsuario)
                {
                    ToolStripMenuItem item = new ToolStripMenuItem(patente.MenuItemName);
                    msMenuPrincipal.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
