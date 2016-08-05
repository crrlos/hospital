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

namespace Hospital
{
    public partial class buscarSintomas : Form
    {
        ControladorSintomas controladorSintomas = new ControladorSintomas();

        sintomas sintoma = new sintomas();

        public sintomas Sintoma
        {
            get { return sintoma; }
            set { sintoma = value; }
        }




       
        public buscarSintomas()
        {
            InitializeComponent();

           

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "Síntoma";

            dataGridView1.Columns[0].DataPropertyName = "idsintoma";
            dataGridView1.Columns[1].DataPropertyName = "sintoma";

            dataGridView1.Columns[0].Width = 25;
            dataGridView1.Columns[1].Width = 400;

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = controladorSintomas.ListarSintomas();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorSintomas.ListarSintomas(textBox1.Text);
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

        private void devolver() {

            if (!(dataGridView1.SelectedRows.Count == 0))
            {

                Sintoma.idsintoma = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                Sintoma.sintoma = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                MessageBox.Show("No ha seleccionado nada");
            }
        
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
