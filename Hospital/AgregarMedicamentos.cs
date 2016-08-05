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
    public partial class AgregarMedicamentos : Form
    {


        private int id=0;
        private int operacion = 0;
        private ControladorMedicamentos controladormedicamento;
        public AgregarMedicamentos()
        {

            controladormedicamento = new ControladorMedicamentos();
            InitializeComponent();

          
        }


        public AgregarMedicamentos(int ID )
        {
            operacion = 1;
            controladormedicamento = new ControladorMedicamentos();
            InitializeComponent();
            Model model = new Model();
            id = ID;
            Medicamentos m = new Medicamentos();
            m= model.Entidades.Medicamentos.Single(a=>a.idmedicamento.Equals(ID));


          
            txtPresentacion.Text = m.presentacion;
            txtNombre.Text = m.nombreMedicamento;


        }


        private void Medicamentos_Load(object sender, EventArgs e)
        {

        }



        private bool validar()
        {
            if (txtNombre.Text.Length==0 ||  txtPresentacion.Text.Length==0)
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validar()) { }
            else
            {
                Model model = new Model();
                Medicamentos m = new Medicamentos();
                m.nombreMedicamento = txtNombre.Text;
               
                m.presentacion = txtPresentacion.Text;
                if (operacion == 0)
                {
                    if (controladormedicamento.insertarMedicamento(m))
                    {

                        MessageBox.Show("CORRECTO");

                        this.Close();

                    }
                    else { MessageBox.Show("ERROR de Insercion"); }

                }
                else if(operacion==1){
                    Model modelo = new Model();
                    Medicamentos mm = new Medicamentos();
                    mm.nombreMedicamento = txtNombre.Text;
                  
                    mm.presentacion = txtPresentacion.Text;

                    if (controladormedicamento.modificarMedicamento(id,mm))
                    {



                        MessageBox.Show("Actualización Correcta");
                        this.Close();



                    }
                    else { MessageBox.Show("ERROR de actualizacion"); }
                
                }

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validaciones.Validar V = new Validaciones.Validar();
            V.validaSoloLetra(e);
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validaSoloNumero(e);
        }

        private void txtPresentacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validaComa(e);
        }

        private void txtPresentacion_TextChanged(object sender, EventArgs e)
        {
        }

    }
}
