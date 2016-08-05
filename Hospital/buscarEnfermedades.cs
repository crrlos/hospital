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
    public partial class buscarEnfermedades : Form
    {
        ControladorEnfermedades controladorEnfermedades;

       

        private enfermedades enfermedad = new enfermedades();

        public enfermedades Enfermedad
        {
            get { return enfermedad; }
            set { enfermedad = value; }
        }




       
        public buscarEnfermedades()
        {
            InitializeComponent();

            controladorEnfermedades = new ControladorEnfermedades();

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nombre";
            dataGridView1.Columns[2].Name = "ID";

            dataGridView1.Columns[0].DataPropertyName = "codigo";
            dataGridView1.Columns[1].DataPropertyName = "nombre";
            dataGridView1.Columns[2].DataPropertyName = "idenfermedad";

           

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 600;
            dataGridView1.Columns[2].Width = 60;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = controladorEnfermedades.ListarEnfermedades();

          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorEnfermedades.ListarEnfermedades(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            devolver();
            

        }

        private void buscarEnfermedades_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            devolver();
        }

        private void  devolver(){

            if (!(dataGridView1.SelectedRows.Count == 0))
            {
                Enfermedad.codigo = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                Enfermedad.nombre = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                Enfermedad.idenfermedad = int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                DialogResult = DialogResult.OK;
                this.Close();

            }
            else { MessageBox.Show("no ha seleccionado nada");}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
