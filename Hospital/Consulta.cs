using System;
using System.Collections.Generic;
using System.Collections;
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
using System.Reflection;
using Hospital.Validaciones;




namespace Hospital
{



    public partial class Consulta : Form
    {


        private static Consulta defInstance; // variable estatica para determinar si ya existe la instancia

        public static Consulta DefInstance
        {
            get { return Consulta.defInstance; }
            set { Consulta.defInstance = value; }
        }

   
        List<enfermedades> enfermedad;//lista usada para los diagnosticos
        List<sintomas> sintoma;// lista usada para los sintomas
        List<subcategoria_examen> tipoExamen;
        List<inventario_medicamentos> recetadoinv;
        List<medicamentosrecetados> medicamentoreceta;
        private bool seleccionNegrita;
        private int idpaciente;
        private int idINV = 0;
        private int idIMdetalle=0;
        private int idinvmedicamentos = 0;
        private int idinventario=0;
        ControladorConsulta controladorConsulta;
        Controladormedicamentorecetado controladorecetado;
        ControladorInventarioMedicamentos controladorinventario;
        private int idconsult = 0;
        List<detallemedicamentos_recetados> detallemedrecetados;
        public Consulta(DataGridViewRow fila)
        {
            InitializeComponent();
           
            
            detallemedrecetados = new List<detallemedicamentos_recetados>();
            enfermedad = new List<enfermedades>();
            sintoma = new List<sintomas>();
            recetadoinv = new List<inventario_medicamentos>();
            seleccionNegrita = false;
            idpaciente = (int)fila.Cells[0].Value;
            controladorConsulta = new ControladorConsulta();

            tipoExamen = new List<subcategoria_examen>();
              medicamentoreceta=  new List<medicamentosrecetados>();
            //configuracion del datagrid sintomas
            dataGridView2.ColumnCount = 1;
            dataGridView2.Columns[0].Name = "Síntomas";
            dataGridView2.Columns[0].Width = 500;
            dataGridView2.Columns[0].DataPropertyName = "sintoma";



            dataGridView2.AutoGenerateColumns = false;
            //config dtmedicamentos

            dtMedicamentos.ColumnCount = 2;
            
           dtMedicamentos.Columns[0].Width = 20;
           dtMedicamentos.Columns[0].DataPropertyName = "idIM";
           dtMedicamentos.Columns[1].DataPropertyName = "nombreMedicamento";
           dtMedicamentos.Columns[1].Width = 200;
          
            dtMedicamentos.AutoGenerateColumns = false;
/*

            dtMedicamentos.Columns[4].Width = 50;
            dtMedicamentos.Columns[4].DataPropertyName = "idIM"; */

            //configuracion datagrid diagnostico



            dataGridView1.ColumnCount = 2;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.Columns[0].Name = "Nombre Enfermedad";
            dataGridView1.Columns[0].Width = 500;
            dataGridView1.Columns[0].DataPropertyName = "nombre";

            dataGridView1.Columns[1].Name = "código";
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[1].DataPropertyName = "codigo";



            consultaNombre.Text = fila.Cells[1].Value + " " + fila.Cells[2].Value;


            //datagrid examenes

            dataGridView3.ColumnCount = 1;
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.Columns[0].Name = "Examen";
            dataGridView3.Columns[0].Width = 600;
            dataGridView3.Columns[0].DataPropertyName = "Examen";

            llenarComboTipoExamen();

        }




        private void button1_Click(object sender, EventArgs e)
        {
            buscarEnfermedades be = new buscarEnfermedades();
            be.ShowDialog();
            if (be.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                bool existe = false;

                foreach (var item in enfermedad)
                {
                    if (item.codigo == be.Enfermedad.codigo)
                    {
                        existe = true;
                        break;
                    }
                }


                if (!existe)
                {
                    enfermedad.Add(be.Enfermedad);

                }

            }
            be.Dispose();
            cargarGrid();
        }


        //eliminacion de un sintoma
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                sintoma.RemoveAt(dataGridView2.CurrentRow.Index);

