using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.Modelo;
using Hospital.Controladores;
using Hospital.Conexion;

namespace Hospital
{
    public partial class Enfermedades : Form
    {
        private static Enfermedades defInstance;

        public static Enfermedades DefInstance
        {
            get { return Enfermedades.defInstance; }
            set { Enfermedades.defInstance = value; }
        }
        private int operacion = 0;
        private int id = 0;
        private ControladorEnfermedades controladorEnfermedades;
        public Enfermedades()
        {
            
            InitializeComponent();
            deshabilitar();
            operacion = 0;
            controladorEnfermedades = new ControladorEnfermedades();


            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "idenfermedad";
            dataGridView1.Columns[1].Name = "Código";
            dataGridView1.Columns[2].Name = "Nombre";
            dataGridView1.Columns[0].DataPropertyName = "idenfermedad";
            dataGridView1.Columns[1].DataPropertyName = "codigo";
            dataGridView1.Columns[2].DataPropertyName = "nombre";
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = controladorEnfermedades.ListarEnfermedades();

        }

        private void rolAgregar_Click(object sender, EventArgs e)
        {
            habilitar();

        }

        private void habilitar() {

            groupBox1.Enabled = true;
            dataGridView1.Enabled = false;
            enfermedadesAgregar.Enabled = false;
            enfermedadesEditar.Enabled = false;
            enfermedadesEliminar.Enabled = false;
            enfermedadesCerrar.Enabled = false;

        }

        private void deshabilitar()
        {
            enfermedadesNombre.Text = "";
            enfermedadesCodigo.Text = "";
            groupBox1.Enabled = false;
            dataGridView1.Enabled = true;
            enfermedadesAgregar.Enabled = true;
            enfermedadesEditar.Enabled = true;
            enfermedadesEliminar.Enabled = true;
            enfermedadesCerrar.Enabled = true;

        }

        private void enfermedadesGuardar_Click(object sender, EventArgs e)
        {

            if (validar())
            {
                if (operacion == 0)
                {
                    enfermedades en = new enfermedades();
                    en.nombre = enfermedadesNombre.Text;
                    en.codigo = enfermedadesCodigo.Text;
                    if (controladorEnfermedades.insertarEnfermedad(en))
                    {
                        MessageBox.Show("inserción correcta");
                        deshabilitar();
                        dataGridView1.DataSource = controladorEnfermedades.ListarEnfermedades();
                    }
                }
                else {
                    enfermedades en = new enfermedades();
                    en.nombre = enfermedadesNombre.Text;
                    en.codigo = enfermedadesCodigo.Text;
                    if (controladorEnfermedades.modificarEnfermedad(id,en))
                    {
                        MessageBox.Show("actualización correcta");
                        deshabilitar();
                        dataGridView1.DataSource = controladorEnfermedades.ListarEnfermedades();
                    }
                
                
                }
               

            }
            else { }
        }

        private void enfermedadesCancelar_Click(object sender, EventArgs e)
        {
            deshabilitar();
        }

        private bool validar()
        {
            if (enfermedadesCodigo.Text.Length == 0 || enfermedadesNombre.Text.Length == 0)
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }

        private void Enfermedades_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void enfermedadesEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (controladorEnfermedades.eliminarEnfermedad(id))
                    MessageBox.Show("Registro eliminado satisfactoriamente");
                else
                    MessageBox.Show("Ocurrio un error al eliminar registro");
                dataGridView1.DataSource = controladorEnfermedades.ListarEnfermedades();
               
            }
        }

        private void enfermedadesEditar_Click(object sender, EventArgs e)
        {
            habilitar();
            operacion = 1;
            enfermedadesNombre.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            enfermedadesCodigo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

        }

        private void enfermedadesBuscar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controladorEnfermedades.ListarEnfermedades(enfermedadesBuscar.Text);
        }

        private void Enfermedades_FormClosing(object sender, FormClosingEventArgs e)
        {
            defInstance = null;
        }

       
    }
}
