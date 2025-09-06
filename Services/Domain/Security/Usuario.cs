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
        public string Nombre { get; set; }
        public string CorreoElectronico { get; set; }
        public string Password { get; set; }
        public bool EstaHabilitado { get; set; }
        public List<Componente> Privilegios { get; set; } = new List<Componente>();

        public List<Patente> GetAllPatentes()
        {
            List<Patente> patentesUsuario = new List<Patente>();
            RecorrerFamilias(patentesUsuario, this.Privilegios);
            return patentesUsuario;
        }

        private void RecorrerFamilias(List<Patente> patentes, List<Componente> privilegios)
        {
            foreach(var componente in privilegios)
            {
                if(componente is Patente patente)
                {
                    if(!patentes.Exists(p => p.IdComponente == patente.IdComponente))
                    {
                        patentes.Add(patente);
                    }
                }
                else if(componente is Familia familia)
                {
                    RecorrerFamilias(patentes, familia.GetChildren());
                }
            }
        }
    }
}
