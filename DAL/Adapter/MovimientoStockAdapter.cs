using DAL.Contracts;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Adapter
{
    public class MovimientoStockAdapter : IAdapter<MovimientoStock>
    {

        private readonly static MovimientoStockAdapter _instance = new MovimientoStockAdapter();

        public static MovimientoStockAdapter Current
        {
            get
            {
                return _instance;
            }
        }

        private MovimientoStockAdapter()
        {
            // Implement here the initialization of your singleton
        }

        public MovimientoStock Adapt(object[] values)
        {
            return new MovimientoStock()
            {
                IdMovimientoStock = Guid.Parse(values[0].ToString()),
                Insumo = Repository.GetInsumoInstance().GetById(Guid.Parse(values[1].ToString())),
                Cantidad = Convert.ToInt32(values[2].ToString()),
                FechaHora = Convert.ToDateTime(values[3].ToString()),
                TipoMovimiento = (TipoMovimientoStock)Convert.ToInt32(values[4].ToString()),
                Motivo = values[5].ToString()
            };
        }
    }
}
