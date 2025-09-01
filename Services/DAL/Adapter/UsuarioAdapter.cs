using Services.DAL.Contracts;
using Services.DAL.Implementations;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Adapter
{
    public sealed class UsuarioAdapter : IAdapter<Usuario>
    {

        private readonly static UsuarioAdapter _instance = new UsuarioAdapter();

        public static UsuarioAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Usuario Adapt(object[] values)
        {
            Usuario usuario = new Usuario()
            {
                IdUsuario = Guid.Parse(values[0].ToString()),
                CorreoElectronico = values[1].ToString(),
                Nombre = values[2].ToString(),
                Password = values[3].ToString(),
                EstaHabilitado = bool.Parse(values[4].ToString())
            };

            UsuarioComponenteRepository.Current.GetComponentes(usuario);

            return usuario;
        }
    }
}
