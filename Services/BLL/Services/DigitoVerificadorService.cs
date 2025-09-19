using Services.BLL.Extensions;
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
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

    }
}
