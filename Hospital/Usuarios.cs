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
    public partial class Usuarios : Form
    {
        private ControladorUsuario controladorUsuario;
        private ControladorRoles controladorRoles;
        private ControladorEmpleado controladorEmpleado;
        public Usuarios()
        {
            InitializeComponent();
            controladorRoles = new ControladorRoles();
            controladorEmpleado = new ControladorEmpleado();
            controladorUsuario = new ControladorUsuario();

            foreach (var item in controladorRoles.listarRoles()) //ciclo de llenado del combobox de los roles
            {
              usuariosRol.Items.Add(item.rol);
              
            }
            //configuración del datagridview
            dataGridView1.ColumnCount = 4;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].Name = "ID";
            dataGridView1.Columns[0].DataPropertyName= "idempleado";
            dataGridView1.Columns[0].Width = 50;

            dataGridView1.Columns[1].Name = "NOMBRES";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].DataPropertyName = "nombres";
            
            dataGridView1.Columns[2].Name = "APELLIDOS";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].DataPropertyName = "apellidos";
            dataGridView1.Columns[3].Name = "DUI";
            dataGridView1.Columns[3].DataPropertyName = "dui";

            dataGridView1.DataSource = controladorEmpleado.listarEmpleados();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            Model model = new Model();
            List<empleados> emp;

            if (rdui.Checked)
            {
                emp = model.Entidades.empleados.Where(a => a.dui.Contains(usuarioBuscar.Text)).ToList();
            }
            else {
                emp = model.Entidades.empleados.Where(a => a.apellidos.Contains(usuarioBuscar.Text)).ToList();
            }
            
            dataGridView1.DataSource = emp;

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            rdui.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(validar())
           {
               int idempleado = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
               Model model = new Model();
               empleados emp;
               emp = model.Entidades.empleados.SingleOrDefault(a=> a.idempleado == idempleado );
                 Modelo.usuarios u = new Modelo.usuarios();
                 u.idusuario = obtenerCodigo(emp.NIT,emp.nombres);
              
                 u.clave = Encryptar.GetSHA1HashData(usuarioPassword.Text);
                 u.idempleado = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                 roles r;
                 string rol = usuariosRol.SelectedItem.ToString();
                 r = model.Entidades.roles.Single(a=>  a.rol.Equals(rol)); 
                
                    
                 
                 u.idrol = r.idrol;
                if (controladorUsuario.insertarUsuario(u))
                 {
                     MessageBox.Show("Usuario Insertado");
                 }
                 else { MessageBox.Show("Falló inserción, posiblemente ya existe el usuario"); }


           }
        }

        private bool validar()
        {
            if (usuarioPassword.Text != usuarioPassword2.Text)
            {
                MessageBox.Show("las contraseñas no coinciden");
                return false;
            }
            else if (usuarioPassword.Text == "" || usuarioPassword2.Text == "")
            {
                MessageBox.Show("ingrese una contraseña");
                return false;
            }else 
            if (usuariosRol.SelectedItem == null)
            {
                MessageBox.Show("No ha seleccionado un rol");
                return false;
            }
            return true;
        }

        private string obtenerCodigo(string nit,string nombre)
        {
            string codigo = "";
            for (int i = 0; i < nombre.Length; i++) {
                if (!char.IsWhiteSpace(nombre[i]))
                {

                    codigo += nombre[i];

                }
                else { break; }
            
            }
            codigo += nit.ElementAt(1);
            codigo += nit.ElementAt(6);
            codigo += nit.ElementAt(10);
            codigo += nit.ElementAt(16);
            

            return codigo;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaUsuarios lu = new ListaUsuarios();
            lu.Show();
        }
    }
}
