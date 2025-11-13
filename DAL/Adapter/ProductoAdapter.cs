using DAL.Contracts;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class ProductoAdapter : IAdapter<Producto>
    {

        private readonly static ProductoAdapter _instance = new ProductoAdapter();

        public static ProductoAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public Producto Adapt(object[] values)
        {
            try
            {
                return new Producto()
                {
                    IdProducto = Guid.Parse(values[0].ToString()),
                    Descripcion = values[1].ToString(),
                    CapacidadEnGramos = Convert.ToInt32(values[2].ToString()),
                    PrecioUnitario = Convert.ToDecimal(values[3].ToString()),
                    EnvaseNecesario = Repository.GetEnvaseInstance().GetById(Guid.Parse(values[4].ToString())),
                };
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
