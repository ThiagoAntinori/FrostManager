using Microsoft.IdentityModel.Tokens;
using Services.BLL.Extensions;
using Services.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.DAL.Implementations
{
    public class IdiomaRepository
    {

        private readonly static IdiomaRepository _instance = new IdiomaRepository();

        public static IdiomaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private IdiomaRepository()
        {
            // Implement here the initialization of your singleton
        }

        private static string folderPath = ConfigurationManager.AppSettings["IdiomaFolderPath"];
        private static string fileName = ConfigurationManager.AppSettings["IdiomaFileName"];
        private static string path = default;

        static IdiomaRepository()
        {
            path = Path.Combine(folderPath, fileName);
        }

        public string Traducir(string word)
        {
            try
            {
                string cultura = Thread.CurrentThread.CurrentCulture.Name;

                string localPath = $"{path}.{cultura}";

                using(StreamReader sr = new StreamReader(localPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] strings = line.Split("=");
                        string key = strings[0];
                        string value = strings[1];

                        if(key.ToLower() == word.ToLower())
                        {
                            return value;
                        }
                    }
                }
                throw new WordNotFoundException();
            }
            catch(WordNotFoundException wordNotFound)
            {
                AgregarDataKey(word);
                throw;
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
                throw;
            }
        }

        public void AgregarDataKey(string key)
        {
            try
            {
                string cultura = Thread.CurrentThread.CurrentCulture.Name;

                string localPath = $"{path}.{cultura}";

                using(StreamWriter sw = new StreamWriter(localPath, true))
                {
                    sw.WriteLine($"{key.ToLower()}=NOT_FOUND");
                }
            }
            catch(Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
