using Services.BLL.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

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
                    smtp.EnableSsl = true; // Usa TLS

                    var mail = new MailMessage(user, destinatario, asunto, cuerpo);
                    smtp.Send(mail);
                }
            }
			catch (Exception ex)
			{
				ExceptionExtension.Handle(ex);
			}
        }
    }
}
