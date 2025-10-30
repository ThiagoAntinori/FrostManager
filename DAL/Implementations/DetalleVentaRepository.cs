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
    public class DetalleVentaRepository : IGenericRepository<DetalleVenta>
    {

        private readonly static DetalleVentaRepository _instance = new DetalleVentaRepository();

        public static DetalleVentaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private DetalleVentaRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(DetalleVenta obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DetalleVenta> GetAll()
        {
            throw new NotImplementedException();
        }

        public DetalleVenta GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Insert(DetalleVenta obj)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO DetalleVenta (IdDetalleVenta, Cantidad, IdProducto, IdVenta) VALUES (@IdDetalleVenta, @Cantidad, @IdProducto, IdVenta",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdDetalleVenta", obj.IdDetalleVenta),
                                                new SqlParameter("@Cantidad", obj.Cantidad),
                                                new SqlParameter("@IdProducto", obj.Producto.IdProducto),
                                                new SqlParameter("@IdVenta", obj.IdVenta)
                                            });
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(DetalleVenta obj)
        {
            throw new NotImplementedException();
        }
    }
}
