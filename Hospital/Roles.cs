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

namespace Hospital
{
    public partial class Roles : Form
    {
        private ControladorRoles controladorRoles;
        private int operacion = 0;
        public Roles()
        {
            InitializeComponent();

            groupBox1.Enabled = false;
            
            controladorRoles = new ControladorRoles();

            dataGridView1.ColumnCount = 2;
            
            dataGridView1.Columns[0].Name = "Idrol";
            dataGridView1.Columns[0].DataPropertyName = "idrol";
            dataGridView1.Columns[1].Name = "Rol";
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[1].DataPropertyName = "rol";
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = controladorRoles.listarRoles();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            roles r = new roles();
            r.rol = rolNombre.Text.ToUpper();
            if (controladorRoles.insertarRol(r))
            {
                MessageBox.Show("correcto");
            }
            dataGridView1.DataSource = controladorRoles.listarRoles();
            deshabilitar();

        }

        private void cargarRoles()
        {
            dataGridView1.DataSource = controladorRoles.listarRoles();
        }

        private void rolEliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea eliminar este registro?", "Alert", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.Yes)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                if (controladorRoles.eliminarRol(id))
                    MessageBox.Show("Registro eliminado satisfactoriamente");
                else
                    MessageBox.Show("Ocurrio un error al eliminar registro");
                dataGridView1.DataSource = controladorRoles.listarRoles();
                
            }
        }

        private void habilitar()
        {
            groupBox1.Enabled = true;
            dataGridView1.Enabled = false;
            rolAgregar.Enabled = false;
            rolEditar.Enabled = false;
            rolEliminar.Enabled = false;
            rolCerrar.Enabled = false;
        }

        private void deshabilitar()
        {
            rolNombre.Text = "";
            groupBox1.Enabled = false;
            dataGridView1.Enabled = true;
            rolAgregar.Enabled = true;
            rolEditar.Enabled = true;
            rolEliminar.Enabled = true;
            rolCerrar.Enabled = true;
        }

        private void rolAgregar_Click(object sender, EventArgs e)
        {
            habilitar();
            dataGridView1.DataSource = controladorRoles.listarRoles();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            deshabilitar();
            dataGridView1.DataSource = controladorRoles.listarRoles();
        }

        private void rolCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
