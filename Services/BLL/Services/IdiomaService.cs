using Services.BLL.Contracts;
using Services.BLL.Extensions;
using Services.DAL.Implementations;
using Services.Domain.Exceptions;
using Services.Domain.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public sealed class IdiomaService
    {

        private readonly static IdiomaService _instance = new IdiomaService();

        public static IdiomaService Current
        {
            get
            {
                return _instance;
            }
        }

        private IdiomaService()
        {
            // Implement here the initialization of your singleton
        }

        private readonly List<ITraducible> suscriptores = new List<ITraducible>();

        public void Suscribir(ITraducible suscriptor)
        {
            if (!suscriptores.Contains(suscriptor))
            {
                suscriptores.Add(suscriptor);
            }
        }

        public void Desuscribir(ITraducible suscriptor)
        {
            if (suscriptores.Contains(suscriptor))
            {
                suscriptores.Remove(suscriptor);
            }
        }

        public string Traducir(string word)
        {
            try
            {
                return IdiomaRepository.Current.Traducir(word);
            }
            catch (WordNotFoundException ex)
            {
                IdiomaRepository.Current.AgregarDataKey(word);
                LoggerService.GetLogger().WriteLog(new LogEntry(DateTime.Now, LogLevel.Error, $"No se encontró una palabra buscada ({word})", ex));

                return null;
            }
        }

        public void CambiarIdioma(string cultura)
        {
            try
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo(cultura);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(cultura);

                foreach(var traducible in suscriptores)
                {
                    traducible.CambiarIdioma();
                }
            }
            catch(WordNotFoundException wordNotFoundEx)
            {
                CambiarIdioma(cultura);
                ExceptionExtension.Handle(wordNotFoundEx);
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
