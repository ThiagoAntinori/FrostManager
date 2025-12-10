using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using Services.DAL.Adapter;
using Services.DAL.Contracts;
using Services.DAL.Tools;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{
    public class FamiliaRepository : IGenericRepository<Familia>
    {

        private readonly static FamiliaRepository _instance = new FamiliaRepository();

        public static FamiliaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Insert(Familia item)
        {
            try
            {
                using(UnitOfWork uow = new UnitOfWork())
                {
                    SqlHelper.ExecuteNonQuery("INSERT INTO FAMILIA (IdFamilia, Nombre, Borrado) VALUES (@IdFamilia, @Nombre, 0)",
                                            CommandType.Text,
                                            uow.Transaction,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdFamilia", item.IdComponente),
                                                new SqlParameter("@Nombre", item.Nombre)
                                            });
                    FamiliaFamiliaRepository.Current.Add(item, uow);
                    FamiliaPatenteRepository.Current.Add(item, uow);
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void Delete(Familia item)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("UPDATE FAMILIA SET Borrado = 1 WHERE IdFamilia = @IdFamilia",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdFamilia", item.IdComponente)
                                            });
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public void Update(Familia item)
        {
            try
            {
                using(UnitOfWork uow = new UnitOfWork())
                {
                    try
                    {
                        SqlHelper.ExecuteNonQuery("UPDATE Familia SET Nombre = @Nombre WHERE IdFamilia = @IdFamilia",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@Nombre", item.Nombre),
                                                new SqlParameter("@IdFamilia", item.IdComponente)
                                            });
                        FamiliaPatenteRepository.Current.DeleteByFamilia(item.IdComponente, uow);
                        FamiliaPatenteRepository.Current.Add(item, uow);
                        FamiliaFamiliaRepository.Current.DeleteByFamiliaPadre(item.IdComponente, uow);
                        FamiliaFamiliaRepository.Current.Add(item, uow);
                        uow.Commit();
                    }
                    catch (Exception)
                    {
                        uow.Rollback();
                        throw;
                    }
                }
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public List<Familia> GetAll()
        {
            try
            {
                List<Familia> familias = new List<Familia>();
                Familia familiaGet = null;
                using(var reader = SqlHelper.ExecuteReader("SELECT IdFamilia, Nombre FROM FAMILIA WHERE Borrado = 0",
                                                            System.Data.CommandType.Text,
                                                            new SqlParameter[] {}))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        familiaGet = FamiliaAdapter.Current.Adapt(values);
                        familias.Add(familiaGet);
                    }
                }
                return familias;
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public Familia GetById(Guid id)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader("SELECT IdFamilia, Nombre FROM FAMILIA WHERE IdFamilia = @IdFamilia AND Borrado = 0",
                                                            CommandType.Text,
                                                            new SqlParameter[]
                                                            {
                                                                new SqlParameter("@IdFamilia", id)
                                                            }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        return FamiliaAdapter.Current.Adapt(values);
                    }
                    return null;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
