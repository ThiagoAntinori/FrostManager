using Microsoft.Data.SqlClient;
using Services.BLL.Contracts;
using Services.DAL.Contracts;
using Services.DAL.Implementations;
using Services.DAL.Tools;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public class FamiliaService : IGenericService<Familia>
    {

        private readonly static FamiliaService _instance = new FamiliaService();

        public static FamiliaService Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Familia obj)
        {
            try
            {
                if(obj == null)
                {
                    throw new Exception("No es posible registrar la familia");
                }
                if (string.IsNullOrEmpty(obj.Nombre))
                {
                    throw new Exception("La familia debe tener un nombre");
                }
                if(obj.ChildrenCount() <= 0)
                {
                    throw new Exception("La familia debe tener al menos un componente.");
                }
                FamiliaRepository.Current.Insert(obj);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Familia> SelectAll()
        {
            throw new NotImplementedException();
        }

        public Familia SelectOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Familia obj)
        {
            throw new NotImplementedException();
        }
    }
}
