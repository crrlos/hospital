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
    public partial class Fallecidos : Form
    {
        public Fallecidos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SeleccionarPacientes sp = new SeleccionarPacientes();
            sp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SeleccionarEnfermedades se = new SeleccionarEnfermedades();
            se.Show();
        }
    }
}
