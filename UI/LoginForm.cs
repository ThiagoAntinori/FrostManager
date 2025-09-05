using Services.BLL.Services;
using Services.Domain.Security;
using Services.Domain.Logging;

namespace UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                //Usuario admin = new Usuario()
                //{
                //    IdUsuario = Guid.NewGuid(),
                //    CorreoElectronico = "admin@example.com",
                //    Nombre = "admin",
                //    Password = "1234"
                //};
                //UsuarioService.Current.Add(admin);
                //Usuario admin = UsuarioService.Current.GetByCorreoElectronico("admin@example.com");
                //Patente patenteRegistrarVenta = new Patente()
                //{
                //    IdComponente = Guid.NewGuid(),
                //    Nombre = "Registrar Venta",
                //    MenuItemName = "Nueva venta",
                //    FormName = "RegistrarVentaForm"
                //};
                //Patente patenteSeleccionarProducto = new Patente()
                //{
                //    IdComponente = Guid.NewGuid(),
                //    Nombre = "Seleccionar producto",
                //    MenuItemName = "Seleccionar producto",
                //    FormName = "SeleccionProductoForm"
                //};
                //PatenteService.Current.Add(patenteRegistrarVenta);
                //PatenteService.Current.Add(patenteSeleccionarProducto);
                //Familia familiaVentas = new Familia()
                //{
                //    IdComponente = Guid.NewGuid(),
                //    Nombre = "Ventas",
                //};
                //familiaVentas.Agregar(patenteRegistrarVenta);
                //familiaVentas.Agregar(patenteSeleccionarProducto);
                //FamiliaService.Current.Add(familiaVentas);
                //Patente patenteLogOut = new Patente
                //{
                //    IdComponente = Guid.NewGuid(),
                //    Nombre = "Log out",
                //    MenuItemName = "Cerrar sesión",
                //    FormName = "CerrarSesionForm"
                //};
                //PatenteService.Current.Add(patenteLogOut);
                //UsuarioService.Current.AddComponente(admin, familiaVentas);
                //UsuarioService.Current.AddComponente(admin, patenteLogOut);
                SesionService.Login(txtCorreo.Text, txtPassword.Text);
                LoggerService.WriteLog(new LogEntry(DateTime.Now, LogLevel.Debug, "Ocurrió un inicio de sesión."));
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
