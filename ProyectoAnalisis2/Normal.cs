using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoAnalisis2.Interface
{

    public class Normal : Visitable
    {
        private int dias;

        public int Aceptar(Visitor v)
        {
            return v.visit(this);
        }

        public int getcantidad()
        {
            return dias;
        }

        public void setcantidad(int cantidad)
        {
            this.dias = cantidad;
        }

        public void GetObjectData(Visitable vi)
        {
            throw new NotImplementedException();
        }
    }
}
