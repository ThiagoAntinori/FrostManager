using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Tools
{
    public static class JsonHelper
    {
        private static readonly JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true,
            AllowTrailingCommas = true
        };

        public static List<T> LoadList<T>(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return new List<T>();

                string json = File.ReadAllText(path);
                return JsonSerializer.Deserialize<List<T>>(json, options) ?? new List<T>();
            }
            catch
            {
                return new List<T>();
            }
        }

        public static void SaveList<T>(string path, List<T> data)
        {
            string tempPath = path + ".tmp";

            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(tempPath, json);

            // Reemplazo atómico
            if (File.Exists(path))
                File.Delete(path);

            File.Move(tempPath, path);
        }
    }
}
