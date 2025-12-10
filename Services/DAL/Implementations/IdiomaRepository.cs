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

                using (StreamReader sr = new StreamReader(localPath))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] strings = line.Split("=");
                        string key = strings[0];
                        string value = strings[1];

                        if (key.ToLower() == word.ToLower())
                        {
                            return value;
                        }
                    }
                }
                throw new WordNotFoundException();
            }
            catch (WordNotFoundException wordNotFound)
            {
                AgregarDataKey(word);
                throw;
            }
            catch (Exception ex)
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

                bool keyExists = false;
                if (File.Exists(localPath))
                {
                    string[] lines = File.ReadAllLines(localPath);
                    foreach (string line in lines)
                    {
                        if (line.StartsWith(key.ToLower() + "="))
                        {
                            keyExists = true;
                            break;
                        }
                    }
                }

                if (!keyExists)
                {
                    using (StreamWriter sw = new StreamWriter(localPath, true))
                    {
                        sw.WriteLine($"{key.ToLower()}=NOT_FOUND");
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public List<string> ObtenerCodigosDeCulturaDisponibles()
        {
            try
            {
                List<string> codigos = new List<string>();
                if (string.IsNullOrEmpty(folderPath) || !Directory.Exists(folderPath))
                {
                    return new List<string>
                    {
                        Thread.CurrentThread.CurrentCulture.Name
                    };
                }

                string filePattern = $"{fileName}.*.resx";
                string[] archivos = Directory.GetFiles(folderPath, $"{fileName}.*");

                foreach (string archivo in archivos)
                {
                    string nombreArchivoCompleto = Path.GetFileName(archivo);

                    if (nombreArchivoCompleto.Contains("."))
                    {
                        int lastDotIndex = nombreArchivoCompleto.LastIndexOf('.');
                        string codigoCultura = nombreArchivoCompleto.Substring(lastDotIndex + 1);
                        codigos.Add(codigoCultura);
                    }
                }

                return codigos.Distinct().ToList();
            }
            catch (Exception ex)
            {
                ex.Handle();
                throw;
            }
        }
    }
}
