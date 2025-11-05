using DAL.Adapter;
using DAL.Contracts;
using DAL.Tools;
using Domain;
using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class MovimientoStockRepository : IGenericRepository<MovimientoStock>
    {

        private readonly static MovimientoStockRepository _instance = new MovimientoStockRepository();

        public static MovimientoStockRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private MovimientoStockRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(MovimientoStock obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<MovimientoStock> GetAll()
        {
            try
            {
                MovimientoStock movimientoStockGet = null;
                List<MovimientoStock> movimientosStock = new List<MovimientoStock>();

                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdMovimientoStock, IdInsumo, Cantidad, FechaHora, IdTipoMovimientoStock, Motivo FROM MovimientoStock WHERE Borrado = 0",
                                                                        CommandType.Text,
                                                                        new SqlParameter[]{}))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        movimientoStockGet = MovimientoStockAdapter.Current.Adapt(values);
                        movimientosStock.Add(movimientoStockGet);
                    }
                }

                return movimientosStock;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public MovimientoStock GetById(Guid id)
        {
            try
            {
                MovimientoStock movimientoStockGet = null;
                using(SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdMovimientoStock, IdInsumo, Cantidad, FechaHora, IdTipoMovimientoStock, Motivo FROM MovimientoStock WHERE IdMovimientoStock = @IdMovimientoStock",
                                                                        CommandType.Text,
                                                                        new SqlParameter[]
                                                                        {
                                                                            new SqlParameter("@IdMovimientoStock", id)
                                                                        }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        movimientoStockGet = MovimientoStockAdapter.Current.Adapt(values);
                    }
                }
                return movimientoStockGet;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Insert(MovimientoStock obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO MovimientoStock (IdMovimientoStock, IdInsumo, Cantidad, FechaHora, IdTipoMovimiento, Motivo) VALUES (@IdMovimientoStock, @IdInsumo, @Cantidad, @FechaHora, @IdTipoMovimiento, @Motivo)",
                                            CommandType.Text,
                                            uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdMovimientoStock", obj.IdMovimientoStock),
                                                new SqlParameter("@IdInsumo", obj.Insumo.IdInsumo),
                                                new SqlParameter("@Cantidad", obj.Cantidad),
                                                new SqlParameter("@FechaHora", obj.FechaHora),
                                                new SqlParameter("@IdTipoMovimiento", (int)obj.TipoMovimiento),
                                                new SqlParameter("@Motivo", obj.Motivo)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(MovimientoStock obj)
        {
            throw new NotImplementedException();
        }

        public void Insert(MovimientoStock obj)
        {
            throw new NotImplementedException();
        }
    }
}
