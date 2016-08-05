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
using Hospital.Conexion;

namespace Hospital
{
    public partial class Analizar : Form
    {
        
            Model model = new Model();
            List<consulta> consultas;


            List<sintomas> sin= new List<sintomas>();
        public Analizar()
        {
            InitializeComponent();
            new List<consulta>();
            consultas = model.Entidades.consulta.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {


           

            foreach (var item in consultas)
	            {


		 
	                }

            
           






        }

        private void comprobar() { 
        
        }

    }
}
