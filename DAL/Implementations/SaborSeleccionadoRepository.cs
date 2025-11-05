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
    public class SaborSeleccionadoRepository : IGenericRepository<SaborSeleccionado>
    {
        public void Delete(SaborSeleccionado obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SaborSeleccionado> GetAll()
        {
            try
            {
                SaborSeleccionado SaborGet = null;
                List<SaborSeleccionado> saboresSeleccionados = new List<SaborSeleccionado>();

            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public SaborSeleccionado GetById(Guid id)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Insert(SaborSeleccionado obj, UnitOfWork uow = null)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO SaborSeleccionado (IdSabor, CantidadEnGramos, IdDetalleVenta) VALUES (@IdSabor, @CantidadEnGramos, @IdDetalleVenta)",
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
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(SaborSeleccionado obj)
        {
            throw new NotImplementedException();
        }
    }
}
