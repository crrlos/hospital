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
using Hospital.Validaciones;
namespace Hospital
{
    public partial class AgregarEmpleadoMedico : Form
    {
    
        

        private ControladorAreaLaboral controladorarea;
        private ControladorEspecialidMedica controladorespecialidad;
        private ControladorMedicos controladormedico;
        private int id;
        private int idmedicos = 0;
        private int operacion = 0;
        private int idemple = 0;
        public AgregarEmpleadoMedico()
   {
          
            controladormedico   = new ControladorMedicos();
            InitializeComponent();
            llenarCombos();
        }

          public AgregarEmpleadoMedico(int idc)
        {

            controladormedico = new ControladorMedicos();
            InitializeComponent();
            llenarCombos();
            id = idc;
            operacion = 0;
          }
          public AgregarEmpleadoMedico(int idmed ,int idem)
          {
              
         
              InitializeComponent();
              controladormedico = new ControladorMedicos();
              llenarCombos();
              idmedicos = idmed;
              idemple = idem;
              operacion = 1;
              Model model = new Model();
              medicos m = new medicos();
              m = model.Entidades.medicos.Single(a => a.idmedico.Equals(idmedicos));
              txtJVPM.Text = m.JVPM;
              cmbArea.Text = m.area_Laboral.nombreArea;
              cmbespecialidad.Text = m.especialidadmedicos.nombre_especialidad;
             
          }

        private void llenarCombos()
        {
            controladorarea = new ControladorAreaLaboral();
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
            if (cmbespecialidad.Text.Length == 0 || cmbArea.Text.Length == 0 || txtJVPM.Text.Length == 0)
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }

      

        private void AgregarEmpleadoMedico_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validar())
            { }
            else
            {
                Model model = new Model();

                medicos m = new medicos();
                controladormedico = new ControladorMedicos();

                m.idempleado = id;
                m.JVPM = txtJVPM.Text;
                string especialidad = cmbespecialidad.SelectedItem.ToString();
                especialidadmedicos esp = model.Entidades.especialidadmedicos.Single(a => a.nombre_especialidad.Equals(especialidad));
                m.idespecialidad = esp.idespecialidad;
                string area = cmbArea.SelectedItem.ToString();
                area_Laboral al = model.Entidades.area_Laboral.Single(a => a.nombreArea.Equals(area));
                m.id_arealaboral = al.idarealaboral;
               
                if (operacion == 0)
                {
                    if (controladormedico.insertarMedico(m))
                    {
                        MessageBox.Show("correcto");
                        this.Close();
                    }
                    else {
                        
                        MessageBox.Show("Error en la INSERCION");
                    
                    }
                }
                else if (operacion == 1)
                {
                    
                    Model modelp = new Model();

                    medicos mn = new medicos();
                    controladormedico = new ControladorMedicos();

                    
                    mn.JVPM = txtJVPM.Text;
                    string especialidades = cmbespecialidad.SelectedItem.ToString();
                    especialidadmedicos espe = model.Entidades.especialidadmedicos.Single(a => a.nombre_especialidad.Equals(especialidades));
                    mn.idespecialidad = espe.idespecialidad;
                    string areas = cmbArea.SelectedItem.ToString();
                    area_Laboral ala = model.Entidades.area_Laboral.Single(a => a.nombreArea.Equals(areas));
                    mn.id_arealaboral = ala.idarealaboral;
                    mn.idempleado = idemple;

                 

                    if (controladormedico.modificarMedicos(idmedicos, mn))
                    {
                        MessageBox.Show("Médico actualizado");
                        this.Close();

                    }
                    else
                    {

                        

                        MessageBox.Show("error en la actualización"); }
                }

            }

            
            
    
        }

        private void txtJVPM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar  v= new Validar();
            v.validaSoloNumero(e);
        }

        private void txtJVPM_TextChanged(object sender, EventArgs e)
        {
            if (operacion != 1) {
                if (txtJVPM.Text.Length == 4)
                {
                    Model model = new Model();
                    medicos m = new medicos();

                    try
                    {
                        m = model.Entidades.medicos.Single(a => a.JVPM.Equals(txtJVPM.Text));
                        if (txtJVPM.Text == m.JVPM)
                        {
                            MessageBox.Show("JVPM YA EXISTE, POR FAVOR INGRESE OTRO NUMERO");

                            txtJVPM.Text = "";
                        }

                    }
                    catch (Exception excep)
                    {

                    }
                }

            }
        }

            
        }
    }

