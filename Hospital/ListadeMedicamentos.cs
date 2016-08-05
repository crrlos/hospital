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
    public partial class ListadeMedicamentos : Form
    {

        
       
        private ControladorMedicamentos controladormedicamento;
        
        public ListadeMedicamentos()
        {
            InitializeComponent();
            controladormedicamento = new ControladorMedicamentos();
            crearLista();
            radioButton1.Checked = true;


            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[1].Width = 260;
            dataGridView1.Columns[0].Width = 60;
            dataGridView1.AutoGenerateColumns = false;
            btnSeleccionar.Visible = false;
        }
      
        private void crearLista()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.Medicamentos.Select(a => new
            {
                a.idmedicamento,
                a.nombreMedicamento,
                a.presentacion
              

            }).ToList();
            dataGridView1.DataSource = datos;
        }


        private void buscarpornombre()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.Medicamentos.Select(a => new
            {

                a.idmedicamento,
                a.nombreMedicamento,
                a.presentacion,
            }).Where(a => a.nombreMedicamento.Contains(imbuscar.Text)).ToList();
            dataGridView1.DataSource = datos;
        }
        private void buscarporForma()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.Medicamentos.Select(a => new
            {

                a.idmedicamento,
                a.nombreMedicamento,
                a.presentacion
            }).Where(a => a.presentacion.Contains(imbuscar.Text)).ToList();
            dataGridView1.DataSource = datos;
        }

        private void ListadeMedicamentos_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    if (controladormedicamento.eliminarMedicamentos(id))
                        MessageBox.Show("Registro eliminado satisfactoriamente");
                    else
                        MessageBox.Show("Ocurrio un error al eliminar registro");

                    crearLista();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count != 0)
            {
                AgregarMedicamentos rp = new AgregarMedicamentos(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()));

                rp.Owner = this;
                rp.MdiParent = this.MdiParent;

                rp.Show();
            }
            else {
                MessageBox.Show("contenido vacío");
            }

        }

        private void imbuscar_TextChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                buscarpornombre();
            }
            else if (radioButton2.Checked)
            {
                buscarporForma();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ListadeMedicamentos_Enter(object sender, EventArgs e)
        {
            crearLista();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            imbuscar.Text = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarMedicamentos am = new AgregarMedicamentos();
            am.MdiParent = this.MdiParent; 
            am.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
