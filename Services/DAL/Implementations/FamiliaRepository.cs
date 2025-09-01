using Microsoft.Data.SqlClient;
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
                SqlHelper.ExecuteNonQuery("INSERT INTO FAMILIA (IdFamilia, Nombre) VALUES (@IdFamilia, @Nombre)",
                                            CommandType.Text,
                                            new SqlParameter[]
                                            {
                                                new SqlParameter("@IdFamilia", item.IdComponente),
                                                new SqlParameter("@Nombre", item.Nombre)
                                            });
                FamiliaFamiliaRepository.Current.Add(item);
                FamiliaPatenteRepository.Current.Add(item);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public void Delete(Familia item)
        {
            throw new NotImplementedException();
        }

        public void Update(Familia item)
        {
            throw new NotImplementedException();
        }

        public List<Familia> GetAll()
        {
            try
            {
                List<Familia> familias = new List<Familia>();
                Familia familiaGet = null;
                using(var reader = SqlHelper.ExecuteReader("SELECT (IdFamilia, Nombre) FROM FAMILIA",
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
                using (var reader = SqlHelper.ExecuteReader("SELECT IdFamilia, Nombre FROM FAMILIA WHERE IdFamilia = @IdFamilia",
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
