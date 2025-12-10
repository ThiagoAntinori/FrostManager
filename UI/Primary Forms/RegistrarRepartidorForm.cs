using BLL.Implementations;
using Domain;
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
    public partial class RegistrarRepartidorForm : Form, ITraducible
    {
        public RegistrarRepartidorForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Repartidor nuevoRepartidor = new Repartidor()
                {
                    IdRepartidor = Guid.NewGuid(),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Activo = true
                };
                RepartidorService.Current.Add(nuevoRepartidor);
                MessageBox.Show("REGISTRADO_OK".Traducir(), "Operación Exitosa".Traducir(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                UIHelper.LimpiarCampos(this.Controls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrarRepartidorForm_Load(object sender, EventArgs e)
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
    }
}
