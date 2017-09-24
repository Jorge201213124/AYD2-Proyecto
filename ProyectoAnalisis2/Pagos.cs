using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAnalisis2
{
    public partial class Pagos : Form
    {
        int suma=0;
        int v1=0;
        int v2=0;
        public Pagos()
        {
            InitializeComponent();
            textBox7.Enabled = false;
            v1 = Convert.ToInt32(textBox4.Text);
            v2= Convert.ToInt32(textBox5.Text);
            suma = v1 + v2;
            textBox7.Text = Convert.ToString(suma);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Principal p = new Principal();
            p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea regresar a la pantalla principal?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                Principal p = new Principal();
                p.Show();
            }
            else if (result == DialogResult.No)
            {

            }
            else if (result == DialogResult.Cancel)
            {
            }
        }
    }
}
