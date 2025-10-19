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
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class ClienteRepository : IGenericRepository<Cliente>
    {

        private readonly static ClienteRepository _instance = new ClienteRepository();

        public static ClienteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private ClienteRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Insert(Cliente obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO CLIENTE (IdCliente, Nombre, Apellido, DNI, Telefono, Direccion, DVH, Borrado)" +
                    "                       VALUES (@IdCliente, @Nombre, @Apellido, @DNI, @Telefono, @Direccion, @DVH, FALSE)",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdCliente", obj.IdCliente),
                                                new SqlParameter("@Nombre", obj.Nombre),
                                                new SqlParameter("@Apellido", obj.Apellido),
                                                new SqlParameter("@DNI", obj.DNI),
                                                new SqlParameter("@Telefono", obj.Telefono),
                                                new SqlParameter("@Direccion", obj.Direccion),
                                                new SqlParameter("@DVH", obj.DVH)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(Cliente obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE CLIENTE SET Nombre = @Nombre, Apellido = @Apellido, DNI = @DNI, Telefono = @Telefono, Direccion = @Direccion, DVH = @DVH WHERE IdCliente = @IdCliente",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@Nombre", obj.Nombre),
                        new SqlParameter("@Apellido", obj.Apellido),
                        new SqlParameter("@DNI", obj.DNI),
                        new SqlParameter("@Telefono", obj.Telefono),
                        new SqlParameter("@Direccion", obj.Direccion),
                        new SqlParameter("@DVH", obj.DVH),
                        new SqlParameter("@IdCliente", obj.IdCliente)
                    });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Delete(Cliente obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE CLIENTE SET Borrado = TRUE WHERE IdCliente = @IdCliente",
                    CommandType.Text,
                    new SqlParameter[]
                    {
                        new SqlParameter("@IdCliente", obj.IdCliente)
                    });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Cliente GetById(Guid id)
        {
            try
            {
                Cliente clienteGet = null;
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdCliente, Nombre, Apellido, DNI, Telefono, Direccion, DVH FROM CLIENTE WHERE IdCliente = @IdCliente AND Borrado = FALSE",
                                                                    CommandType.Text,
                                                                    new SqlParameter[]
                                                                    {
                                                                        new SqlParameter("@IdCliente", id)
                                                                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        clienteGet = ClienteAdapter.Current.Adapt(values);
                    }
                }
                return clienteGet;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public IEnumerable<Cliente> GetAll(Cliente obj)
        {
            try
            {
                List<Cliente> clientes = new List<Cliente>();
                Cliente clienteGet = null;
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdCliente, Nombre, Apellido, DNI, Telefono, Direccion, DVH FROM CLIENTE WHERE Borrado = FALSE",
                    CommandType.Text,
                    new SqlParameter[] { }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        clienteGet = ClienteAdapter.Current.Adapt(values);
                        clientes.Add(clienteGet);
                    }
                    return clientes;
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public bool ExisteCliente(string DNI)
        {
            try
            {
                bool existeCliente = false;
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT * FROM CLIENTE WHERE DNI = @DNI AND Borrado = FALSE",
                                                                    CommandType.Text,
                                                                    new SqlParameter[]
                                                                    {
                                                                        new SqlParameter("@DNI", DNI)
                                                                    }))
                {
                    if (reader.Read())
                    {
                        existeCliente = true;
                    }
                }
                return existeCliente;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Cliente GetByDNI(string DNI)
        {
            try
            {
                Cliente clienteGet = null;
                using(SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdCliente, Nombre, Apellido, DNI, Telefono, Direccion, DVH FROM CLIENTE WHERE DNI = @DNI AND Borrado = FALSE",
                                                                    CommandType.Text,
                                                                    new SqlParameter[]
                                                                    {
                                                                        new SqlParameter("@DNI", DNI)
                                                                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        clienteGet = ClienteAdapter.Current.Adapt(values);
                    }
                }
                return clienteGet;
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }
    }
}
