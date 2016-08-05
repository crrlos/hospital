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
using Hospital.Conexion;
using Hospital.Controladores;
using Hospital.Validaciones;
namespace Hospital
{
    public partial class RegistroPacientes : Form
    {
        private static RegistroPacientes defInstance;

        public static RegistroPacientes DefInstance
        {
            get { return RegistroPacientes.defInstance; }
            set { RegistroPacientes.defInstance = value; }
        }

        private ControladorPacientes controladorpacientes;
        private ControladorDepartamentos controladorDepartamentos;
        private ControladorMunicipio controladormunicipio;
        private int aviso = 0;
        private int operacion = 0;

        private int idpaciente = 0;
        public RegistroPacientes()
        {
            InitializeComponent();
            llenarCombos();

            controladorpacientes = new ControladorPacientes();
        }


        public RegistroPacientes(int id, int av )
        {
            controladorpacientes = new ControladorPacientes();
            InitializeComponent();
            operacion = 1;
            idpaciente =id;
            llenarCombos();
            aviso = av;
            Model model = new Model();
            pacientes pac = new pacientes();
            pac = model.Entidades.pacientes.Single(a => a.idpaciente == id);
            txtNombre.Text = pac.nombres;
            txtApellido.Text = pac.apellidos;
            txtDireccion.Text = pac.direccion;
            txtDui.Text = pac.dui;
            txtTelefono.Text = pac.telefono;
            dateTimePicker1.Value = pac.fecha_nacimiento;

            cmbGenero.Text = pac.genero;
            departamentos dep = new departamentos();
            dep = model.Entidades.departamentos.Single(a => a.id_departamento == pac.id_departamento);
            cmbDepartamento.Text = dep.nombredepartamento;
            municipios m = new municipios();
            m = model.Entidades.municipios.Single(a => a.idmunicipio == pac.id_municipio);
            cmbMunicipio.Text = m.nombremunicipio;
            txtNombreEncargado.Text = pac.nombreencargado;
            txtApellidosEncargado.Text = pac.apellidoencargado;
            txtTelefonoEncargado.Text = pac.telefono_encargado;
            txtDuiEncargado.Text = pac.duiencargado;

        
        }


