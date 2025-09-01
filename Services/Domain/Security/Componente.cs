using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security
{
    public abstract class Componente
    {
        public Guid IdComponente { get; set; }
        public string Nombre { get; set; }
        public abstract void Agregar(Componente componente);
        public abstract void Quitar(Componente componente);
        public abstract int ChildrenCount();
    }
}
