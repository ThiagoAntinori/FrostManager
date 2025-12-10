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

namespace UI.Administrative_Forms
{
    public partial class RegistrarUsuarioForm : Form, ITraducible
    {
        List<Patente> patentesUsuario;
        List<Familia> familiasUsuario;
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        public void CambiarIdioma()
        {
            UIHelper.TraducirControles(this.Controls);
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
                string passwordAleatoria = UsuarioService.Current.GenerarPassword();
                Usuario nuevoUsuario = new Usuario()
                {
                    IdUsuario = Guid.NewGuid(),
                    Nombre = txtNombreUsuario.Text,
                    CorreoElectronico = txtCorreoElectronico.Text,
                    EstaHabilitado = true,
                    Password = passwordAleatoria
                };
                UsuarioService.Current.Add(nuevoUsuario);
                if(familiasUsuario != null && familiasUsuario.Any())
                {
                    UsuarioService.Current.AddComponentes(nuevoUsuario, familiasUsuario.Cast<Componente>().ToList());
                }
                if(patentesUsuario != null || patentesUsuario.Count > 0)
                {
                    UsuarioService.Current.AddComponentes(nuevoUsuario, patentesUsuario.Cast<Componente>().ToList());
                }
                string asunto = $"¡Bienvenido a FrostManager!";
                string cuerpo = $"Bienvenido, {nuevoUsuario.Nombre}! Se generó un usuario con tu correo electrónico. Se te asignó la siguiente contraseña aleatoriamente. Puedes cambiarla al ingresar al sistema por primera vez." +
                    $"\nTu nombre de usuario es: {nuevoUsuario.Nombre}" +
                    $"\nTu contraseña es: {passwordAleatoria}";
                EmailService.EnviarEmail(nuevoUsuario.CorreoElectronico, asunto, cuerpo);
                MessageBox.Show($"Se creó el usuario correctamente. La contraseña fue enviada por correo electrónico al usuario a la dirección ingresada: {nuevoUsuario.CorreoElectronico}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionarPatentes_Click(object sender, EventArgs e)
        {
            try
            {
                using (SeleccionarPatentesForm seleccionarPatentesForm = new SeleccionarPatentesForm())
                {
                    if (seleccionarPatentesForm.ShowDialog() == DialogResult.OK)
                    {
                        patentesUsuario = seleccionarPatentesForm.patentesSeleccionadas;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSeleccionarFamilias_Click(object sender, EventArgs e)
        {
            try
            {
                using(SeleccionarFamiliasForm seleccionarFamiliasForm = new SeleccionarFamiliasForm())
                {
                    if(seleccionarFamiliasForm.ShowDialog() == DialogResult.OK)
                    {
                        familiasUsuario = seleccionarFamiliasForm.familiasSeleccionadas;
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
