using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using Services.BLL.Extensions;
using Services.BLL.Services;
using Services.Domain.Exceptions.BusinessExceptions;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class InsumoService : IGenericService<Insumo>
    {

        private readonly static InsumoService _instance = new InsumoService();

        public static InsumoService Current
        {
            get
            {
                return _instance;
            }
        }

        private InsumoService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Insumo item)
        {
            try
            {
                if(item is Envase envase)
                {
                    EnvaseService.Current.Add(envase);
                }
                else if(item is Sabor sabor)
                {
                    SaborService.Current.Add(sabor);
                }
                LoggerHelper.RegistrarAlta(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Insumo item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                Repository.GetInsumoInstance().Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Insumo> SelectAll()
        {
            try
            {
                return Repository.GetInsumoInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Insumo SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, "IdInsumo");
                Insumo insumoGet = Repository.GetInsumoInstance().GetById(id);
                if(insumoGet == null)
                {
                    throw new Exception("No se encontró el insumo");
                }
                return insumoGet;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(Insumo item)
        {
            try
            {
                if(item is Envase envase)
                {
                    EnvaseService.Current.Update(envase);
                }
                else if(item is Sabor sabor)
                {
                    SaborService.Current.Update(sabor);
                }
                LoggerHelper.RegistrarModificacion(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void RegistrarIngreso(Insumo item, MovimientoStock movimiento)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.PositiveValue(movimiento.Cantidad, "Cantidad a sumar");
                
                using (UnitOfWork uof = new UnitOfWork())
                {
                    try
                    {
                        item.StockActual += movimiento.Cantidad;
                        Repository.GetInsumoInstance().ActualizarStock(item, uof);
                        Repository.GetMovimientoStockInstance().Insert(movimiento, uof);
                        uof.Commit();

                        LoggerHelper.RegistrarOperacionGenerica("INGRESO", item);
                    }
                    catch(Exception ex)
                    {
                        uof.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void RegistrarEgreso(Insumo item, MovimientoStock movimiento)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
                ValidationHelper.NotNull(movimiento, nameof(movimiento));
                ValidationHelper.NotEmptyGuid(movimiento.IdMovimientoStock, nameof(movimiento.IdMovimientoStock));
                ValidationHelper.NotEmpty(movimiento.Motivo, nameof(movimiento.Motivo));
                ValidationHelper.PositiveValue(movimiento.Cantidad, "Cantidad a restar");
                if (item.StockActual - movimiento.Cantidad < 0)
                {
                    throw new StockInsuficienteException(item.Descripcion, movimiento.Cantidad);
                }
                using(UnitOfWork uow = new UnitOfWork())
                {
                    try
                    {
                        item.StockActual -= movimiento.Cantidad;
                        Repository.GetInsumoInstance().ActualizarStock(item, uow);
                        Repository.GetMovimientoStockInstance().Insert(movimiento, uow);
                        uow.Commit();

                        LoggerHelper.RegistrarOperacionGenerica("EGRESO", item);

                        if(item.StockActual < item.StockMinimo)
                        {
                            NotificarBajoStock(item);
                        }
                    }
                    catch(Exception ex)
                    {
                        uow.Rollback();
                        throw;
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void ActualizarStock(Insumo item, MovimientoStock movimiento)
        {
            ValidationHelper.NotNull(item, nameof(item));
            ValidationHelper.NotEmptyGuid(item.IdInsumo, nameof(item.IdInsumo));
            ValidationHelper.NotNull(movimiento, nameof(movimiento));
            ValidationHelper.NotEmptyGuid(movimiento.IdMovimientoStock, nameof(movimiento.IdMovimientoStock));
            ValidationHelper.NotEmpty(movimiento.Motivo, nameof(movimiento.Motivo));
            ValidationHelper.PositiveValue(movimiento.Cantidad, "Nuevo stock");
            using (UnitOfWork uow = new UnitOfWork())
            {
                try
                {
                    item.StockActual = movimiento.Cantidad;
                    Repository.GetInsumoInstance().ActualizarStock(item, uow);
                    Repository.GetMovimientoStockInstance().Insert(movimiento, uow);
                    uow.Commit();
                    LoggerHelper.RegistrarOperacionGenerica("ACTUALIZACIÓN DE STOCK", item);
                    if(item.StockActual < item.StockMinimo)
                    {
                        NotificarBajoStock(item);
                    }
                }
                catch (Exception ex)
                {
                    uow.Rollback();
                    throw;
                }
            }
        }

        public bool VerificarStock(Insumo insumo, int cantidad)
        {
            try
            {
                ValidationHelper.NotNull(insumo, nameof(insumo));
                ValidationHelper.NotEmptyGuid(insumo.IdInsumo, nameof(insumo.IdInsumo));
                ValidationHelper.PositiveValue(cantidad, nameof(cantidad));
                int insumoDisponible = Repository.GetInsumoInstance().GetById(insumo.IdInsumo).StockActual;
                return insumoDisponible >= cantidad;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void NotificarBajoStock(Insumo insumo)
        {
            try
            {
                List<Usuario> usuariosAutorizados = UsuarioService.Current.GetByPatente("RECIBIR_ALERTAS_STOCK");
                string asunto = $"ALERTA CRÍTICA DE STOCK: {insumo.Descripcion}";
                StringBuilder cuerpo = new StringBuilder();
                cuerpo.AppendLine("--- Alerta Automática de Inventario ---");
                cuerpo.AppendLine($"El stock del insumo {insumo.Descripcion} ha caído por debajo del nivel mínimo.");
                cuerpo.AppendLine(new string('-', 30));
                cuerpo.AppendLine($"Stock Actual: {insumo.StockActual}");
                cuerpo.AppendLine($"Stock Mínimo Requerido: {insumo.StockMinimo}");
                cuerpo.AppendLine($"Acción Recomendada: Iniciar proceso de Compra/Reposición.");

                foreach (var usuario in usuariosAutorizados.Where(u => !string.IsNullOrEmpty(u.CorreoElectronico)))
                {
                    EmailService.EnviarEmail(usuario.CorreoElectronico, asunto, cuerpo.ToString());
                }

                LoggerHelper.RegistrarAlerta(cuerpo.ToString());
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public string ConsultarStock(Insumo insumo)
        {
            try
            {
                if(insumo == null)
                {
                    throw new Exception("Seleccione un insumo para consultar el stock");
                }
                int stockActual = insumo.StockActual;
                int stockMinimo = insumo.StockMinimo;
                if(stockActual > stockMinimo)
                {
                    int diferencia = stockActual - stockMinimo;
                    return $"HAY STOCK DEL INSUMO {insumo.Descripcion}\n STOCK ACTUAL: {stockActual}\n STOCK MINIMO: {stockMinimo}\n RESTANTE PARA LLEGAR AL MINIMO: {diferencia}";
                }
                else
                {
                    return $"BAJO STOCK DEL INSUMO {insumo.Descripcion} - Se llegó el límite mínimo de stock. Se recomienda realizar la reposición del mismo.\n STOCK ACTUAL: {stockActual}\n STOCK MÍNIMO: {stockMinimo}";
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
