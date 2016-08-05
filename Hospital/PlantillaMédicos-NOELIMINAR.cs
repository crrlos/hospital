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
    public partial class AgregarMedico : Form
    {
        

            private static AgregarMedico defInstance;
        private    ControladorAreaLaboral controladorarea;
        private ControladorMedicos controladormedico;
        private ControladorEspecialidMedica controladorespecialidad;
        private int idempleadotemp = 0;
        public static AgregarMedico DefInstance{

            get { return AgregarMedico.defInstance; }
            set { AgregarMedico.defInstance = value; }
        }

       

        List<empleados> var;
        

        public AgregarMedico()
        {
           var = new List<empleados>();
           
            controladormedico = new ControladorMedicos();
            InitializeComponent();
            llenarCombos();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Médicos_Load(object sender, EventArgs e)
        {

        }
        private void llenarCombos()
        {

        controladorarea  = new ControladorAreaLaboral();
        controladorespecialidad = new ControladorEspecialidMedica();
            foreach (var item in controladorarea.listararea_Laboral())
            {
                cmbArea.Items.Add(item.nombreArea);
            }
            foreach (var item in controladorespecialidad.ListarEspecialidad())
            {
                cmbespecialidad.Items.Add(item.nombre_especialidad);
            }

        }

        private bool validar()
        {
            if (cmbespecialidad.Text.Length == 0 || cmbArea.Text.Length == 0 || txtNombres.Text.Length == 0 || txtApellidos.Text.Length == 0 || txtJVPM.Text.Length == 0)
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }
        private void button4_Click(object sender, EventArgs e)
        {

            ListaMedicos lm = new ListaMedicos();
           lm.ShowDialog(this);
            if (lm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                bool existe = false;

                foreach (var item in var)
                {
                    if (item.idempleado == lm.Var.idempleado)
                    {
                     
                        existe = true;
                        break;
                    }
                }


                if (!existe)
                {
                   var.Add(lm.Var);
                    MessageBox.Show("OK");
                    
                }
                txtNombres.Text = lm.Var.nombres;
                txtApellidos.Text = lm.Var.apellidos;
               idempleadotemp = lm.Var.idempleado;
                
            }

           lm.Dispose();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validar())
            {
                Model model = new Model();

                medicos m = new medicos();
             

                m.idempleado = idempleadotemp;
                m.JVPM = txtJVPM.Text;
                string especialidad = cmbespecialidad.SelectedItem.ToString();
                especialidadmedicos esp = model.Entidades.especialidadmedicos.Single(a => a.nombre_especialidad.Equals(especialidad));
                m.idespecialidad = esp.idespecialidad;
                string area = cmbArea.SelectedItem.ToString();
                area_Laboral al = model.Entidades.area_Laboral.Single(a => a.nombreArea.Equals(area));
                m.id_arealaboral = al.idarealaboral;
                MessageBox.Show(m.idempleado + " -" + m.idespecialidad.ToString() + m.id_arealaboral.ToString() + m.JVPM.ToString());
                if (controladormedico.insertarMedico(m))
                {
                    MessageBox.Show("correcto");

                }
                else
                {


                    MessageBox.Show("INcorrecto");
                }

            }
            else { }
    
        }

        private void txtJVPM_KeyPress(object sender, KeyPressEventArgs e)
        {



        }

    

    }
}

      