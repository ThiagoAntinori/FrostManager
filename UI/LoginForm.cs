using Services.BLL.Services;
using Services.Domain.Security;
using Services.Domain.Logging;
using Services.BLL.Contracts;

namespace UI
{
    public partial class LoginForm : Form, ITraducible
    {
        public LoginForm()
        {
            InitializeComponent();
            IdiomaService.Current.Suscribir(this);
        }

        public void CambiarIdioma()
        {
            try
            {
                TraducirControles(this.Controls);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                SesionService.Login(txtNombreUsuario.Text, txtPassword.Text);
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    if(UsuarioService.Current.GetByNombreUsuario("admin") == null)
            //    {
            //        Usuario usuarioAdmin = new Usuario()
            //        {
            //            IdUsuario = Guid.NewGuid(),
            //            Nombre = "admin",
            //            CorreoElectronico = "admin@frostmanager.com",
            //            EstaHabilitado = true,
            //            Password = "1234"
            //        };
            //        UsuarioService.Current.Add(usuarioAdmin);
            //        if(PatenteService.Current.SelectAll().Count == 0)
            //        {
            //            List<Patente> patentesBase = new List<Patente>();
            //            patentesBase.Add(new Patente()
            //            {
            //                IdComponente = Guid.NewGuid(),
            //                Nombre = "REGISTRAR_VENTA",
            //                MenuItemName = "Registrar Venta",
            //                FormName = "RegistrarVentaForm"
            //            });
            //            patentesBase.Add(new Patente()
            //            {
            //                IdComponente = Guid.NewGuid(),
            //                Nombre = "REGISTRAR_CLIENTE",
            //                MenuItemName = "Registrar Cliente",
            //                FormName = "RegistrarClienteForm"
            //            });
            //            patentesBase.Add(new Patente()
            //            {
            //                IdComponente = Guid.NewGuid(),
            //                Nombre = "MODIFICAR_CLIENTE",
            //                MenuItemName = "Modificar Cliente",
            //                FormName = "ModificarClienteForm"
            //            });
            //            Familia familiaVentas = new Familia()
            //            {
            //                IdComponente = Guid.NewGuid(),
            //                Nombre = "VENTAS"
            //            };
            //            Familia familiaClientes = new Familia()
            //            {
            //                IdComponente = Guid.NewGuid(),
            //                Nombre = "CLIENTES"
            //            };
            //            familiaVentas.Agregar(patentesBase[0]);
            //            familiaClientes.Agregar(patentesBase[1]);
            //            familiaClientes.Agregar(patentesBase[2]);
            //            usuarioAdmin.Privilegios.Add(familiaVentas);
            //            usuarioAdmin.Privilegios.Add(familiaClientes);
            //            foreach(var patente in patentesBase)
            //            {
            //                PatenteService.Current.Add(patente);
            //            }
            //            FamiliaService.Current.Add(familiaVentas);
            //            FamiliaService.Current.Add(familiaClientes);
            //            UsuarioService.Current.AddComponente(usuarioAdmin, familiaClientes);
            //            UsuarioService.Current.AddComponente(usuarioAdmin, familiaVentas);
            //        }
            //    }

            //}
            try
            {
                Usuario prueba = new Usuario()
                {
                    Nombre = "PruebaMail",
                    CorreoElectronico = "thiagoantinori02@gmail.com",
                    EstaHabilitado = true,
                    IdUsuario = Guid.NewGuid(),
                    Password = CriptographyService.HashMd5("1234")
                };
                UsuarioService.Current.Add(prueba);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TraducirControles(Control.ControlCollection controles)
        {
            try
            {
                foreach (Control ctrl in controles)
                {
                    if (ctrl.Name != null)
                    {
                        if (ctrl.Visible == true)
                        {
                            if (ctrl is Button || ctrl is Label)
                            {
                                ctrl.Text = IdiomaService.Current.Traducir(ctrl.Name);
                            }
                        }
                    }
                    if (ctrl.HasChildren)
                    {
                        TraducirControles(ctrl.Controls);
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void linkOlvideContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                RecuperarContraseñaForm recuperarContraseñaForm = new RecuperarContraseñaForm();
                recuperarContraseñaForm.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
