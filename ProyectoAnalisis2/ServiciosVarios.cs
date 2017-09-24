using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAnalisis2.Interface;

namespace ProyectoAnalisis2
{
    public partial class ServiciosVarios : Form
    {
        Descuento sub = new Descuento();
        public int val1=0;

        public ServiciosVarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            val1 = Convert.ToInt32(di.Text) * Convert.ToInt32(pre.Text) * Convert.ToInt32(ca.Text);
            
            if (Convert.ToInt32(di.Text) >= 3)
            {
                MessageBox.Show("El Cliente tiene descuento");
                Descuento sub = new Descuento();
                sub.setcantidad(val1);

                Normal t = new Normal();
                t.setcantidad(val1);

                Precios p = new Precios();
                int t1 = sub.Aceptar(p);
                int t2 = t.Aceptar(p);

                con.Text = Convert.ToString(t1);
                sin.Text = Convert.ToString(t2);
            }
            else {
                MessageBox.Show("El Cliente NO tiene descuento");
                Normal t = new Normal();
                t.setcantidad(val1);

                Precios p = new Precios();
                int t2 = t.Aceptar(p);

                sin.Text = Convert.ToString(t2);
                con.Text = "";
                con.Enabled = false;
            }
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
