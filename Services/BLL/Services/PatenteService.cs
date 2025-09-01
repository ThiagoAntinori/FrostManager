using Services.BLL.Contracts;
using Services.DAL.Implementations;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public class PatenteService : IGenericService<Patente>
    {

        private readonly static PatenteService _instance = new PatenteService();

        public static PatenteService Current
        {
            get
            {
                return _instance;
            }
        }

        private PatenteService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Patente obj)
        {
            try
            {
                if(obj == null)
                {
                    throw new Exception("No se pudo registrar la patente.");
                }
                if (string.IsNullOrEmpty(obj.Nombre))
                {
                    throw new Exception("La patente debe tener un nombre.");
                }
                PatenteRepository.Current.Insert(obj);
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

        public List<Patente> SelectAll()
        {
            try
            {
                return PatenteRepository.Current.GetAll();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public Patente SelectOne(Guid id)
        {
            if(id == null || id == Guid.Empty)
            {
                throw new Exception("El ID de patente no es válido");
            }
            Patente patenteBuscada = PatenteRepository.Current.GetById(id);
            if(patenteBuscada == null)
            {
                throw new Exception("No se pudo encontrar la pantente con ese ID");
            }
            return patenteBuscada;
        }

        public void Update(Patente obj)
        {
            throw new NotImplementedException();
        }
    }
}
