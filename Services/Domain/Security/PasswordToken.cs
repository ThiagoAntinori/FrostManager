using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security
{
    public class PasswordToken
    {
        public string Token { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime FechaVencimiento { get; set; }

        public PasswordToken(string token, Usuario usuario, DateTime fechaVencimiento)
        {
            this.Token = token;
            this.Usuario = usuario;
            this.FechaVencimiento = fechaVencimiento;
        }

        public PasswordToken()
        {

        }
    }
}
