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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations.SqlServer
{
    public class SaborSeleccionadoSqlRepository : ISaborSeleccionadoRepository
    {
        public void Delete(SaborSeleccionado obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE SaborSeleccionado SET Borrado = 1 WHERE IdSabor = @IdSabor AND IdDetalleVenta = @IdDetalleVenta",
                                            CommandType.Text,
                                            uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdSabor", obj.Sabor.IdInsumo),
                                                new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<SaborSeleccionado> GetAll()
        {
            try
            {
                SaborSeleccionado saborGet = null;
                List<SaborSeleccionado> saboresSeleccionados = new List<SaborSeleccionado>();
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdSabor, CantidadEnGramos, IdDetalleVenta FROM SaborSeleccionado",
                    CommandType.Text,
                    new SqlParameter[] { }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        saborGet = SaborSeleccionadoAdapter.Current.Adapt(values);
                        saboresSeleccionados.Add(saborGet);
                    }
                }
                return saboresSeleccionados;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public SaborSeleccionado GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(SaborSeleccionado obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO SaborSeleccionado (IdSabor, CantidadEnGramos, IdDetalleVenta, Borrado) VALUES (@IdSabor, @CantidadEnGramos, @IdDetalleVenta, 0)",
                    CommandType.Text,
                    uow?.Transaction,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdSabor", obj.Sabor.IdInsumo),
                        new SqlParameter("@CantidadEnGramos", obj.CantidadEnGramos),
                        new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta)
                    });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Update(SaborSeleccionado obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE SaborSeleccionado SET CantidadEnGramos = @CantidadEnGramos WHERE IdSabor = @IdSabor AND IdDetalleVenta = @IdDetalleVenta AND Borrado = 0",
                                            CommandType.Text,
                                            uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@CantidadEnGramos", obj.CantidadEnGramos),
                                                new SqlParameter("@IdSabor", obj.Sabor.IdInsumo),
                                                new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta)
                                            });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public List<SaborSeleccionado> GetByIdSabor(Guid idSabor)
        {
            try
            {
                SaborSeleccionado saborGet = null;
                List<SaborSeleccionado> saboresSeleccionados = new List<SaborSeleccionado>();
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdSabor, CantidadEnGramos, IdDetalleVenta FROM SaborSeleccionado WHERE IdSabor = @IdSabor AND Borrado = 0",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdSabor", idSabor)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        saborGet = SaborSeleccionadoAdapter.Current.Adapt(values);
                        saboresSeleccionados.Add(saborGet);
                    }
                }
                return saboresSeleccionados;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public List<SaborSeleccionado> GetByIdDetalleVenta(Guid idDetalleVenta)
        {
            try
            {
                SaborSeleccionado saborGet = null;
                List<SaborSeleccionado> saboresSeleccionados = new List<SaborSeleccionado>();
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdSabor, CantidadEnGramos, IdDetalleVenta FROM SaborSeleccionado WHERE IdDetalleVenta = @IdDetalleVenta AND Borrado = 0",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdDetalleVenta", idDetalleVenta)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        saborGet = SaborSeleccionadoAdapter.Current.Adapt(values);
                        saboresSeleccionados.Add(saborGet);
                    }
                }
                return saboresSeleccionados;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
