using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Domain.Security
{
    public class Familia : Componente
    {
        public List<Componente> children = new List<Componente>();
        public Familia()
        {

        }
        public Familia(string nombre, Componente primerComponente)
        {
            this.Nombre = nombre;
            children.Add(primerComponente);
        }

        public override void Agregar(Componente componente)
        {
            children.Add(componente);
        }

        public override void Quitar(Componente componente)
        {
            children.RemoveAll(c => c.IdComponente == componente.IdComponente);
        }

        public override int ChildrenCount()
        {
            return children.Count();
        }

        public List<Componente> GetChildren()
        {
            return children;
        }

        public List<Patente> GetPatentes()
        {
            List<Patente> patentes = new List<Patente>();
            foreach(var item in children)
            {
                if(item.ChildrenCount() > 0)
                {
                    patentes.AddRange((item as Familia).GetPatentes());
                }
                else if(item.ChildrenCount() == 0)
                {
                    patentes.Add((item as Patente));
                }
            }
            return patentes;
        }
    }
}
