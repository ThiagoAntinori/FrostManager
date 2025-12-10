using Microsoft.EntityFrameworkCore.Metadata;
using Services.Domain.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Services.BLL.Extensions;
using Services.Domain.Logging;
using Services.BLL.Services;
using Domain;

namespace BLL.Tools
{
    public static class LoggerHelper
    {
        public static void RegistrarAlta(object entidad)
        {
            try
            {
                LogEntry registroAlta = new LogEntry(DateTime.Now, LogLevel.Information, FormatearMensaje("ALTA", entidad));
                LoggerService.GetLogger().WriteLog(registroAlta);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public static void RegistrarBaja(object entidad)
        {
            try
            {
                LogEntry registroBaja = new LogEntry(DateTime.Now, LogLevel.Information, FormatearMensaje("BAJA", entidad));
                LoggerService.GetLogger().WriteLog(registroBaja);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public static void RegistrarModificacion(object entidad)
        {
            try
            {
                LogEntry registroModificacion = new LogEntry(DateTime.Now, LogLevel.Information, FormatearMensaje("ALTA", entidad));
                LoggerService.GetLogger().WriteLog(registroModificacion);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public static void RegistrarOperacionGenerica(string operacion, object entidad)
        {
            try
            {
                LogEntry registroGenerico = new LogEntry(DateTime.Now, LogLevel.Information, FormatearMensaje(operacion, entidad));
                LoggerService.GetLogger().WriteLog(registroGenerico);
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }

        public static void RegistrarAlerta(string mensaje)
        {
            try
            {
                LogEntry registroAlerta = new LogEntry(DateTime.Now, LogLevel.Warning, mensaje);
                LoggerService.GetLogger().WriteLog(registroAlerta);
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        private static string FormatearMensaje(string operacion, object entidad)
        {
            return $"{operacion} de {entidad.GetType().Name} (ID: {ObtenerId(entidad)}) por el usuario {UsuarioLogueado.Current.Usuario.Nombre}";
        }

        private static string ObtenerId(object entidad)
        {
            var prop = entidad.GetType().GetProperties()
                .FirstOrDefault(p => p.Name.StartsWith("Id"));

            if (prop != null)
            {
                var valor = prop.GetValue(entidad);
                return valor == null ? "Sin ID" : valor.ToString();
            }

            return "Sin ID";
        }


    }
}
