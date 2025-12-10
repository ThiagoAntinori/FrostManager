using Microsoft.Data.SqlClient;
using Services.BLL.Extensions;
using Services.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
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

        public void RespaldarBaseDeDatos(string rutaArchivo, string connectionString)
        {
            try
            {
                try
                {
                    string nombreDatabase;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        nombreDatabase = conn.Database;
                    }
                    string tempDirectory = ConfigurationManager.AppSettings["SqlDirectory"];
                    Directory.CreateDirectory(tempDirectory);

                    string tempFile = Path.Combine(tempDirectory, $"Backup_{nombreDatabase}_{DateTime.Now:yyyyMMdd_HHmm}.bak");
                    string query = $@"BACKUP DATABASE [{nombreDatabase}]
                                TO DISK = @Ruta
                                WITH FORMAT, INIT, NAME = 'Backup_{nombreDatabase}', SKIP, NOREWIND, NOUNLOAD, STATS = 10;";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Ruta", tempFile);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    File.Copy(tempFile, rutaArchivo, true);
                }
                catch (Exception ex)
                {
                    throw new BackupException(ex);
                }
            }
            catch (Exception ex)
            {
                ex.Handle();
            }
        }

        public void RestaurarBaseDeDatos(string rutaArchivo, string connectionString)
        {
            try
            {
                try
                {
                    if (!File.Exists(rutaArchivo))
                    {
                        throw new FileNotFoundException("No se encontró el archivo de backup", rutaArchivo);
                    }
                    string tempDirectory = ConfigurationManager.AppSettings["SqlDirectory"];
                    Directory.CreateDirectory(tempDirectory);

                    string tempFile = Path.Combine(tempDirectory, "restoreTemp.bak");
                    File.Copy(rutaArchivo, tempFile, true);
                    string nombreDatabase;
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        nombreDatabase = conn.Database;
                    }

                    string query = $@"ALTER DATABASE [{nombreDatabase}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

                                    RESTORE DATABASE [{nombreDatabase}]
                                    FROM DISK = @BackupPath
                                    WITH REPLACE,
                                    STATS = 5;

                                    ALTER DATABASE [{nombreDatabase}] SET MULTI_USER;";

                    using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MasterConString"].ConnectionString))
                    {
                        conn.Open();

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@BackupPath", tempFile);
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandTimeout = 0;
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new BackupException(ex);
                }
            }
            catch(Exception ex)
            {
                ex.Handle();
            }
        }
    }
}
