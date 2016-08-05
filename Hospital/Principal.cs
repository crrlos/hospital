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

namespace Hospital
{
    public partial class Principal : Form
    {
        private ControladorMenu controladorMenu;
        public Principal()
        {
            InitializeComponent();
            controladorMenu = new ControladorMenu();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RegistroPacientes.DefInstance == null)
            {
                RegistroPacientes rp = new RegistroPacientes();
                rp.MdiParent = this;
                RegistroPacientes.DefInstance = rp;
                rp.Show();
            }
            else { RegistroPacientes.DefInstance.Show();
            RegistroPacientes.DefInstance.Focus();
            }
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Empleados er = new Empleados();
            er.MdiParent = this;
            er.Show();
        }

        private void agregarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.MdiParent = this;
            u.Show();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = SingleUser.Usuario.Nombres;
           
            cargarMenu(menuStrip1.Items);
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AgregarMedicamentos im = new AgregarMedicamentos();
            im.MdiParent = this;
            im.Show();
              
           

        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           ListadeMedicamentos li = new ListadeMedicamentos();
            li.MdiParent=this;
            li.Show();
        }

        private void agregarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarRolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles r = new Roles();
            r.MdiParent = this;
            r.Show();
        }

        private void cargarMenu(ToolStripItemCollection Opciones)
        {




            List<usuariomenu> lista = controladorMenu.ListarMenu(/*SingleUser.Usuario.Idrol*/2);

            List<string> menu = new List<string>();
           
            foreach (var item in lista)
            {
               
                menu.Add(item.idmenu.ToString());
               
            }
           

                foreach (ToolStripMenuItem opcion in Opciones)
            {

                bool encontrado = menu.Contains(opcion.Tag.ToString());
                if (encontrado == false)
                {
                    opcion.Visible = false;
                }

                if (opcion.DropDownItems != null)
                {
                    this.cargarMenu(opcion.DropDownItems);
                }
            }
        }

        private void indice1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void consultaGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void pacientesIngresadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Internados i = new Internados();
            i.Show();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarEmpleado be = new BuscarEmpleado();
            be.MdiParent = this;
          
            be.Show();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
            if (Enfermedades.DefInstance == null) {
                Enfermedades en = new Enfermedades();
                en.MdiParent = this;
                Enfermedades.DefInstance = en;
                en.Show();
            }else{
            Enfermedades.DefInstance.Show();
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (ListaPacientes.DefInstance != null)
            {
                ListaPacientes.DefInstance.Focus();
            }
            else {
                ListaPacientes pacientes = new ListaPacientes();
                pacientes.MdiParent = this;
                ListaPacientes.DefInstance = pacientes;
                pacientes.Show();
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void programarCitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.Show();
           
        }

        private void combitoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void combitoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            /*combito c = new combito();
            c.Show();*/
            AgregarMedicamentos am = new AgregarMedicamentos();
            am.MdiParent = this;
            am.Show();
        }

        private void verMédicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaMedicos lm = new ListaMedicos();
            lm.MdiParent = this;
            lm.Show();
        }

        private void examenesRealizadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AgregarLoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void agregarMedicamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar_A_Inventario ai = new Agregar_A_Inventario();
            ai.MdiParent = this;
            ai.Show();
        }

        private void sintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Sintomas.DefInstance == null)
            {
                Sintomas s = new Sintomas();
                s.MdiParent = this;
                Sintomas.DefInstance = s;
                s.Show();
            }
            else {
                Sintomas.DefInstance.Show();
            }
        }

        private void verInventariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eliminarMedicamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarInventario mi = new MostrarInventario();
            mi.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.Show();
        }
    }
}
