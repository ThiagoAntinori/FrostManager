using Microsoft.Data.SqlClient;
using Services.DAL.Adapter;
using Services.DAL.Tools;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{
    public class FamiliaFamiliaRepository
    {

        private readonly static FamiliaFamiliaRepository _instance = new FamiliaFamiliaRepository();

        public static FamiliaFamiliaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaFamiliaRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Familia obj)
        {
            try
            {
                foreach(var item in obj.GetChildren())
                {
                    if(item.ChildrenCount() > 0)
                    {
                        SqlHelper.ExecuteNonQuery("IF NOT EXISTS (" +
                            "SELECT 1 FROM FAMILIA_FAMILIA " +
                            "WHERE IdFamiliaPadre = @IdFamiliaPadre AND IdFamiliaHijo = @IdFamiliaHijo) " +
                            "BEGIN " +
                            "INSERT INTO FAMILIA_FAMILIA (IdFamiliaPadre, IdFamiliaHijo) " +
                            "VALUES (@IdFamiliaPadre, @IdPatenteHijo) " +
                            "END ",
                            CommandType.Text,
                            new SqlParameter[]
                            {
                                new SqlParameter("@IdFamiliaPadre", obj.IdComponente),
                                new SqlParameter("@IdFamiliaHijo", item.IdComponente)
                            });
                    }
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void Delete(Familia familiaPadre, Familia familiaHijo)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("DELETE FROM FAMILIA_FAMILIA WHERE IdFamiliaPadre = @IdFamiliaPadre AND IdFamiliaHijo = @IdFamiliaHijo",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdFamiliaPadre", familiaPadre.IdComponente),
                                                new SqlParameter("@IdFamiliaHijo", familiaHijo.IdComponente)
                                            });
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void GetChildren(Familia obj)
        {
            try
            {
                Familia familiaGet = null;
                using (var reader = SqlHelper.ExecuteReader("SELECT IdFamiliaPadre, IdFamiliaHijo FROM FAMILIA_FAMILIA WHERE IdFamiliaPadre = @IdFamiliaPadre",
                                                            CommandType.Text,
                                                            new SqlParameter[]
                                                            {
                                                                new SqlParameter("@IdFamiliaPadre", obj.IdComponente)
                                                            }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        Guid idFamiliaHija = Guid.Parse(values[1].ToString());
                        familiaGet = FamiliaRepository.Current.GetById(idFamiliaHija);
                        obj.Agregar(familiaGet);
                    }
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
