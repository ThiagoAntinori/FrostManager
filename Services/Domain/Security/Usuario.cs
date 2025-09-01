using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security
{
    public class Usuario
    { 
        public Guid IdUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public bool EstaHabilitado { get; set; }
        public List<Familia> Familias { get; set; } = new List<Familia>();
        public List<Patente> Patentes { get; set; } = new List<Patente>();

        public List<Patente> GetAllPatentes()
        {
            List<Patente> patentesUsuario = new List<Patente>();
            foreach(var familia in Familias)
            {
                patentesUsuario.AddRange(familia.GetPatentes());
            }
            patentesUsuario.AddRange(Patentes);
            return patentesUsuario;
        }
    }
}
