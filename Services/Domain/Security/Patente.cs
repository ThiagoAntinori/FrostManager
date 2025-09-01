using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security
{
    public class Patente : Componente
    {
        public string MenuItemName { get; set; }
        public string FormName { get; set; }
        public override void Agregar(Componente componente)
        {
            throw new Exception("No se pueden agregar elementos sobre primitivos");
        }

        public override int ChildrenCount()
        {
            return 0;
        }

        public override void Quitar(Componente componente)
        {
            throw new Exception("No se pueden quitar elementos sobre primitivos");
        }
    }
}
