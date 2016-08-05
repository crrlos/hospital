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
    public partial class Empleados : Form
    {
        private ControladorDepartamentos controladorDepartamentos;
        private ControladorEmpleado controladorEmpleado;
        ControladorMedicos controladormedico = new ControladorMedicos();
        private int operacion = 0;
        private int idempleado = 0;
        private int opcion = 1;
       

        

        public Empleados()
        {
            
            InitializeComponent();

            llenarCombos();
            llenarCargos();
         

        }

        public void clearcampos(){
            empleadoNombres.Text = "";
            empleadoApellidos.Text = "";
            empleadoDUI.Text = "";
            empleadoNIT.Text ="";
           empleadoDireccion.Text="";

           empleadoDireccion.Text = "";
           empleadoCargo.Text = "";
           empleadoMunicipio.Text = "";
           txtTelefono.Text = "";
           dtFecha.Text = "";
        }
        public Empleados(int id,int o)
        {

            InitializeComponent();
            operacion = 1;
            idempleado = id;
            llenarCombos();
            llenarCargos();
            opcion = o;
            Model model = new Model();
            empleados emp = new empleados();
            emp = model.Entidades.empleados.Single(a=> a.idempleado == id);
            empleadoNombres.Text = emp.nombres;
            empleadoApellidos.Text = emp.apellidos;
            empleadoDireccion.Text = emp.direccion;
            empleadoDUI.Text = emp.dui;
            empleadoNIT.Text = emp.NIT;
            cargos c = new cargos();
            c = model.Entidades.cargos.Single(a=> a.idcargo == emp.idcargo);
            empleadoCargo.Text= c.nombre_cargo;
            departamentos dep = new departamentos();
            dep = model.Entidades.departamentos.Single(a=> a.id_departamento == emp.iddepartamento);
            empleadoDepartamento.Text = dep.nombredepartamento;
            municipios m = new municipios();
            m = model.Entidades.municipios.Single(a=> a.idmunicipio == emp.idmunicipio);
            empleadoMunicipio.Text = m.nombremunicipio;
            txtTelefono.Text = emp.telefono;
            dtFecha.Value = emp.fecha_contratacion;
           

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
            errorProvider1.Dispose();
            /*if(empleadoNIT.Text.Length == 4 || empleadoNIT.Text.Length == 11 || empleadoNIT.Text.Length == 15)
            {
                empleadoNIT.Text += "-";
                empleadoNIT.Select(empleadoNIT.Text.Length, 0);
            }*/
        }

        private void empleadoDUI_KeyDown(object sender, KeyEventArgs e)
        {

           
        }

        private void empleadoDUI_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void empleadoDUI_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
              
               
                e.Handled = true;
                return;
            }
            else if (e.KeyChar.Equals((char)Keys.Back))
            {

              

            }
            else
            {
                if (empleadoDUI.Text.Length == 8)
                {
                    empleadoDUI.Text += "-";
                    empleadoDUI.Select(empleadoDUI.Text.Length, 0);
                }
            }
        }

        private void empleadoNIT_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {


                e.Handled = true;
                return;
            }
            else if (e.KeyChar.Equals((char)Keys.Back))
            {



            }
            else
            {
                if (empleadoNIT.Text.Length == 4 || empleadoNIT.Text.Length == 11 || empleadoNIT.Text.Length == 15)
                {
                    empleadoNIT.Text += "-";
                    empleadoNIT.Select(empleadoNIT.Text.Length, 0);
                }
            }
        }

        private void empleadoDUI_TextChanged(object sender, EventArgs e)
        {
            if (opcion != 3)
            {
                if (empleadoDUI.Text.Length == 10)
                {
                    Model model = new Model();
                    empleados em = new empleados();

                    try
                    {
                        em = model.Entidades.empleados.Single(a => a.dui.Equals(empleadoDUI.Text));
                        if (empleadoDUI.Text == em.dui)
                        {
                            MessageBox.Show("DUI YA EXISTE, POR FAVOR INGRESE OTRO NUMERO");

                            empleadoDUI.Text = "";
                        }

                    }
                    catch (Exception excep)
                    {

                    }

                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!validar())
            { }
            else
            {

              
                Model model = new Model();

                empleados emp = new empleados();
                emp.nombres = empleadoNombres.Text;
                emp.apellidos = empleadoApellidos.Text;
                emp.direccion = empleadoDireccion.Text;
                string depto = empleadoDepartamento.SelectedItem.ToString();
                departamentos dep = model.Entidades.departamentos.Single(a=> a.nombredepartamento.Equals(depto));
                string municipio = empleadoMunicipio.SelectedItem.ToString();
                municipios mu = model.Entidades.municipios.Single(a=> a.nombremunicipio.Equals(municipio));

                emp.iddepartamento = dep.id_departamento;
                emp.idmunicipio = mu.idmunicipio;
                        
                emp.NIT = empleadoNIT.Text;
                        emp.telefono = txtTelefono.Text;
                        emp.fecha_contratacion = dtFecha.Value.Date; 
                emp.dui = empleadoDUI.Text;
                string cargo = empleadoCargo.SelectedItem.ToString();
                cargos c = model.Entidades.cargos.Single(a=> a.nombre_cargo.Equals(cargo));
                emp.idcargo = c.idcargo;
                emp.estado="ACTIVO";
                if (operacion == 0)
                {
                    if (controladorEmpleado.insertarEmpleado(emp))
                    {
                        MessageBox.Show("empleado insertado");
                  
                        clearcampos();
                        empleadoDepartamento.Items.Clear();

                        empleadoMunicipio.Items.Clear();
                        empleadoCargo.Text = " ";
                        llenarCombos();

                    }
                    else
                    { MessageBox.Show("error en la inserción"); }
                    
                }
               
                else if(operacion==1) {
                    if (controladorEmpleado.modificarEmpleado(idempleado,emp))
                    {
                        MessageBox.Show("empleado actualizado");
                        this.Close();
                        clearcampos();
                       
                    }
                    else
                    { MessageBox.Show("error en la actualización"); }
                    
                }


             
                if (empleadoCargo.SelectedItem.ToString() == "MEDICO")
                {



                   

                    AgregarEmpleadoMedico emple = new AgregarEmpleadoMedico(emp.idempleado);
                    
                    emple.Show();



                }

            }
            
           
        }


        private bool validar()
        {
            if (empleadoNombres.Text.Length == 0)
            {
                errorProvider1.SetError(empleadoNombres, "El campo está vacío");
                return false;
            }
            if (empleadoApellidos.Text.Length == 0)
            {
                errorProvider1.SetError(empleadoApellidos, "El campo está vacío");
                return false;
            }
            if (empleadoDireccion.Text.Length == 0)
            {
                errorProvider1.SetError(empleadoDireccion, "El campo está vacío");
                return false;
            }
           if (empleadoDepartamento.SelectedItem == null)
            {
                errorProvider1.SetError(empleadoDepartamento, "No hay valor seleccionado");
                return false;
            }

            if (empleadoMunicipio.SelectedItem == null)
            {
                errorProvider1.SetError(empleadoMunicipio, "No hay valor seleccionado");
                return false;
            }
            if (empleadoDUI.Text.Length < 10)
            {
                errorProvider1.SetError(empleadoDUI, "El campo está incompleto");
                return false;
            }

            if (empleadoNIT.Text.Length < 17)
            {
                errorProvider1.SetError(empleadoNIT, "El campo está incompleto");
                return false;
            }


            if (txtTelefono.Text.Length <8)
            {
                errorProvider1.SetError(txtTelefono, "El campo está incompleto");
                return false;
            }






            return true;
        }

        private void empleadoNombres_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void empleadoApellidos_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void empleadoDireccion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void empleadoDepartamento_SelectedValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void empleadoMunicipio_SelectedValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void empleadoCargo_SelectedValueChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void EmpleadosRegistro_Load(object sender, EventArgs e)
        {

        }

        private void empleadoDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            empleadoMunicipio.Items.Clear();

            ControladorMunicipio cm = new ControladorMunicipio();
            Model model = new Model();
            string iddepto = empleadoDepartamento.SelectedItem.ToString();
            departamentos d = model.Entidades.departamentos.Single(a=> a.nombredepartamento.Equals(iddepto));

            foreach (var item in cm.listarMunicipios(d.id_departamento))
            {
                empleadoMunicipio.Items.Add(item.nombremunicipio);
                
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
        }


        public void llenarCombos()
        {
            controladorDepartamentos = new ControladorDepartamentos();
            controladorEmpleado = new ControladorEmpleado();
            foreach (var item in controladorDepartamentos.listarDepartamentos())
            {
                empleadoDepartamento.Items.Add(item.nombredepartamento);
            }

          
        
        }

        public void llenarCargos() {
            ControladorCargo controladorCargo = new ControladorCargo();
            foreach (var item in controladorCargo.listarCargos())
            {
                empleadoCargo.Items.Add(item.nombre_cargo);
            }
        }

        private void empleadoCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
          
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void empleadoMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void empleadoNombres_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar v = new Validar();
            v.validaSoloLetra(e);

        }

        private void empleadoApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar v = new Validar();
            v.validaSoloLetra(e);

        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {

            Validar v = new Validar();
            v.validaSoloNumero(e);
        }

        private void empleadoCargo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
