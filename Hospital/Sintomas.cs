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
    public partial class Sintomas : Form
    {
        private static Sintomas defInstance;

        public static Sintomas DefInstance
        {
            get { return Sintomas.defInstance; }
            set { Sintomas.defInstance = value; }
        }
        private int operacion = 0;
        private int id = 0;
        private ControladorSintomas controladorSintomas;
        public Sintomas()
        {
            InitializeComponent();

            deshabilitar();
            operacion = 0;
            controladorSintomas = new ControladorSintomas();


            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[1].Name = "Sintoma";
            
            dataGridView1.Columns[0].DataPropertyName = "idsintoma";
            dataGridView1.Columns[1].DataPropertyName = "sintoma";

            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 500;
            
            
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = controladorSintomas.ListarSintomas();
        }

        private void enfermedadesBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void enfermedadesEliminar_Click(object sender, EventArgs e)
        {

        }

        private void enfermedadesEditar_Click(object sender, EventArgs e)
        {

        }

        private void habilitar()
        {

            groupBox1.Enabled = true;
            dataGridView1.Enabled = false;
            btnAgregar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCerrar.Enabled = false;

        }

        private void deshabilitar()
        {
            txtNombre.Text = "";
           
            groupBox1.Enabled = false;
            dataGridView1.Enabled = true;
            btnAgregar.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnCerrar.Enabled = true;

        }

        private void Sintomas_FormClosing(object sender, FormClosingEventArgs e)
        {
            defInstance = null;
        }

        private void Sintomas_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }
        private bool validar()
        {
            if ( txtNombre.Text.Length == 0)
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                if (operacion == 0)
                {
                    sintomas s = new sintomas();
                    s.sintoma = txtNombre.Text;
                    if (controladorSintomas.insertarSintoma(s))
                    {
                        MessageBox.Show("inserción correcta");
                        deshabilitar();
                        dataGridView1.DataSource = controladorSintomas.ListarSintomas();
                    }
                }
                else
                {
                    sintomas s = new sintomas();
                    s.sintoma = txtNombre.Text;

                    if (controladorSintomas.actualizarSintoma(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString()), s))
                    {
                        MessageBox.Show("actualización correcta");
                        deshabilitar();
                        dataGridView1.DataSource = controladorSintomas.ListarSintomas();
                    }


                }


            }
            else { }
            deshabilitar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitar();
            operacion = 1;
            txtNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            operacion = 0;
            habilitar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (controladorSintomas.eliminarSintoma(int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString())))
                    MessageBox.Show("Registro eliminado satisfactoriamente");
                else
                    MessageBox.Show("Ocurrio un error al eliminar registro");
                dataGridView1.DataSource = controladorSintomas.ListarSintomas();

            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorSintomas.ListarSintomas(txtBuscar.Text);
        }

    }
}
