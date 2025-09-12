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
        }

        public void CambiarIdioma()
        {
            try
            {
                
            }
            catch(Exception ex)
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
            try
            {
                if(UsuarioService.Current.GetByNombreUsuario("admin") == null)
                {
                    Usuario usuarioAdmin = new Usuario()
                    {
                        IdUsuario = Guid.NewGuid(),
                        Nombre = "admin",
                        CorreoElectronico = "admin@frostmanager.com",
                        EstaHabilitado = true,
                        Password = "1234"
                    };
                    UsuarioService.Current.Add(usuarioAdmin);
                    if(PatenteService.Current.SelectAll().Count == 0)
                    {
                        List<Patente> patentesBase = new List<Patente>();
                        patentesBase.Add(new Patente()
                        {
                            IdComponente = Guid.NewGuid(),
                            Nombre = "REGISTRAR_VENTA",
                            MenuItemName = "Registrar Venta",
                            FormName = "RegistrarVentaForm"
                        });
                        patentesBase.Add(new Patente()
                        {
                            IdComponente = Guid.NewGuid(),
                            Nombre = "REGISTRAR_CLIENTE",
                            MenuItemName = "Registrar Cliente",
                            FormName = "RegistrarClienteForm"
                        });
                        patentesBase.Add(new Patente()
                        {
                            IdComponente = Guid.NewGuid(),
                            Nombre = "MODIFICAR_CLIENTE",
                            MenuItemName = "Modificar Cliente",
                            FormName = "ModificarClienteForm"
                        });
                        Familia familiaVentas = new Familia()
                        {
                            IdComponente = Guid.NewGuid(),
                            Nombre = "VENTAS"
                        };
                        Familia familiaClientes = new Familia()
                        {
                            IdComponente = Guid.NewGuid(),
                            Nombre = "CLIENTES"
                        };
                        familiaVentas.Agregar(patentesBase[0]);
                        familiaClientes.Agregar(patentesBase[1]);
                        familiaClientes.Agregar(patentesBase[2]);
                        usuarioAdmin.Privilegios.Add(familiaVentas);
                        usuarioAdmin.Privilegios.Add(familiaClientes);
                        foreach(var patente in patentesBase)
                        {
                            PatenteService.Current.Add(patente);
                        }
                        FamiliaService.Current.Add(familiaVentas);
                        FamiliaService.Current.Add(familiaClientes);
                        UsuarioService.Current.AddComponente(usuarioAdmin, familiaClientes);
                        UsuarioService.Current.AddComponente(usuarioAdmin, familiaVentas);
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
