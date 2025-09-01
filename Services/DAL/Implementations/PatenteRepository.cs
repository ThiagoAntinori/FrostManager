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
    public class PatenteRepository : IGenericRepository<Patente>
    {

        private readonly static PatenteRepository _instance = new PatenteRepository();

        public static PatenteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private PatenteRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(Patente item)
        {
            throw new NotImplementedException();
        }

        public List<Patente> GetAll()
        {
            try
            {
                List<Patente> patentes = new List<Patente>();
                Patente patenteGet = null;

                using(var reader = SqlHelper.ExecuteReader("SELECT IdPatente, Nombre, MenuItemName, FormName FROM PATENTE",
                                                CommandType.Text,
                                                new SqlParameter[] { }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        patenteGet = PatenteAdapter.Current.Adapt(values);
                        patentes.Add(patenteGet);
                    }

                    return patentes;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

        public Patente GetById(Guid id)
        {
            try
            {
                using (var reader = SqlHelper.ExecuteReader("SELECT IdPatente, Nombre, MenuItemName, FormName FROM PATENTE WHERE IdPatente = @IdPatente",
                                                            CommandType.Text,
                                                            new SqlParameter[]
                                                            {
                                                                new SqlParameter("@IdPatente", id)
                                                            }))
                {
                    object[] values = new object[reader.FieldCount];

                    if (reader.Read())
                    {
                        reader.GetValues(values);
                        return PatenteAdapter.Current.Adapt(values);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Insert(Patente item)
        {
            try
            {
                SqlHelper.ExecuteNonQuery("INSERT INTO PATENTE (IdPatente, Nombre, MenuItemName, FormName) VALUES (@IdPatente, @Nombre, @MenuItemName, @FormName)",
                                            CommandType.Text,
                                            new SqlParameter[] 
                                            {
                                                new SqlParameter("@IdPatente", item.IdComponente),
                                                new SqlParameter("@Nombre", item.Nombre),
                                                new SqlParameter("@MenuItemName", item.MenuItemName),
                                                new SqlParameter("@FormName", item.FormName)
                                            });
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Update(Patente item)
        {
            throw new NotImplementedException();
        }
    }
}
