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
using Hospital.Modelo;

namespace Hospital
{
    public partial class login : Form
    {

        private bool iniciar;

        public bool Iniciar
        {
            get { return iniciar; }
            set { iniciar = value; }
        }


        public login()
        {
            InitializeComponent();
            iniciar = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals(String.Empty))
                errorProvider1.SetError(txtUsuario, "Digite usuario");
            else if (txtClave.Text.Equals(String.Empty))
                errorProvider1.SetError(txtClave, "Digite clave");
            else
            {
               
                String user = txtUsuario.Text;
                String clave = txtClave.Text;
                Model model = new Model();
               Modelo.usuarios u = model.Entidades
                    .usuarios.SingleOrDefault(a => a.idusuario == user);
                if (u == null)
                {
                    MessageBox.Show("usuario o contraseña incorrectos");
                }
                else
                {
                    if (Encryptar.GetSHA1HashData(clave)== u.clave)
                    {
                       
                        iniciar = true;
                       
                        empleados em = model.Entidades.empleados.SingleOrDefault(a => a.idempleado == u.idempleado);

                       
                        
                        SingleUser single_user = SingleUser.Usuario;

                        try {
                            medicos m = model.Entidades.medicos.Single(a => a.idempleado == em.idempleado);
                             single_user.Idmedico = m.idmedico;
                        }catch(Exception){}
                       

                        single_user.Idusuario = u.idusuario;
                        single_user.Nombres = em.nombres;
                        single_user.Apellidos = em.apellidos;
                        single_user.Idrol = u.idrol;
                        single_user.Rol = u.roles.rol;
                        
                        this.Close();
                       
                    }
                    else
                    {
                        MessageBox.Show("usuario o contraseña incorrectos");
                    }
                }
            }

        }
    }
}
