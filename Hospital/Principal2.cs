using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class Principal2 : Form
    {
        public Principal2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Roles r = new Roles();
            r.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Empleados er = new Empleados();
            er.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
             RegistroPacientes r = new RegistroPacientes();
            r.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RegistroPacientes rp = new RegistroPacientes();
            rp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Roles r = new Roles();
            r.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Enfermedades en = new Enfermedades();
            en.Show();
        }
        
    }
}
