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
    public partial class LoteMedicamentos : Form
    {

        private int operacion = 0;
        private int id = 0;
        private ControladorLote controladorlotes;
        public LoteMedicamentos()
        {
            InitializeComponent();
            
         
            controladorlotes = new ControladorLote();
            crearLista();
            dataGridView1.AutoGenerateColumns = false;
            deshabilitar();
            estadobuscarfechca();
        }

        private void estadobuscarfechca() {
            if (radioButton2.Checked == true)
            {
                dateTimePicker1.Visible = true;
            }
            else { dateTimePicker1.Visible = false; }
        }


        private void LoteMedicamentos_Load(object sender, EventArgs e)
        {
           
        }

        private void crearLista()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.Lote_Medicamentos.Select(a => new
            {
                a.idlote,
                a.codigoLote,
                a.fecha_vencimiento

            }).ToList();
            dataGridView1.DataSource = datos;
        }

        private bool validar()
        {
            if (txtCodigo.Text.Length == 0 )
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }
        private void habilitar()
        {
            
            groupBox1.Enabled = true;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;

            dataGridView1.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCerrar.Enabled = false;
            dateTimePicker1.Visible = false;
        }

        private void deshabilitar()
        {

            txtCodigo.Text = "";

            radioButton1.Enabled = true;
            radioButton2.Enabled = true;


            groupBox1.Enabled = false;
            dataGridView1.Enabled = true;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCerrar.Enabled = true;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            operacion = 0;
            habilitar();
       
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                if (operacion == 0)
                {
                    Model model = new Model();
                    Lote_Medicamentos lm = new Lote_Medicamentos();
                    lm.codigoLote = txtCodigo.Text;
                    lm.fecha_vencimiento = dtfecha.Value.Date;


                    if (controladorlotes.insertarLote(lm))
                    {

                        MessageBox.Show("Correcto");
                        crearLista();
                        deshabilitar();
                    }
                  
                }
                else {
                 Model model = new Model();
                    Lote_Medicamentos lm = new Lote_Medicamentos();
                    lm.codigoLote = txtCodigo.Text;
                    lm.fecha_vencimiento = dtfecha.Value.Date;


                    if (controladorlotes.modificarLote(id,lm))
                    {

                        MessageBox.Show("Actualizacion correcta");
                    }
                    crearLista();
                    deshabilitar();
                }
                }

            

            else { 
            
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();


            crearLista();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (controladorlotes.eliminarLote(id))
                    MessageBox.Show("Registro eliminado satisfactoriamente");
                else
                    MessageBox.Show("Ocurrio un error al eliminar registro");

                crearLista();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
            operacion = 1;
            txtCodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtfecha.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
           

            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());  
        }

        private void buscarporCodigo()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.Lote_Medicamentos.Select(a => new
            {
                a.idlote,
               a.codigoLote,
               a.fecha_vencimiento
            }).Where(a => a.codigoLote.Contains(textBox1.Text)).ToList();
            dataGridView1.DataSource = datos;
        }

        private void buscarporFecha()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.Lote_Medicamentos.Select(a => new
            {
                a.idlote,
                a.codigoLote,
                a.fecha_vencimiento
            }).Where(a => a.fecha_vencimiento.Equals(dateTimePicker1.Value.Date)).ToList();
            dataGridView1.DataSource = datos;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                buscarporCodigo();
            }
            else if (radioButton2.Checked)
            {
               
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            buscarporFecha();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
