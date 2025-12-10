using DAL.Contracts;
using DAL.Implementations.SqlServer;
using DAL.Tools;
using Services.BLL.Extensions;
using Services.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.Factory
{
    public static class Repository
    {
        static string backendType = ConfigurationManager.AppSettings["backendType"];

        public static IClienteRepository GetClienteInstance()
        {
            if(backendType == "sqlserver")
            {
                return new ClienteSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IDetalleVentaRepository GetDetalleVentaInstance()
        {
            if(backendType == "sqlserver")
            {
                return new DetalleVentaSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IEnvaseRepository GetEnvaseInstance()
        {
            if (backendType == "sqlserver")
            {
                return new EnvaseSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IInsumoRepository GetInsumoInstance()
        {
            if (backendType == "sqlserver")
            {
                return new InsumoSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IMovimientoStockRepository GetMovimientoStockInstance()
        {
            if(backendType == "sqlserver")
            {
                return new MovimientoStockSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IPedidoRepository GetPedidoInstance()
        {
            if(backendType == "sqlserver")
            {
                return new PedidoSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IProductoRepository GetProductoInstance()
        {
            if (backendType == "sqlserver")
            {
                return new ProductoSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IRepartidorRepository GetRepartidorInstance()
        {
            if (backendType == "sqlserver")
            {
                return new RepartidorSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static ISaborRepository GetSaborInstance()
        {
            if (backendType == "sqlserver")
            {
                return new SaborSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static ISaborSeleccionadoRepository GetSaborSeleccionadoInstance()
        {
            if (backendType == "sqlserver")
            {
                return new SaborSeleccionadoSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }

        public static IVentaRepository GetVentaInstance()
        {
            if (backendType == "sqlserver")
            {
                return new VentaSqlRepository();
            }
            throw new DataAccessException("No fue posible ingresar a los datos");
        }
    }
}
