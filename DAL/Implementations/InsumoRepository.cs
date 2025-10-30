using DAL.Contracts;
using Domain;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementations
{
    public class InsumoRepository : IGenericRepository<Insumo>
    {

        private readonly static InsumoRepository _instance = new InsumoRepository();

        public static InsumoRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private InsumoRepository()
        {
            // Implement here the initialization of your singleton
        }

        public void Delete(Insumo obj)
        {
            try
            {
                if(obj is Envase envase)
                {
                    EnvaseRepository.Current.Delete(envase);
                }
                else if(obj is Sabor sabor)
                {
                    SaborRepository.Current.Delete(sabor);
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public IEnumerable<Insumo> GetAll()
        {
            try
            {
                List<Insumo> envases = EnvaseRepository.Current.GetAll().Cast<Insumo>().ToList();
                List<Insumo> sabores = SaborRepository.Current.GetAll().Cast<Insumo>().ToList();

                List<Insumo> insumos = new List<Insumo>();
                insumos.AddRange(envases);
                insumos.AddRange(sabores);

                return insumos;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public Insumo GetById(Guid id)
        {
            try
            {
                Envase envaseGet = EnvaseRepository.Current.GetById(id);
                if (envaseGet != null)
                    return envaseGet;

                Sabor saborGet = SaborRepository.Current.GetById(id);
                if (saborGet != null)
                    return saborGet;

                return null;
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void Insert(Insumo obj)
        {
            try
            {
                if (obj is Envase envase)
                {
                    EnvaseRepository.Current.Insert(envase);
                }
                else if (obj is Sabor sabor)
                {
                    SaborRepository.Current.Insert(sabor);
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }

        public void Update(Insumo obj)
        {
            try
            {
                if(obj is Envase envase)
                {
                    EnvaseRepository.Current.Update(envase);
                }
                else if(obj is Sabor sabor)
                {
                    SaborRepository.Current.Update(sabor);
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
