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
using Hospital.Validaciones;


namespace Hospital
{
    public partial class MostrarInventario : Form
    {
        public MostrarInventario()
        {
            InitializeComponent();
            crearLista();
        }

        private void MostrarInventario_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void crearLista()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.InventarioMedicamentos.Select(a => new
            {
                a.idInventario,
                a.idmedicamento,
                a.Medicamentos.nombreMedicamento,
                a.Medicamentos.presentacion,
               a.stock
               
               

            }).ToList();
            dataGridView1.DataSource = datos;
        }

        private void MostrarInventario_KeyPress(object sender, KeyPressEventArgs e)
        {
            crearLista();
        }

    }
}
