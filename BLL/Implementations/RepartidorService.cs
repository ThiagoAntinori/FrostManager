using BLL.Contracts;
using BLL.Tools;
using DAL.Implementations.Factory;
using DAL.Implementations.SqlServer;
using Domain;
using Services.BLL.Extensions;
using Services.BLL.Services;
using Services.Domain.Exceptions.BusinessExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Implementations
{
    public class RepartidorService : IGenericService<Repartidor>
    {

        private readonly static RepartidorService _instance = new RepartidorService();

        public static RepartidorService Current
        {
            get
            {
                return _instance;
            }
        }

        private RepartidorService()
        {
            // Implement here the initialization of your singleton
        }

        public void Add(Repartidor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdRepartidor, nameof(item.IdRepartidor));
                ValidationHelper.NotEmpty(item.Nombre, nameof(item.Nombre));
                ValidationHelper.NotEmpty(item.Apellido, nameof(item.Apellido));
                ValidationHelper.NotEmpty(item.Email, nameof(item.Email));
                if(!item.Email.Contains('@'))
                {
                    throw new DatosInvalidosException("Email", "Debe contener '@'");
                }

                Repository.GetRepartidorInstance().Insert(item);
                LoggerHelper.RegistrarAlta(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void Delete(Repartidor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdRepartidor, nameof(item.IdRepartidor));

                Repository.GetRepartidorInstance().Delete(item);
                LoggerHelper.RegistrarBaja(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public IEnumerable<Repartidor> SelectAll()
        {
            try
            {
                return Repository.GetRepartidorInstance().GetAll();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public Repartidor SelectOne(Guid id)
        {
            try
            {
                ValidationHelper.NotEmptyGuid(id, nameof(id));
                Repartidor repartidor = Repository.GetRepartidorInstance().GetById(id);
                return repartidor;
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }

        public void Update(Repartidor item)
        {
            try
            {
                ValidationHelper.NotNull(item, nameof(item));
                ValidationHelper.NotEmptyGuid(item.IdRepartidor, nameof(item.IdRepartidor));
                ValidationHelper.NotEmpty(item.Nombre, nameof(item.Nombre));
                ValidationHelper.NotEmpty(item.Apellido, nameof(item.Apellido));
                ValidationHelper.NotEmpty(item.Email, nameof(item.Email));
                if (!item.Email.Contains('@'))
                {
                    throw new DatosInvalidosException("Email", "Debe contener '@'");
                }
                Repository.GetRepartidorInstance().Update(item);
                LoggerHelper.RegistrarModificacion(item);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void NotificarPedidoARepartidor(Pedido pedido)
        {
            try
            {
                ValidationHelper.NotNull(pedido, nameof(pedido));
                ValidationHelper.NotNull(pedido.Repartidor, nameof(pedido.Repartidor));

                StringBuilder cuerpo = new StringBuilder();
                cuerpo.AppendLine("--- Detalle de Nuevo Pedido de Delivery ---");
                cuerpo.AppendLine($"Fecha y Hora: {pedido.Venta.Fecha:dd/MM/yyyy} {pedido.Venta.Hora:hh:mm}");
                cuerpo.AppendLine($"Monto Total: {pedido.Venta.CalcularTotal():C}");
                cuerpo.AppendLine($"Medio de Pago: {pedido.Venta.MedioDePago.ToString()}");
                cuerpo.AppendLine(new string('-', 30));

                cuerpo.AppendLine("Detalles del Cliente:");
                cuerpo.AppendLine($"Nombre: {pedido.Cliente.ToString()}");
                cuerpo.AppendLine($"Dirección de Entrega: {pedido.Cliente.Direccion}");
                cuerpo.AppendLine($"Teléfono: {pedido.Cliente.Telefono}");

                string asunto = $"NUEVO PEDIDO ASOCIADO: Entrega a {pedido.Cliente.ToString()}";

                EmailService.EnviarEmail(pedido.Repartidor.Email, asunto, cuerpo.ToString());
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
