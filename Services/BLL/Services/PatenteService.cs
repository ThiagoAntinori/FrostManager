using Services.BLL.Contracts;
using Services.BLL.Extensions;
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
                if(obj.IdComponente == Guid.Empty)
                {
                    throw new Exception("La patente debe tener un ID");
                }
                if (string.IsNullOrEmpty(obj.Nombre))
                {
                    throw new Exception("La patente debe tener un nombre.");
                }
                PatenteRepository.Current.Insert(obj);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Patente obj)
        {
            try
            {
                if(obj == null)
                {
                    throw new Exception("No se pudo eliminar la patente");
                }
                if(obj.IdComponente == Guid.Empty)
                {
                    throw new Exception("La patente a eliminar debe tener un ID");
                }
                PatenteRepository.Current.Delete(obj);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }

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
            try
            {
                if (id == null || id == Guid.Empty)
                {
                    throw new Exception("El ID de patente no es válido");
                }
                Patente patenteBuscada = PatenteRepository.Current.GetById(id);
                if (patenteBuscada == null)
                {
                    throw new Exception("No se pudo encontrar la pantente con ese ID");
                }
                return patenteBuscada;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }

        }

        public void Update(Patente obj)
        {
            try
            {
                if (obj == null)
                {
                    throw new Exception("No se pudo registrar la patente.");
                }
                if (obj.IdComponente == Guid.Empty)
                {
                    throw new Exception("La patente debe tener un ID");
                }
                if (string.IsNullOrEmpty(obj.Nombre))
                {
                    throw new Exception("La patente debe tener un nombre.");
                }
                PatenteRepository.Current.Update(obj);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
