using Services.BLL.Extensions;
using Services.Domain.Logging;
using Services.Domain.Security;
using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public class DigitoVerificadorService
    {

        private readonly static DigitoVerificadorService _instance = new DigitoVerificadorService();

        public static DigitoVerificadorService Current
        {
            get
            {
                return _instance;
            }
        }

        private DigitoVerificadorService()
        {
            // Implement here the initialization of your singleton
        }

        public string CalcularDigitoVerificadorHorizontal(object obj)
        {
            try
            {
                if(obj == null)
                {
                    throw new Exception("No fue posible calcular el dígito verificador");
                }

                var propiedades = obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

                StringBuilder data = new StringBuilder();

                foreach(var prop in propiedades)
                {
                    if(prop.Name == "DVH")
                    {
                        continue;
                    }
                    if (!prop.CanRead)
                    {
                        continue;
                    }
                    object valor = prop.GetValue(obj);
                    if(valor != null)
                    {
                        data.Append(valor.ToString());
                    }
                }

                using(MD5 md5 = MD5.Create())
                {
                    byte[] bytes = md5.ComputeHash(Encoding.UTF8.GetBytes(data.ToString()));
                    return Convert.ToBase64String(bytes);
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public bool EsTablaConsistente<T>(IEnumerable<T> registros)
        {
            try
            {
                if(registros == null || !registros.Any())
                {
                    return true;
                }

                PropertyInfo propDVH = ObtenerPropiedadDVH<T>();
                if(propDVH == null)
                {
                    return true;
                }

                foreach (var entidad in registros)
                {
                    string dvhActual = propDVH.GetValue(entidad)?.ToString() ?? "";
                    string dvhCalculado = CalcularDigitoVerificadorHorizontal(entidad);

                    if (!string.Equals(dvhActual, dvhCalculado, StringComparison.Ordinal))
                        return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        private PropertyInfo ObtenerPropiedadDVH<T>()
        {
            var prop = typeof(T)
            .GetProperties()
            .FirstOrDefault(p => p.Name.Equals("DVH", StringComparison.OrdinalIgnoreCase));


            return prop;
        }

        public void HandleInconsistencia<T>()
        {
            try
            {
                string message = $"Se detectó una inconsistencia en los datos de la tabla '{typeof(T).Name}' en la base de datos. Recomendamos verificar los datos manualmente.";
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Warning, message));
                List<Usuario> usuariosAutorizados = UsuarioService.Current.GetByPatente("RECIBIR_ALERTAS_DATOS");
                foreach (var usuario in usuariosAutorizados.Where(u => !string.IsNullOrEmpty(u.CorreoElectronico)))
                {
                    EmailService.EnviarEmail(usuario.CorreoElectronico, "Alerta de Inconsistencia de datos - FrostManager", message);
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
