using Microsoft.Data.SqlClient;
using Services.BLL.Contracts;
using Services.BLL.Extensions;
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

        public void Delete(Familia obj)
        {
            try
            {
                if(obj.IdComponente == Guid.Empty)
                {
                    throw new Exception("La familia a eliminar debe tener un ID");
                }
                FamiliaRepository.Current.Delete(obj);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public List<Familia> SelectAll()
        {
            try
            {
                return FamiliaRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Familia SelectOne(Guid id)
        {
            try
            {
                return FamiliaRepository.Current.GetById(id);
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Update(Familia obj)
        {
            try
            {
                if (string.IsNullOrEmpty(obj.Nombre))
                {
                    throw new Exception("La familia debe tener un nombre");
                }
                if (obj.ChildrenCount() <= 0)
                {
                    throw new Exception("La familia debe tener al menos un componente");
                }
                FamiliaRepository.Current.Update(obj);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
