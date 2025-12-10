using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Services.Domain.Logging;

namespace Services.BLL.Services
{
    public static class EmailService
    {
        public static void EnviarEmail(string destinatario, string asunto, string cuerpo)
        {
			try
			{
                using (var smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    string user = ConfigurationManager.AppSettings["SmtpUser"];
                    string password = ConfigurationManager.AppSettings["SmtpPassword"];
                    smtp.Credentials = new NetworkCredential(user, password);
                    smtp.EnableSsl = true;

                    var mail = new MailMessage(user, destinatario, asunto, cuerpo);
                    smtp.Send(mail);
                }
            }
            catch(SmtpException smptEx)
            {
                LoggerService.GetLogger().WriteLog
                    (new LogEntry(DateTime.Now, LogLevel.Error, 
                    $"Error SMTP al enviar el Email con asunto: {asunto} y cuerpo: {cuerpo} para el destinatario {destinatario} \nDetalles del error: {smptEx.Message}"));
            }
			catch (Exception ex)
			{
                LoggerService.GetLogger().WriteLog
                    (new LogEntry(DateTime.Now, LogLevel.Error,
                    $"Error Genérico al enviar el Email con asunto: {asunto} y cuerpo: {cuerpo} para el destinatario {destinatario}"));
            }
        }
    }
}
