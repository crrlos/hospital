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
    public partial class Agregar_A_Inventario : Form
    {
        private bool decide;
        List<Medicamentos> medicamento;
        List<InventarioMedicamentos> inventario;
        private ControladorMedicamentos controladormedicamento;
        private ControladorInventarioMedicamentos controladorinventario;
        public Agregar_A_Inventario()
        {
            InitializeComponent();

            crearLista();
            medicamento = new List<Medicamentos>();
            inventario = new List<InventarioMedicamentos>();
            llenarCombos();
            dataGridView1.AutoGenerateColumns = false;
            /*dataGridView1.Columns[0].Visible = false;
            
         
            dataGridView1.Columns[2].Width = 220;
            dataGridView1.Columns[1].Width = 260;*/

            controladormedicamento = new ControladorMedicamentos();
            controladorinventario = new ControladorInventarioMedicamentos();

        }
        private void crearLista()
        {
            Model modelo = new Model();
            var result =
                from medico in modelo.Entidades.Medicamentos

                from inventario in modelo.Entidades.InventarioMedicamentos
                where medico.idmedicamento == inventario.idmedicamento
                select new  {
                    
                
                
                
                    medico.nombreMedicamento
                };






            dataGridView1.DataSource = result.ToList();


        }



        private bool validar()
        {
            if (txtLote.Text.Length == 0 || txtCantidadIngresada.Text.Length==0 || cmbFabricante.Text.Length==0  )
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }
       
        private void Agregar_A_Inventario_Load(object sender, EventArgs e)
        {



        }
        private void llenarCombos()
        {
            controladormedicamento = new ControladorMedicamentos();
            foreach (var item in controladormedicamento.ListarFabricante())
            {
                cmbFabricante.Items.Add(item.Nombre);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            if (!validar())
            { }
            else {
                if (!(dataGridView1.SelectedRows.Count == 0))
                {
                    int idmed=int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    int cantidad = int.Parse(txtCantidadIngresada.Text);
                    Model model = new Model();
                    Medicamentos med = new Medicamentos();
                    InventarioMedicamentos im = new InventarioMedicamentos();
                    InventarioMedicamentos old = new InventarioMedicamentos();
                    
                    old  = model.Entidades.InventarioMedicamentos.Find(idmed);

                    if ( idmed!=old.idmedicamento)
                    { 
                  
                    im.fechaCaducidad = dtFecha.Value.Date;
                    im.CodLote = txtLote.Text;
                    im.idmedicamento = idmed;
                    string idprovee = cmbFabricante.SelectedItem.ToString();
                    proveedores p = model.Entidades.proveedores.Single(a => a.Nombre.Equals(idprovee));
                    im.idproveedor = p.idproveedor;

                    if ((controladorinventario.insertarAinventario(im)))
                    {
                        MessageBox.Show("ok");

                    }
                    else { MessageBox.Show("ERROR"); }}
                
                    else { // ACTUALIZA EL INVENTARIO DE MEDICAMENTOS

                        MessageBox.Show("ERROR COMPADRE");
                    
                    }
                }//fin seleccion

                else {
                    MessageBox.Show("POR FAVOR, SELECCIONE UNA OPCION");
                }

            }
            /*
            
            */
        }

        private void btnVer_Click(object sender, EventArgs e)
        {

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLote_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar V = new Validar();
            V.validaCaracteres(e);
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validaSoloNumero(e);

        }

        private void Agregar_A_Inventario_Enter(object sender, EventArgs e)
        {
            crearLista();
        }
        private void buscarpornombre()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.Medicamentos.Select(a => new
            {

                a.idmedicamento,
                a.nombreMedicamento,
                a.presentacion
            
            }).Where(a => a.nombreMedicamento.Contains(textBox2.Text)).ToList();
            dataGridView1.DataSource = datos;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buscarpornombre();
        }

    }
}
