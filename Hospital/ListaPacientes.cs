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
    public partial class ListaPacientes : Form
    {

        private static ListaPacientes defInstance;

        public static ListaPacientes DefInstance
        {
            get { return ListaPacientes.defInstance; }
            set { ListaPacientes.defInstance = value; }
        }


        private ControladorPacientes controladorpaciente;
        public ListaPacientes()
        {
            InitializeComponent();

            radioButton1.Checked = true;
 controladorpaciente = new ControladorPacientes();

        
            crearLista();
            dataGridView1.AutoGenerateColumns = false;
          



        }
        private void crearLista()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.pacientes.Select(a => new
            {
                a.idpaciente,
                a.nombres,
                a.apellidos,
                a.genero,
                a.direccion,
                a.departamentos.nombredepartamento,
                a.municipios.nombremunicipio,
                a.telefono,
                a.dui,
                a.nombreencargado,
                a.apellidoencargado,
                a.telefono_encargado,
                a.duiencargado
              
            }).ToList();

            dataGridView1.DataSource = datos;
        }

        private void buscarporapellido()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.pacientes.Select(a => new
            {
                a.idpaciente,
                a.nombres,
                a.apellidos,
                a.genero,
                a.direccion,
                a.departamentos.nombredepartamento,
                a.municipios.nombremunicipio,
                a.telefono,
                a.dui,
                a.nombreencargado,
                a.apellidoencargado,
                a.telefono_encargado,
                a.duiencargado
            }).Where(a => a.apellidos.Contains(textBox1.Text)).ToList();
            dataGridView1.DataSource = datos;
        }



        private void buscarporDUI()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.pacientes.Select(a => new
            {
                a.idpaciente,
                a.nombres,
                a.apellidos,
                a.genero,
                a.direccion,
                a.departamentos.nombredepartamento,
                a.municipios.nombremunicipio,
                a.telefono,
                a.dui,
                a.nombreencargado,
                a.apellidoencargado,
                a.telefono_encargado,
                a.duiencargado
            }).Where(a => a.dui.Contains(textBox1.Text)).ToList();
            dataGridView1.DataSource = datos;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            


            if (radioButton1.Checked)
            {
                buscarporDUI();
                
            }
            else
            {
                buscarporapellido();
                
            }

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistroPacientes rp = new RegistroPacientes(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), 1);
   
            rp.Owner = this;
            rp.MdiParent = this.MdiParent;

            rp.Show();
        }

        private void ListaPacientes_Enter(object sender, EventArgs e)
        {
            crearLista();
        }

        private void ListaPacientes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (controladorpaciente.eliminarPaciente(id))
                    MessageBox.Show("Registro eliminado satisfactoriamente");
                else
                    MessageBox.Show("Ocurrio un error al eliminar registro");
                crearLista();



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta(dataGridView1.CurrentRow);
            c.MdiParent = this.MdiParent;
            c.Show();
        } 

        private void button5_Click(object sender, EventArgs e)
        {
            ConsultaVisor cv = new ConsultaVisor(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            cv.MdiParent = this.MdiParent;
            cv.Show();
        }

        private void ListaPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            defInstance = null;
        }


    }



}
