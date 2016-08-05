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
    public partial class ConsultaVisor : Form
    {

        int idpaciente;
        bool fechasValidas;
        consulta c;
        ControladorConsulta controladorConsulta;
        List<consulta> consultas;


        public ConsultaVisor(int idpaciente)
        {
            InitializeComponent();

            this.idpaciente = idpaciente;
            fechasValidas = true;
            c = new consulta();
            controladorConsulta = new ControladorConsulta();
            consultas = new List<consulta>();
            consultas = controladorConsulta.retornarRegistros(idpaciente);//lista que guarda las consulta del paciente
           

            dataGridView1.ColumnCount = 1;
            dataGridView1.Columns[0].DataPropertyName = "sintoma";
            dataGridView1.Columns[0].Width = 600;
            dataGridView1.AutoGenerateColumns = false;

           
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].DataPropertyName = "nombre";
            dataGridView2.Columns[0].Width = 600;
            dataGridView2.AutoGenerateColumns = false;

            radioButton1_CheckedChanged(null, null);

        }

        private void ConsultaVisor_Load(object sender, EventArgs e)
        {
            Model model = new Model();

            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;

        }

        private void llenarComboFecha() {

            for (int i = consultas.Count -1; i >= 0 ; i--)
            {
                cmbFecha.Items.Add(consultas.ElementAt(i).fecha);
            }

            cmbFecha.SelectedIndex = 0;
           
        
        }

        private void llenarComboFecha(List<consulta> consultaRango)
        {
            
            cmbFecha.Items.Clear();
            cmbFecha.Text = "";
            foreach (var item in consultaRango)
            {
                cmbFecha.Items.Add(item.fecha);
            }
            try { cmbFecha.SelectedIndex = 0; }
            catch (Exception) { }
          


        }

        private void llenarTodo() {

            dataGridView1.DataSource = tablaSintomas();
            dataGridView1.ClearSelection();
            dataGridView2.DataSource = tablaDiagnostico();
            dataGridView2.ClearSelection();

            richTextBox1.Rtf = c.observaciones;
            consultaNombre.Text = controladorConsulta.retornarPaciente(c.idpaciente);
            consultaMedico.Text = controladorConsulta.retornarMedico(c.idmedico);
            
        
        }

        //funcion que crea la tabla de sintomas
        private DataTable tablaSintomas() {
            DataTable sintomas = new DataTable();
            sintomas.Columns.Add("sintoma");

            List<sintomas> listaSintomas = new List<sintomas>();

            foreach (var item in controladorConsulta.retornarSintomas(c.idconsulta))
            {
                sintomas.Rows.Add(item.sintoma);
            }

            return sintomas;

        
        }
        //funcion que crea la tabla de diagnostico
        private DataTable tablaDiagnostico()
        {
            DataTable diagnostico = new DataTable();
            diagnostico.Columns.Add("nombre");



            List<sintomas> listaSintomas = new List<sintomas>();

            foreach (var item in controladorConsulta.retornarDiagnostico(c.idconsulta))
            {
                diagnostico.Rows.Add(item.nombre);
            }

            return diagnostico;


        }

        private void cmbFecha_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void cmbFecha_SelectedValueChanged(object sender, EventArgs e)
        {
           
            DateTime fecha = DateTime.Parse(cmbFecha.SelectedItem.ToString());
            c = consultas.Single(a => a.fecha.Hour == fecha.Hour && a.fecha.Minute == fecha.Minute && a.fecha.Second == fecha.Second);
           
            llenarTodo();
           
        }

        private void ConsultaVisor_Enter(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { cmbFecha.SelectedIndex++; }catch(Exception){}
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { cmbFecha.SelectedIndex--; }
            catch (Exception) { }
        }

        private void ConsultaVisor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmbFecha.Items.Clear();
            if (radioButton1.Checked)
            {
                if (consultas.Count > 10)
                {
                    for (int i = 10; i > 0; i--)
                    {
                        cmbFecha.Items.Add(consultas.ElementAt(i).fecha);

                    }
                    cmbFecha.SelectedIndex = 0;
                }
                else {
                    llenarComboFecha();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            verificarFechas();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            fechasValidas = true;
            errorProvider1.Dispose();
            if (dateTimePicker1.Value > DateTime.Now || dateTimePicker1.Value > dateTimePicker2.Value)
            {
                errorProvider1.SetError(dateTimePicker1, "fecha no válida");
                fechasValidas = false;
            }
            verificarFechas();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            fechasValidas = true;
            errorProvider1.Dispose();
            if (dateTimePicker2.Value > DateTime.Now || dateTimePicker1.Value > dateTimePicker2.Value)
            {
                errorProvider1.SetError(dateTimePicker2, "fecha no válida");
                fechasValidas = false;
            }
            verificarFechas();
        }

        private void verificarFechas() {
            if (fechasValidas) {

                List<consulta> consultaRango = new List<consulta>();
                consultaRango = consultas.Where(a=> a.fecha >= dateTimePicker1.Value.Date && a.fecha <= dateTimePicker2.Value ).ToList();
                
                llenarComboFecha(consultaRango);
            }
        
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
