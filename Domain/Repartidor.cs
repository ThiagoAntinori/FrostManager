using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Repartidor
    {
        public Guid IdRepartidor { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public bool Activo { get; set; }

        public override string ToString() => $"{Nombre} {Apellido}";
    }
}
