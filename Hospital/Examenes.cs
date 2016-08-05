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
    public partial class Examenes : Form
    {
        public Examenes()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Seleccionar_EncargadosLab sel = new Seleccionar_EncargadosLab();
            sel.Show();
        }
    }
}
