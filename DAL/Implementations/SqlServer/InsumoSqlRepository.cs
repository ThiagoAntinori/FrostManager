using DAL.Contracts;
using DAL.Implementations.Factory;
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

namespace DAL.Implementations.SqlServer
{
    public class InsumoSqlRepository : IInsumoRepository
    {
        public void Delete(Insumo obj, UnitOfWork uow = null)
        {
            try
            {
                if (obj is Envase envase)
                {
                    Repository.GetEnvaseInstance().Delete(envase, uow);
                }
                else if (obj is Sabor sabor)
                {
                    Repository.GetSaborInstance().Delete(sabor, uow);
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Insumo> GetAll()
        {
            try
            {
                List<Insumo> envases = Repository.GetEnvaseInstance().GetAll().Cast<Insumo>().ToList();
                List<Insumo> sabores = Repository.GetEnvaseInstance().GetAll().Cast<Insumo>().ToList();

                List<Insumo> insumos = new List<Insumo>();
                insumos.AddRange(envases);
                insumos.AddRange(sabores);

                return insumos;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Insumo GetById(Guid id)
        {
            try
            {
                Envase envaseGet = Repository.GetEnvaseInstance().GetById(id);
                if (envaseGet != null)
                    return envaseGet;

                Sabor saborGet = Repository.GetSaborInstance().GetById(id);
                if (saborGet != null)
                    return saborGet;

                return null;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Insert(Insumo obj, UnitOfWork uow = null)
        {
            try
            {
                if (obj is Envase envase)
                {
                    Repository.GetEnvaseInstance().Insert(envase, uow);
                }
                else if (obj is Sabor sabor)
                {
                    Repository.GetSaborInstance().Insert(sabor);
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Update(Insumo obj, UnitOfWork uow = null)
        {
            try
            {
                if (obj is Envase envase)
                {
                    Repository.GetEnvaseInstance().Update(envase, uow);
                }
                else if (obj is Sabor sabor)
                {
                    Repository.GetSaborInstance().Update(sabor);
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void ActualizarStock(Insumo obj, UnitOfWork uow = null)
        {
            try
            {
                string updateStockQuery = @"
                    UPDATE Insumo SET StockActual = @StockActual WHERE IdInsumo = @IdInsumo";
                SqlHelper.ExecuteNonQuery(updateStockQuery, CommandType.Text, uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@StockActual", obj.StockActual),
                                                new SqlParameter("@IdInsumo", obj.IdInsumo)
                                            });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void RestarStock(Guid idInsumo, int cantidad, UnitOfWork uow)
        {
            try
            {
                string restarStockQuery = @"UPDATE Insumo SET StockActual = StockActual - @Cantidad
                                            WHERE IdInsumo = @IdInsumo AND StockActual >= @Cantidad";

                int rows = SqlHelper.ExecuteNonQuery(restarStockQuery, CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Cantidad", cantidad),
                        new SqlParameter("@IdInsumo", idInsumo)
                    });
                if(rows == 0)
                {
                    throw new Exception("No hay stock suficiente para el insumo");
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