                dataGridView2.Rows.RemoveAt(dataGridView2.CurrentRow.Index);

            }
            catch (Exception) { }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                enfermedad.RemoveAt(dataGridView1.CurrentRow.Index);
                cargarGrid();
            }
            catch (Exception)
            {

            }

        }
        private void cargarGrid()
        {

            dataGridView2.DataSource = sintomas();
            dataGridView1.DataSource = enfermedades();

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }


       

        private void button4_Click(object sender, EventArgs e)
        {
            buscarSintomas bs = new buscarSintomas();
            bs.ShowDialog(this);
            if (bs.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                bool existe = false;

                foreach (var item in sintoma)
                {
                    if (item.idsintoma == bs.Sintoma.idsintoma)
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    sintoma.Add(bs.Sintoma);
                    cargarGrid();
                }

            }

        }

        private void Consulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Consulta.DefInstance = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            seleccionNegrita = !seleccionNegrita;
            if (seleccionNegrita)
            {
                btnNegrita.BackColor = System.Drawing.SystemColors.ActiveCaption;

            }
            else
            {
                btnNegrita.BackColor = System.Drawing.SystemColors.ButtonFace;

            }
            richTextBox1.Focus();
            ToggleBold();
        }

        private void ToggleBold()
        {

            System.Drawing.Font currentFont = richTextBox1.SelectionFont;
            System.Drawing.FontStyle newFontStyle;

            if (richTextBox1.SelectionFont.Bold == true) { newFontStyle = FontStyle.Regular; }
            else { newFontStyle = FontStyle.Bold; }

            richTextBox1.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, newFontStyle);


        }



        private void cambiaColor()
        {


            richTextBox1.SelectionColor = button5.BackColor;




        }




        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {



            if ((int)e.KeyChar == 14)
            {
                button5_Click(null, null);
            }


        }





        private void Consulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 14)
            {
                button5_Click(null, null);
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.FlatAppearance.BorderColor = Color.SteelBlue;
            button5.FlatAppearance.BorderSize = 2;

            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderColor = Color.White;

            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderColor = Color.White;

            richTextBox1.SelectionColor = button5.BackColor;
            richTextBox1.Focus();
            richTextBox1.Select(richTextBox1.Text.Length, 0);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.FlatAppearance.BorderColor = Color.SteelBlue;
            button6.FlatAppearance.BorderSize = 2;

            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderColor = Color.White;

            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderColor = Color.White;

            richTextBox1.SelectionColor = button6.BackColor;
            richTextBox1.Focus();
            richTextBox1.Select(richTextBox1.Text.Length, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {


            button7.FlatAppearance.BorderColor = Color.SteelBlue;
            button7.FlatAppearance.BorderSize = 2;

            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderColor = Color.White;

            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderColor = Color.White;

            richTextBox1.SelectionColor = button7.BackColor;

            richTextBox1.Focus();
            richTextBox1.Select(richTextBox1.Text.Length, 0);
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {

            button5.FlatAppearance.BorderColor = Color.SteelBlue;
            button5.FlatAppearance.BorderSize = 2;

            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderColor = Color.White;

            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderColor = Color.White;

            richTextBox1.SelectionColor = button5.BackColor;

            richTextBox1.Focus();

            richTextBox1.Select(richTextBox1.Text.Length, 0);



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            consulta c = new consulta();
            c.idmedico = 12;
            c.idpaciente = idpaciente;
            c.observaciones = richTextBox1.Rtf;
            c.fecha = DateTime.Now;
           
          
            if (controladorConsulta.insertarConsulta(c))
            {

                Model model = new Model();



                consulta consulta = new consulta();

                consulta = model.Entidades.consulta.Where(a => a.idpaciente == idpaciente && a.idmedico == 12).ToList().Last();
                //inserción de los diagnosticos
                diagnostico dg = new diagnostico();
                idconsult = consulta.idconsulta;
               
                foreach (var item in enfermedad)
                {

                  
                    dg.idconsulta = consulta.idconsulta;
                    dg.idenfermedad = item.idenfermedad;
                    dg.correcto = true;
                    model.Entidades.diagnostico.Add(dg);

                    try
                    {
                        model.Entidades.SaveChanges();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    }
                }//fin inserción diagnosticos

                //inserción síntomas
                pacientesintomas ps = new pacientesintomas();
                foreach (var item in sintoma)
                {

                    ps.idconsulta = consulta.idconsulta;
                    ps.idsintoma = item.idsintoma;
                    model.Entidades.pacientesintomas.Add(ps);


                    try
                    {
                        model.Entidades.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.InnerException.ToString());
                    }
                   
                }//fin inserción diagnosticos


                //inserción de los examenes

                examenespendientes ep = new examenespendientes();
                foreach (var item in tipoExamen)
                {
                    ep.idconsulta = consulta.idconsulta;
                    ep.idsubcategoria = item.idsubcategoria_examen;
                    ep.estado = false;
                    model.Entidades.examenespendientes.Add(ep);
                    model.Entidades.SaveChanges();

                }
                //fin insercion examenes

                medicamentosrecetados mr = new medicamentosrecetados();
                foreach (var item in detallemedrecetados)
                {
                   
                    mr.idconsulta = consulta.idconsulta;
                    mr.id_detalle = item.id_detalle;
                    
                    model.Entidades.medicamentosrecetados.Add(mr);
                    model.Entidades.SaveChanges();

                }
                MessageBox.Show(mr.idconsulta.ToString() + " " + mr.id_detalle.ToString());

                //fin insercion medicamentos

                MessageBox.Show("Registro guardado");
            }
            else
            {
                MessageBox.Show("algo fallo");
            }


        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private DataTable sintomas()
        {

            DataTable sintomas = new DataTable();
            sintomas.Columns.Add("idsintoma");
            sintomas.Columns.Add("sintoma");

            foreach (var item in sintoma)
            {
                sintomas.Rows.Add(item.idsintoma, item.sintoma);
            }


            return sintomas;
        }



        private DataTable enfermedades()
        {

            DataTable enfermedades = new DataTable();
            enfermedades.Columns.Add("idenfermedad");
            enfermedades.Columns.Add("nombre");
            enfermedades.Columns.Add("codigo");

            foreach (var item in enfermedad)
            {
                enfermedades.Rows.Add(item.idenfermedad, item.nombre, item.codigo);
            }


            return enfermedades;
        }

        private void Consulta_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void llenarComboTipoExamen()
        {

            ControladorExamenes controladorExamenes = new ControladorExamenes();
            foreach (var item in controladorExamenes.listarCategoria())
            {
                cmbtipoExamen.Items.Add(item.nombrecategoria);
            }



        }

        private void tablaExamenes()
        {

            DataTable examenes = new DataTable();
            examenes.Columns.Add("Examen");


            foreach (var item in tipoExamen)
            {
                examenes.Rows.Add(item.nombresubcategoria);
            }

            dataGridView3.DataSource = examenes;
            dataGridView3.ClearSelection();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Model model = new Model();
            ControladorExamenes controladorExamenes = new ControladorExamenes();
            subcategoria_examen sex = new subcategoria_examen();
            sex = controladorExamenes.listarExamen(cmbexamen.SelectedItem.ToString());




            if (tipoExamen.Where(a => a.nombresubcategoria.Equals(sex.nombresubcategoria)).ToList().Count == 0)
            {
                tipoExamen.Add(sex);
            }
            tablaExamenes();
        }

        private void cmbtipoExamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbexamen.Items.Clear();
            ControladorExamenes controladorExamenes = new ControladorExamenes();
            
            Model model = new Model();
            string idcat = cmbtipoExamen.SelectedItem.ToString();
            categoria_examen ce = model.Entidades.categoria_examen.Single(a => a.nombrecategoria.Equals(idcat));

            foreach (var item in controladorExamenes.listarSubcategoria(ce.idcategoria))
            {
                cmbexamen.Items.Add(item.nombresubcategoria);
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                tipoExamen.RemoveAt(dataGridView3.CurrentRow.Index);
                dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);

            }
            catch (Exception) { }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        /*
        private void cargarVuelos()
        {
            Model model = new Model();
            var datos = from v in model.Entidades.inventario_medicamentos
                         select new
                         {
                             idIM = v.idIM,
                             nombreMedicamento = v.nombreMedicamento,
                             nombreLaboratorio = v.laboratorios_farmaceuticos.nombreLaboratorio,
                             Forma = v.presentacionmedicamento.Forma,
                             unidad = v.unidades.un

                         };
          dtMedicamentos.DataSource = datos.ToList();
        } 
        private void crearlista()
        {
            Model modelo = new Model();
            var datos = modelo.Entidades.inventario_medicamentos.Select(a => new
            {
                a.idIM,
                a.nombreMedicamento,
                a.laboratorios_farmaceuticos.nombreLaboratorio,
                a.presentacionmedicamento.Forma,
                a.cantidad_concentracion,
                a.unidades.unidad,

            }).Where(a => a.idIM.Equals(idINV)).ToList();

            DataTable recetadodata = new DataTable();
            recetadodata.Columns.Add("idIM");
            recetadodata.Columns.Add("nombreMedicamento");
            recetadodata.Columns.Add("nombreLaboratorio");
            recetadodata.Columns.Add("Forma");
            recetadodata.Columns.Add("unidad");



            foreach (var item in datos)
            {
                recetadodata.Rows.Add(item.idIM, item.nombreMedicamento, item.nombreLaboratorio, item.Forma, item.unidad);
            }
            dtMedicamentos.DataSource = recetadodata;

        }
        */

        private DataTable recetadotable() {
            DataTable recetadodata = new DataTable();
            recetadodata.Columns.Add("idIM");
            recetadodata.Columns.Add("nombreMedicamento");
           
            
           
            foreach (var item in recetadoinv)
            {
                recetadodata.Rows.Add(item.idIM,item.nombreMedicamento);
                    
            } 
            return recetadodata;
        
        }

   /*     private void cargargridMedicamentos()
        {
            Model modelo = new Model();

            var datos = modelo.Entidades.medicamentosrecetados.Select(a => new
            {
               id=  a.idIM,
                medicamento = a.inventario_medicamentos.nombreMedicamento,
                cantidad=a.cantidadrecetada,
               laboratorio= a.inventario_medicamentos.laboratorios_farmaceuticos.nombreLaboratorio,
                forma = a.inventario_medicamentos.presentacionmedicamento.Forma,
                concentracion= a.inventario_medicamentos.cantidad_concentracion,
                unidades=a.inventario_medicamentos.unidades.unidad
               
            }).ToList();
            dtMedicamentos.DataSource = datos;
        }
 */

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*
            MedicamentosDisponibles lm = new MedicamentosDisponibles();
          

            lm.ShowDialog(this);


            if (lm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                bool existe = false;

                foreach (var item in recetadoinv)
                {
                    if (item.idIM == lm.Recetado.idIM)
                    {
                        existe = true;
                        break;

                    }
                }

                if (!existe)
                {
                    recetadoinv.Add(lm.Recetado);

                    idINV = lm.Recetado.idIM;
                    idinvmedicamentos = lm.Recetado.idIM;
                    dtMedicamentos.DataSource = recetadotable();
                    dtMedicamentos.ClearSelection();
                   
                    
                }

               
            }
            */
           
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            /* CODIGO UTIL 
 
    Int32 selectedRowCount =
       dtMedicamentos.Rows.GetRowCount(DataGridViewElementStates.Selected);
    if (selectedRowCount > 0)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 0; i < selectedRowCount; i++)
        {
            sb.Append("Fila: ");
            sb.Append(dtMedicamentos.SelectedRows[i].Index.ToString());
            sb.Append(Environment.NewLine);
        }

        sb.Append("Total: " + selectedRowCount.ToString());
        MessageBox.Show(sb.ToString(), "Filas sEleccionadas");
    }
            
        string cadena = "";
        cadena = dtMedicamentos.CurrentRow.Cells[1].Value.ToString();
        MessageBox.Show(cadena);
            */

            try
            {
                recetadoinv.RemoveAt(dtMedicamentos.CurrentRow.Index);
                dtMedicamentos.Rows.RemoveAt(dtMedicamentos.CurrentRow.Index);

            }
            catch (Exception) { }

        }

        private void dtMedicamentos_SelectionChanged(object sender, EventArgs e)
        {
          


        }

        private void dtMedicamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
    

                

               
            
        }

        private bool validar()
        {
            if (txtCantidad.Text.Length == 0 || txtDosis.Text.Length==0)
            {
                MessageBox.Show("hay campos vacios");
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validar())
            {


            }
            else
            {

                Model model = new Model();
                detallemedicamentos_recetados dm = new detallemedicamentos_recetados();
                inventario_medicamentos invm = new inventario_medicamentos();

                dm.idIM = int.Parse(dtMedicamentos.CurrentRow.Cells[0].Value.ToString());
                dm.cantidadrecetada = int.Parse(txtCantidad.Text);
                dm.dosis = txtDosis.Text;
                model.Entidades.detallemedicamentos_recetados.Add(dm);

                model.Entidades.SaveChanges();
                controladorinventario = new ControladorInventarioMedicamentos();

                invm = model.Entidades.inventario_medicamentos.Single(a => a.idIM.Equals(dm.idIM));
                invm.cantidad_unidad=(invm.cantidad_unidad-dm.cantidadrecetada);
                idinventario = int.Parse(dtMedicamentos.CurrentRow.Cells[0].Value.ToString());

                if (invm.cantidad_unidad < 0)
                {
                    invm.cantidad_unidad = 0;
                }
                controladorinventario.ActualizarCantidadInv(idinventario,invm);


                
              /*  MessageBox.Show(dm.id_detalle.ToString() + "cant" + dm.cantidadrecetada.ToString(),dm.dosis.ToString());*/

                bool existe = false;

                foreach (var item in detallemedrecetados)
                {
                    if (item.id_detalle==int.Parse(dtMedicamentos.CurrentRow.Cells[0].Value.ToString()))
                    {
                        existe = true;

                        break;
                    }
                }

                if (!existe)
                {
                    detallemedrecetados.Add(dm);
                   
                }
   
               
            
           
        }
           /* foreach (var item in detallemedrecetados)
            {
                MessageBox.Show(item.id_detalle.ToString() + " " + item.idIM.ToString());
            }*/
            txtCantidad.Text = "";
            txtDosis.Text = "";
            }
        

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
                Validar v = new Validar();
            v.validaSoloNumero( e);
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {

            /*
            //inserción de los examenes
            Model model = new Model();
            examenespendientes ep = new examenespendientes();
            foreach (var item in tipoExamen)
            {
                ep.idconsulta = idconsult;
                ep.idsubcategoria = item.idsubcategoria_examen;
                ep.estado = false;
                model.Entidades.examenespendientes.Add(ep);
                model.Entidades.SaveChanges();
                MessageBox.Show("OK");
            */

            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void cmbexamen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtMedicamentos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }








    }
}
