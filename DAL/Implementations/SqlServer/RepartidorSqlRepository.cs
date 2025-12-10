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
    public class RepartidorSqlRepository : IRepartidorRepository
    {
        public void Delete(Repartidor obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE REPARTIDOR SET Activo = 0 WHERE IdRepartidor = @IdRepartidor",
                                            CommandType.Text,
                                            uow?.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdRepartidor", obj.IdRepartidor)
                                            });
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public IEnumerable<Repartidor> GetAll()
        {
            try
            {
                Repartidor repartidorGet = null;
                List<Repartidor> repartidores = new List<Repartidor>();
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdRepartidor, Nombre, Apellido, Email, Activo FROM REPARTIDOR",
                                                                    CommandType.Text,
                                                                    new SqlParameter[] { }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        repartidorGet = RepartidorAdapter.Current.Adapt(values);
                        repartidores.Add(repartidorGet);
                    }
                }
                return repartidores;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Repartidor GetById(Guid id)
        {
            try
            {
                Repartidor repartidorGet = null;

                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdRepartidor, Nombre, Apellido, Email, Activo FROM REPARTIDOR WHERE IdRepartidor = @IdRepartidor AND Activo = 1",
                                                                    CommandType.Text,
                                                                    new SqlParameter[]
                                                                    {
                                                                        new SqlParameter("@IdRepartidor", id)
                                                                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        repartidorGet = RepartidorAdapter.Current.Adapt(values);
                    }
                }
                return repartidorGet;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Insert(Repartidor obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO REPARTIDOR (IdRepartidor, Nombre, Apellido, Email, Activo) VALUES (@IdRepartidor, @Nombre, @Apellido, @Email, 1)",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdRepartidor", obj.IdRepartidor),
                        new SqlParameter("@Nombre", obj.Nombre),
                        new SqlParameter("@Apellido", obj.Apellido),
                        new SqlParameter("@Email", obj.Email)
                    });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Update(Repartidor obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE REPARTIDOR SET Nombre = @Nombre, Apellido = @Apellido, Email = @Email, Activo = @Activo WHERE IdRepartidor = @IdRepartidor",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdRepartidor", obj.IdRepartidor),
                        new SqlParameter("@Nombre", obj.Nombre),
                        new SqlParameter("@Apellido", obj.Apellido),
                        new SqlParameter("@Email", obj.Email),
                        new SqlParameter("@Activo", obj.Activo)
                    });
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
