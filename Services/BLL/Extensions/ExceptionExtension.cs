using Services.BLL.Services;
using Services.Domain.Logging;
using Services.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Extensions
{
    public static class ExceptionExtension
    {
        public static void Handle(this Exception ex)
        {
            var stackTrace = new StackTrace(ex, true);

            for (int i = 0; i < stackTrace.FrameCount; i++)
            {
                var frame = stackTrace.GetFrame(i);
                var method = frame.GetMethod();
                var declaringType = method?.DeclaringType;
                var assemblyName = declaringType?.Assembly.GetName().Name;

                if (assemblyName != null)
                {
                    switch (assemblyName)
                    {
                        case "UI":
                            HandleUIException(ex);
                            return;
                        case "BLL":
                            HandleBLLException(ex);
                            return;
                        case "DAL":
                            HandleDALException(ex);
                            return;
                        case "Services":
                            HandleServiceException(ex);
                            return;
                        default:
                            continue;
                    }
                }
            }
            DefaultHandler(ex);
        }

        private static void HandleUIException(Exception ex)
        {
            try
            {
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Error, "Error en la interfaz del sistema - Mensaje: " + ex.Message, ex));
                
            }
            catch(Exception exception)
            {
                
            }
        }

        private static void HandleBLLException(Exception ex)
        {
            try
            {
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Error, "[BLL Exception] Error en la lógica de negocio - Mensaje: " + ex.Message, ex));
                BusinessException bllException = null;
                if(ex is DataAccessException)
                {
                    bllException = new BusinessException("Ocurrió un error al intentar acceder a los datos", ex);
                }
                else
                {
                    bllException = new BusinessException("Ocurrió un error en la lógica de negocio - Detalle: " + ex.Message, ex);
                }
            }
            catch(Exception exception)
            {
                throw;
            }
        }

        private static void HandleDALException(Exception ex)
        {
            try
            {
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Error, "[DAL Exception] Error de acceso a datos - Mensaje: " + ex.Message, ex));
                DataAccessException dalException = new DataAccessException("Ocurrió un error en la base de datos", ex);
                throw dalException;
            }
            catch(Exception exception)
            {
                throw;
            }

        }

        private static void HandleServiceException(Exception ex)
        {
            try
            {
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Error, "[Service Exception] Error en la configuración de sistema - Mensaje: " + ex.Message));
                throw new Exception("Ocurrió un error en la configuración del sistema - " + ex.Message, ex);
            }
            catch (Exception exception)
            {
                throw;
            }
        }

        private static void DefaultHandler(Exception ex)
        {
            try
            {
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Error, "[GENERAL EXCEPTION] Error de sistema - Mensaje: " + ex.Message, ex));
                throw new Exception(ex.Message, ex);
            }
            catch(Exception exception)
            {
                throw;
            }
        }
    }
}
