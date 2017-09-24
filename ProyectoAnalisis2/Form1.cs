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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((usuario.Text == "administrador@correo.com") && (contrasenia.Text == "administrador"))
            {
                MessageBox.Show("Se registro como administrador");
                Principal p = new Principal();
                p.Show();
            }
            else
            {
                if ((usuario.Text == "cliente@correo.com") && (contrasenia.Text == "cliente"))
                {
                    MessageBox.Show("Se registro como cliente");
                    Principal p = new Principal();
                    p.Show();

                } else {
                    if ((usuario.Text == "empleado@correo.com") && (contrasenia.Text == "empleado"))
                    {
                        MessageBox.Show("Se registro como empleado");
                        Principal p = new Principal();
                        p.Show();

                    }
                    else {
                        MessageBox.Show("El usuario no existe");
                    }
                  }
            
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RegistroAmbos ra = new RegistroAmbos();
            ra.Show();
        }
    }
}
