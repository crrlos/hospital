using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Conexion;
using Hospital.Controladores;
using Hospital.Modelo;

namespace Hospital
{
    public partial class pruebagrid : Form
    {

        List<enfermedades> listaenfermedades;
        List<sintomas> listasintomas;

        public pruebagrid()
        {
            listaenfermedades = new List<enfermedades>();
            listasintomas = new List<sintomas>();

           
            
            InitializeComponent();
            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].DataPropertyName = "sintoma";
            dataGridView1.Columns[0].Name = "nombre";
            dataGridView1.AutoGenerateColumns = false;
           



            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].DataPropertyName = "nombre";
            dataGridView2.Columns[0].Name = "nombre";
            dataGridView2.AutoGenerateColumns = false;
           

        }

        private void pruebagrid_Load(object sender, EventArgs e)
        {



        }

        private void cargar() {

            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = tablaSintomas(listasintomas);
            dataGridView2.DataSource = tablaEnfermedades(listaenfermedades);
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buscarSintomas bs = new buscarSintomas();
            bs.ShowDialog();

            if (bs.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                sintomas s = new sintomas();
                s.idsintoma = bs.Sintoma.idsintoma;
                s.sintoma = bs.Sintoma.sintoma;
                listasintomas.Add(s);
                
            }
            cargar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buscarEnfermedades bs = new buscarEnfermedades();
            bs.ShowDialog();

            if (bs.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
               enfermedades s = new enfermedades();
               s.idenfermedad = bs.Enfermedad.idenfermedad;
                s.nombre = bs.Enfermedad.nombre;
                s.codigo = bs.Enfermedad.codigo;
                listaenfermedades.Add(s);
              
            }
            cargar();
        }

        private DataTable tablaSintomas(List<sintomas> lista) {

            DataTable sintomas = new DataTable();
            sintomas.Columns.Add("idsintoma",typeof(int));
            sintomas.Columns.Add("sintoma",typeof(string));

            foreach (var item in lista)
            {
                sintomas.Rows.Add(item.idsintoma,item.sintoma);
                
            }

            return sintomas;
        }
        private DataTable tablaEnfermedades(List<enfermedades> enfermedades) {


            DataTable enf = new DataTable();

            enf.Columns.Add("idenfermedad",typeof(int));
            enf.Columns.Add("nombre", typeof(string));
            enf.Columns.Add("codigo", typeof(string));

            foreach (var item in enfermedades)
            {
                enf.Rows.Add(item.idenfermedad, item.nombre, item.codigo);
            }



            return enf;

        }
    }
}
