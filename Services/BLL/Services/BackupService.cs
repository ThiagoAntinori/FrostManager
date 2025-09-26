using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.BLL.Services
{
    public class BackupService
    {

        private readonly static BackupService _instance = new BackupService();

        public static BackupService Current
        {
            get
            {
                return _instance;
            }
        }

        private BackupService()
        {
            // Implement here the initialization of your singleton
        }

        public void HacerBackup(string rutaArchivo, string connectionString)
        {
            try
            {
                string nombreDatabase;
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    nombreDatabase = conn.Database;
                }
                string query = $@"BACKUP DATABASE [{nombreDatabase}]
                                TO DISK = @Ruta
                                WITH FORMAT, INIT, NAME = 'Backup_{nombreDatabase}', SKIP, NOREWIND, NOUNLOAD, STATS = 10;";

                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    using(SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Ruta", rutaArchivo);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionExtension.Handle(ex);
            }
        }
    }
}
