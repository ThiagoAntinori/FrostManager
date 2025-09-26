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

namespace UI.Administrative_Forms
{
    public partial class RegistrarUsuarioForm : Form, ITraducible
    {
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
        }

        public void CambiarIdioma()
        {
            MainForm.TraducirControles(this.Controls);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm.closeChildForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RegistrarUsuarioForm_Load(object sender, EventArgs e)
        {
            try
            {
                if (UsuarioLogueado.Current.IdiomaSeleccionado != "es-ES")
                {
                    CambiarIdioma();
                }
                cmbRol.DataSource = FamiliaService.Current.SelectAll();
                cmbRol.DisplayMember = "Nombre".Replace('_', ' ');
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario nuevoUsuario = new Usuario()
                {
                    IdUsuario = Guid.NewGuid(),
                    Nombre = txtNombreUsuario.Text,
                    CorreoElectronico = txtCorreoElectronico.Text,
                    EstaHabilitado = true,
                    Password = UsuarioService.Current.GenerarPassword()
                };
                UsuarioService.Current.Add(nuevoUsuario);
                UsuarioService.Current.AddComponente(nuevoUsuario, (Familia)cmbRol.SelectedValue);
                string asunto = $"¡Bienvenido a FrostManager!";
                string cuerpo = $"Bienvenido, {nuevoUsuario.Nombre}! Se generó un usuario con tu correo electrónico. Se te asignó la siguiente contraseña aleatoriamente. Puedes cambiarla al ingresar al sistema por primera vez." +
                    $"\nTu nombre de usuario es: {nuevoUsuario.Nombre}" +
                    $"\nTu contraseña es: {nuevoUsuario.Password}";
                EmailService.EnviarEmail(nuevoUsuario.CorreoElectronico, asunto, cuerpo);
                MessageBox.Show($"Se creó el usuario correctamente. La contraseña fue enviada por correo electrónico al usuario a la dirección ingresada: {nuevoUsuario.CorreoElectronico}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