        private void limpiarCampos() {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtDui.Text = "";
            txtTelefono.Text = "";

           

          
            cmbGenero.Items.Clear();
            cmbDepartamento.Items.Clear();
            cmbMunicipio.Items.Clear();
            txtNombreEncargado.Text = "";
            txtApellidosEncargado.Text = "";
            txtTelefonoEncargado.Text = "";
            txtDuiEncargado.Text = "";


        }
        private void llenarCombos()
        {
            
            controladorDepartamentos = new ControladorDepartamentos();
            controladormunicipio = new ControladorMunicipio();
            foreach (var item in controladorDepartamentos.listarDepartamentos())
            {
                cmbDepartamento.Items.Add(item.nombredepartamento);
            }

            foreach (var item in controladormunicipio.listarMunicipios(cmbDepartamento.SelectedIndex))
            {


                cmbMunicipio.Items.Add(item.nombremunicipio);

            }

            cmbGenero.Items.Add("MASCULINO");
            cmbGenero.Items.Add("FEMENINO");

        }
        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistroPacientes_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validar())
            { }
            else
            {

                Model model = new Model();
                pacientes pac = new pacientes();

                pac.nombres = txtNombre.Text.ToUpper();
                pac.apellidos = txtApellido.Text.ToUpper();
                pac.direccion = txtDireccion.Text;
                string depto = cmbDepartamento.SelectedItem.ToString();
                departamentos dep = model.Entidades.departamentos.Single(a => a.nombredepartamento.Equals(depto));
                string municipio = cmbMunicipio.SelectedItem.ToString();
                municipios mu = model.Entidades.municipios.Single(a => a.nombremunicipio.Equals(municipio));

                pac.id_departamento = dep.id_departamento;
                pac.id_municipio = mu.idmunicipio;
                pac.dui = txtDui.Text;
                pac.telefono = txtTelefono.Text;
                pac.genero = cmbGenero.SelectedItem.ToString();



                pac.fecha_nacimiento = dateTimePicker1.Value.Date;
                pac.nombreencargado = txtNombreEncargado.Text.ToUpper();
                pac.apellidoencargado = txtApellidosEncargado.Text.ToUpper();
                pac.duiencargado = txtDuiEncargado.Text;
                pac.telefono_encargado = txtTelefonoEncargado.Text;



                if (operacion == 0)
                {
                    if (controladorpacientes.insertarPaciente(pac))
                    {
                        MessageBox.Show("paciente insertado");
                        limpiarCampos();
                        llenarCombos();
                    }
                    else
                    { MessageBox.Show("error en la inserción"); }}

                    else {
                    if (controladorpacientes.modificarPaciente(idpaciente,pac))
                    {
                        MessageBox.Show("paciente actualizado");
                        this.Close();
                        llenarCombos();
                    }
                    else
                    { MessageBox.Show("error en la actualización"); }
                    
                }

                }
            }
        

        private bool validar()
        {
            if (txtNombre.Text.Length == 0)
            {
                errorProvider1.SetError(txtNombre, "El campo está vacío");
                return false;
            }
            if (txtApellido.Text.Length == 0)
            {
                errorProvider1.SetError(txtApellido, "El campo está vacío");
                return false;
            }
            if (txtDireccion.Text.Length == 0)
            {
                errorProvider1.SetError(txtDireccion, "El campo está vacío");
                return false;
            }
            if (cmbDepartamento.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDepartamento, "No hay valor seleccionado");
                return false;
            }

            if (cmbMunicipio.SelectedItem == null)
            {
                errorProvider1.SetError(cmbMunicipio, "No hay valor seleccionado");
                return false;
            }

            if (cmbGenero.SelectedItem == null)
            {
                errorProvider1.SetError(cmbGenero, "No hay valor seleccionado");
                return false;
            }

            if (txtDui.Text.Length>0 && txtDui.Text.Length < 10 )
            {
                errorProvider1.SetError(txtDui, "El campo está incompleto");
                return false;
            }

           
            if (txtTelefono.Text.Length < 7)
            {
                errorProvider1.SetError(txtTelefono, "El campo está incompleto");
                return false;
            }

          
          

            return true;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDuiEncargado_KeyPress(object sender, KeyPressEventArgs e)
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
                if (txtDuiEncargado.Text.Length == 8)
                {
                    txtDuiEncargado.Text += "-";
                    txtDuiEncargado.Select(txtDuiEncargado.Text.Length, 0);
                }
               
            }
          
        
        }

        private void txtDui_KeyPress(object sender, KeyPressEventArgs e)
        { 
            Validar  v = new Validar();
            v.validaSoloNumero(e);

                if (txtDui.Text.Length == 8)
                {
                    txtDui.Text += "-";
                    txtDui.Select(txtDui.Text.Length, 0);
                }
            
          
        }


        private void habilitar()
        {
            groupBox1.Enabled = true;

        }

        private void deshabilitar()
        {
            groupBox1.Enabled = false;

        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked)
            {
                habilitar();
            }

            else
            {
                deshabilitar();
            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMunicipio.Items.Clear();
            
            ControladorMunicipio cm = new ControladorMunicipio();
            Model model = new Model();
            string iddepto = cmbDepartamento.SelectedItem.ToString();
            departamentos d = model.Entidades.departamentos.Single(a => a.nombredepartamento.Equals(iddepto));

            foreach (var item in cm.listarMunicipios(d.id_departamento))
            {
                cmbMunicipio.Items.Add(item.nombremunicipio);

            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void txtDui_TextChanged(object sender, EventArgs e)
        {
            if (aviso == 0)
            {
                try
                {
                    if (txtDui.Text.Length == 10)
                    {
                        Model model = new Model();
                        pacientes p = new pacientes();


                        p = model.Entidades.pacientes.Single(a => a.dui.Equals(txtDui.Text));


                        if (txtDui.Text == p.dui)
                        {
                            MessageBox.Show("DUI YA EXISTE, POR FAVOR INGRESE OTRO NUMERO");

                            txtDui.Text = "";
                        }


                    }
                }
                catch (Exception ee)
                {

                }
            } 
           
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Dispose();
        }

        private void txtNombreEncargado_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validaSoloLetra(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validaSoloLetra(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar v = new Validar();
            v.validaSoloNumero(e);
        }

        private void RegistroPacientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            defInstance = null;
        }
    }
}
