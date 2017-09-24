using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAnalisis2.Interface;

namespace ProyectoAnalisis2
{
    public class Precios : Visitor
    {
        private static int sindescuento = 50;
        private static int condescuento = 25;
        

        public int visit(Descuento s)
        {
            return s.getcantidad() + condescuento;
        }

        public int visit(Normal t)
        {
            return t.getcantidad() + sindescuento;
        }
    }
}
