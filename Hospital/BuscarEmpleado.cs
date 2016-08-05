using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Controladores;
using Hospital.Modelo;
using Hospital.Conexion;

namespace Hospital
{
    public partial class BuscarEmpleado : Form
    {
        private ControladorEmpleado controladorEmpleado;

        public BuscarEmpleado()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            controladorEmpleado = new ControladorEmpleado();

           
            crearLista();
            
            dataGridView1.AutoGenerateColumns = false;

        }

        private void crearLista()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.empleados.Select(a => new
            {
                a.idempleado,
                a.nombres,
               a.apellidos,
               a.cargos.nombre_cargo,
                a.direccion,
                 a.departamentos.nombredepartamento,
                a.municipios.nombremunicipio,
                 a.dui,
                a.NIT,
                a.estado
            }).Where(a => a.estado.Equals("ACTIVO")).ToList();
            dataGridView1.DataSource = datos;
            dataGridView1.Columns[8].Width = 150;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Model model = new Model();
            

            if (radioButton1.Checked)
            {
               
                buscarpordui();
            }
          else if(radioButton2.Checked)
            {
               
                buscarporapellidos();
            }

            else if (radioButton3.Checked)
            {
                
                buscarporcargo();
            }
          

           
        }
        private void buscarporapellidos()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.empleados.Select(a => new
            {
                a.idempleado,
                 a.nombres,
                 a.apellidos,
               a.cargos.nombre_cargo,
                 a.direccion,
                 a.departamentos.nombredepartamento,
               a.municipios.nombremunicipio,
                a.dui,
                a.NIT
            }).Where(a=> a.apellidos.Contains(textBox1.Text) ).ToList();

            dataGridView1.DataSource = datos;
        }
        private void buscarporcargo()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.empleados.Select(a => new
            {
               a.idempleado,
                 a.nombres,
                 a.apellidos,
                a.cargos.nombre_cargo,
                 a.direccion,
               a.departamentos.nombredepartamento,
                 a.municipios.nombremunicipio,
              a.dui,
               a.NIT
            }).Where(a => a.nombre_cargo.Contains(textBox1.Text)).ToList();

            dataGridView1.DataSource = datos;
        }

        private void buscarpordui()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.empleados.Select(a => new
            {
               a.idempleado,
                a.nombres,
                 a.apellidos,
               a.cargos.nombre_cargo,
                 a.direccion,
                 a.departamentos.nombredepartamento,
                a.municipios.nombremunicipio,
                 a.dui,
                a.NIT
            }).Where(a => a.dui.Contains(textBox1.Text)).ToList();

            dataGridView1.DataSource = datos;
        }




        private void button1_Click(object sender, EventArgs e)
        {
           
            if (dataGridView1.Rows.Count!=0)
            { 
            Empleados emp = new Empleados(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()),3);
            
            emp.Owner = this;
            emp.MdiParent = this.MdiParent; 
            emp.Show();
        }
          
            
        }

        private void BuscarEmpleado_Enter(object sender, EventArgs e)
        {
            crearLista();
        }

        private void BuscarEmpleado_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    if (controladorEmpleado.eliminarEmpleado(id))
                        MessageBox.Show("Registro eliminado satisfactoriamente");
                    else
                        MessageBox.Show("Ocurrio un error al eliminar registro");
                    crearLista();


                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
          
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        
       
    }
}
