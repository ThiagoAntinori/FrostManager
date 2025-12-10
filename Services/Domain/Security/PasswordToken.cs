using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security
{
    public class PasswordToken
    {
        public Guid IdToken { get; set; }
        public string Token { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public PasswordToken(Guid idToken, string token, Usuario usuario, DateTime fechaVencimiento)
        {
            this.IdToken = idToken;
            this.Token = token;
            this.Usuario = usuario;
            this.FechaVencimiento = fechaVencimiento;
        }

        public PasswordToken()
        {

        }
    }
}
