using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAnalisis2.Interface
{
    public interface Visitor
    {
        int visit(Descuento sub);
        int visit(Normal tot);
    }
}
