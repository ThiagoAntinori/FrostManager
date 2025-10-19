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
    public class ProductoRepository : IGenericRepository<Producto>
    {

        private readonly static ProductoRepository _instance = new ProductoRepository();

        public static ProductoRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private ProductoRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(Producto obj)
        {
            SqlHelper.ExecuteNonQuery("UPDATE PRODUCTO SET Borrado = TRUE WHERE IdProducto = @IdProducto",
                CommandType.Text,
                new SqlParameter[]
                {
                    new SqlParameter("@IdProducto", obj.IdProducto)
                });
        }

        public IEnumerable<Producto> GetAll()
        {
            try
            {
                Producto productoGet = null;
                List<Producto> productos = new List<Producto>();
                using(SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdProducto, Descripcion, CapacidadEnGramos, PrecioUnitario, IdEnvase FROM PRODUCTO WHERE Borrado = FALSE",
                    CommandType.Text,
                    new SqlParameter[] { }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        productoGet = ProductoAdapter.Current.Adapt(values);
                        productos.Add(productoGet);
                    }
                    return productos;
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Producto GetById(Guid id)
        {
            try
            {
                Producto productoGet = null;
                using (SqlDataReader reader = SqlHelper.ExecuteReader("SELECT IdProducto, Descripcion, CapacidadEnGramos, PrecioUnitario, IdEnvase FROM PRODUCTO WHERE IdProducto = @IdProducto AND Borrado = FALSE",
                    CommandType.Text,
                    new SqlParameter[] 
                    {
                        new SqlParameter("@IdProducto", id)
                    }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        productoGet = ProductoAdapter.Current.Adapt(values);
                    }
                    return productoGet;
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Insert(Producto obj)
        {
            SqlHelper.ExecuteNonQuery("INSERT INTO PRODUCTO (IdProducto, Descripcion, CapacidadEnGramos, PrecioUnitario, IdEnvase, Borrado VALUES (@IdProducto, @Descripcion, @CapacidadEnGramos, @PrecioUnitario, @IdEnvase, FALSE);",
                CommandType.Text,
                new SqlParameter[]
                {
                    new SqlParameter("@IdProducto", obj.IdProducto),
                    new SqlParameter("@Descripcion", obj.Descripcion),
                    new SqlParameter("@CapacidadEnGramos", obj.CapacidadEnGramos),
                    new SqlParameter("@PrecioUnitario", obj.PrecioUnitario),
                    new SqlParameter("@IdEnvase", obj.EnvaseNecesario.IdEnvase)
                });
        }

        public void Update(Producto obj)
        {
            SqlHelper.ExecuteNonQuery("UPDATE PRODUCTO SET Descripcion = @Descripcion, CapacidadEnGramos = @CapacidadEnGramos, PrecioUnitario = @PrecioUnitario, IdEnvase = @IdEnvase WHERE IdProducto = @IdProducto",
                CommandType.Text,
                new SqlParameter[]
                {
                    new SqlParameter("@IdProducto", obj.IdProducto),
                    new SqlParameter("@Descripcion", obj.Descripcion),
                    new SqlParameter("@CapacidadEnGramos", obj.CapacidadEnGramos),
                    new SqlParameter("@PrecioUnitario", obj.PrecioUnitario),
                    new SqlParameter("@IdEnvase", obj.EnvaseNecesario.IdEnvase)
                });
        }
    }
}
