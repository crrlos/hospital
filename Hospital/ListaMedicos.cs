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
    public partial class ListaMedicos : Form
    {

        ControladorMedicos controladormedico = new ControladorMedicos();
        ControladorEmpleado controladorempleado = new ControladorEmpleado();

        empleados var = new empleados();
        public empleados Var
        {
            get { return var; }
            set { var = value; }
        }







        public ListaMedicos()
        {
            InitializeComponent();

            controladorempleado.listarEmpleadoMedico(dataGridView1);
            dataGridView1.AutoGenerateColumns = false;

        }


        private void ListaMedicos_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (controladormedico.eliminarMedicos(id))
                    MessageBox.Show("Registro eliminado satisfactoriamente");
                else
                    MessageBox.Show("Ocurrio un error al eliminar registro");

                controladorempleado.listarEmpleadoMedico(dataGridView1);

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
              
                int medi= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());


                int idempl = int.Parse(dataGridView1.CurrentRow.Cells[8].Value.ToString());
                AgregarEmpleadoMedico emp = new AgregarEmpleadoMedico(medi,idempl );

                emp.Owner = this;
                emp.MdiParent = this.MdiParent;
                emp.Show();
               
            }
        }

        private void ListaMedicos_Enter(object sender, EventArgs e)
        {

            controladorempleado.listarEmpleadoMedico(dataGridView1);
        }
    }
}
