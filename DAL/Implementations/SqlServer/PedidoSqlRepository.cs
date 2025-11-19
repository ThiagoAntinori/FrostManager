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

namespace DAL.Implementations.SqlServer
{
    public class PedidoSqlRepository : IPedidoRepository
    {
        public void Delete(Pedido obj, UnitOfWork uow = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Pedido> GetAll()
        {
            try
            {
                Pedido pedidoGet = null;
                List<Pedido> pedidos = new List<Pedido>();

                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdPedido, HoraEnvio, HoraEntrega, IdEstadoPedido, IdVenta, IdCliente, IdRepartidor FROM Pedido",
                    CommandType.Text,
                    new SqlParameter[]{}))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        pedidoGet = PedidoAdapter.Current.Adapt(values);
                        pedidos.Add(pedidoGet);
                    }
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public List<Pedido> GetByEstado(EstadoPedido estado)
        {
            try
            {
                Pedido pedidoGet = null;
                List<Pedido> pedidos = new List<Pedido>();

                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdPedido, HoraEnvio, HoraEntrega, IdEstadoPedido, IdVenta, IdCliente, IdRepartidor FROM Pedido WHERE IdEstadoPedido = @IdEstadoPedido",
                    CommandType.Text,
                    new SqlParameter[] 
                    {
                        new SqlParameter("@IdEstadoPedido", (int)estado)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        pedidoGet = PedidoAdapter.Current.Adapt(values);
                        pedidos.Add(pedidoGet);
                    }
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Pedido GetById(Guid id)
        {
            try
            {
                Pedido pedidoGet = null;

                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdPedido, HoraEnvio, HoraEntrega, IdEstadoPedido, IdVenta, IdCliente, IdRepartidor FROM Pedido WHERE IdPedido = @IdPedido",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdPedido", id)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        pedidoGet = PedidoAdapter.Current.Adapt(values);
                    }
                }
                return pedidoGet;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public List<Pedido> GetByPeriodo(DateOnly fechaInicio, DateOnly fechaFin)
        {
            try
            {
                Pedido pedidoGet = null;
                List<Pedido> pedidos = new List<Pedido>();

                string selectQuery = @"SELECT p.IdPedido, p.HoraEnvio, p.HoraEntrega, p.IdEstadoPedido, p.IdVenta, p.IdCliente, p.IdRepartidor 
                                        FROM Pedido p
                                        INNER JOIN Venta v ON v.IdVenta = p.IdVenta
                                        WHERE v.Fecha BETWEEN @FechaInicio AND @FechaFin";

                using (SqlDataReader reader = SqlHelper.ExecuteReader(selectQuery,
                    CommandType.Text,
                    new SqlParameter[] 
                    {
                        new SqlParameter("@FechaInicio", fechaInicio),
                        new SqlParameter("@FechaFin", fechaInicio)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        pedidoGet = PedidoAdapter.Current.Adapt(values);
                        pedidos.Add(pedidoGet);
                    }
                }
                return pedidos;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Insert(Pedido obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO Pedido (IdPedido, HoraEnvio, HoraEntrega, IdEstadoPedido, IdVenta, IdCliente, IdRepartidor, Borrado) VALUES (@IdPedido, @HoraEnvio, @HoraEntrega, @IdEstadoPedido, @IdVenta, @IdCliente, @IdRepartidor, 0)",
                                            CommandType.Text,
                                            uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdPedido", obj.IdPedido),
                                                new SqlParameter("@HoraEnvio", obj.HoraEnvio),
                                                new SqlParameter("@HoraEntrega", obj.HoraEntrega),
                                                new SqlParameter("@IdEstadoPedido", (int)obj.Estado),
                                                new SqlParameter("@IdVenta", obj.Venta.IdVenta),
                                                new SqlParameter("@IdCliente", obj.Cliente.IdCliente),
                                                new SqlParameter("@IdRepartidor", obj.Repartidor.IdRepartidor)
                                            });

            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(Pedido obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE INTO Pedido SET HoraEnvio = @HoraEnvio, HoraEntrega = @HoraEntrega, IdEstadoPedido = @IdEstadoPedido, IdVenta = @IdVenta, IdCliente = @IdCliente, IdRepartidor = @IdRepartidor WHERE IdPedido = @IdPedido AND Borrado = 0",
                                            CommandType.Text,
                                            uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdPedido", obj.IdPedido),
                                                new SqlParameter("@HoraEnvio", obj.HoraEnvio),
                                                new SqlParameter("@HoraEntrega", obj.HoraEntrega),
                                                new SqlParameter("@IdEstadoPedido", (int)obj.Estado),
                                                new SqlParameter("@IdVenta", obj.Venta.IdVenta),
                                                new SqlParameter("@IdCliente", obj.Cliente.IdCliente),
                                                new SqlParameter("@IdRepartidor", obj.Repartidor.IdRepartidor)
                                            });

            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }


    }
}
