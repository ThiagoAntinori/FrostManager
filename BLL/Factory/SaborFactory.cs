using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Factory
{
    public class SaborFactory : InsumoFactory
    {
        public override Insumo CrearInsumo()
        {
            return new Sabor();
        }
    }
}
