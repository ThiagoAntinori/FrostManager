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
using UI.Primary_Forms;

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

        private void CargarMenu()
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
                cargarMenuConfiguracion(msMenuPrincipal);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        private void cargarMenuConfiguracion(MenuStrip menu)
        {
            ToolStripMenuItem itemConfiguracion = new ToolStripMenuItem("Configuracion");
            itemConfiguracion.DropDownItems.AddRange([
                new ToolStripMenuItem("Cambiar Idioma", null, toolStripMenuItem_Click),
                new ToolStripMenuItem("Cerrar Sesion", null, toolStripMenuItem_Click)
                ]);
            menu.Items.Add(itemConfiguracion);
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if((sender as ToolStripMenuItem).Name == "Registrar Cliente")
                {
                    AltaClienteForm altaClienteForm = new AltaClienteForm();
                    altaClienteForm.ShowDialog();
                }
                if((sender as ToolStripMenuItem).Name == "Cerrar Sesión")
                {
                    if(MessageBox.Show("¿Desea cerrar sesión?", "FROSTMANAGER", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        UsuarioLogueado.CerrarSesion();
                        this.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
