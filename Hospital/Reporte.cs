using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital.ServiceReference1;

namespace Hospital
{
    public partial class Reporte : Form
    {


        servicioClient servicio;
        Reportes.reporte rep;

        int enfermedad = 0;

        public Reporte()
        {
            InitializeComponent();
            servicio = new servicioClient();
            rep = new Reportes.reporte();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
          


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            Controladores.ControladorDepartamentos control = new Controladores.ControladorDepartamentos();

            foreach (var item in control.listarDepartamentos())
            {

                comboBox1.Items.Add(item.nombredepartamento);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0) {
               
                    rep.SetDataSource(servicio.operation(comboBox1.SelectedIndex + 1, enfermedad));
               
                

                crystalReportViewer1.ReportSource = rep;
                crystalReportViewer1.RefreshReport();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            buscarEnfermedades be = new buscarEnfermedades();
            be.ShowDialog();
            if (be.DialogResult == System.Windows.Forms.DialogResult.OK)
            {

                textBox1.Text = be.Enfermedad.nombre;
                enfermedad = be.Enfermedad.idenfermedad;

                if (comboBox1.SelectedItem != "") {
                   
                        rep.SetDataSource(servicio.operation(comboBox1.SelectedIndex + 1, enfermedad));
                   


                    crystalReportViewer1.ReportSource = rep;
                    crystalReportViewer1.RefreshReport();
                
                }

            }

        }
    }
}
