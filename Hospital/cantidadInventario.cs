using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Modelo;
using Hospital.Controladores;
using Hospital.Conexion;

namespace Hospital
{
    public partial class cantidadInventario : Form
    {
        private int id;
        private int cantidad;
        private ControladorInventarioMedicamentos controladorinventario;
        public cantidadInventario(int idd)
        {
            InitializeComponent();

            id = idd;
            
            
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {
          /* controladorinventario = new ControladorInventarioMedicamentos();

            cantidad = int.Parse( textBox1.Text);
            if (controladormedicamento.AgregarcantidadMedicamento(id,cantidad))
            {

                MessageBox.Show("good");
               
            }
            */


           
        }
    }
}
