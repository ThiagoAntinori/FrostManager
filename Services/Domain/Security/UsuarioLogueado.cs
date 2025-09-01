using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security
{
    public class UsuarioLogueado
    {
        public Usuario Usuario { get; private set; }
        private static UsuarioLogueado _instance;
        private static readonly object _lock = new object();

        public static UsuarioLogueado Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioLogueado(Usuario usuario)
        {
            this.Usuario = usuario;
        }

        public static void IniciarSesion(Usuario usuario)
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new UsuarioLogueado(usuario);
                else
                    throw new InvalidOperationException("Ya hay una sesión iniciada. Ciérrela para ingresar un nuevo usuario");
            }
        }

        public static void CerrarSesion()
        {
            lock (_lock)
            {
                _instance = null;
            }
        }

    }
}
