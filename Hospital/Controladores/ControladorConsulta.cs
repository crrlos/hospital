using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorConsulta
    {
        
        public bool insertarConsulta(consulta c) {
            Model model = new Model();
            try {
                model.Entidades.consulta.Add(c);
                model.Entidades.SaveChanges();
            
            
            
            }
            catch (Exception e) {
                return false;
            }


            model.cerrarConexion();
            return true;
        }

        public List<consulta> retornarRegistros(int id) {
            Model model = new Model();

            List<consulta> registros = new List<consulta>();

            registros = model.Entidades.consulta.Where(a => a.idpaciente == id).ToList();

            return registros;


        }
        public List<sintomas> retornarSintomas(int id) {
            Model model = new Model();

            List<pacientesintomas> registros = new List<pacientesintomas>();

            registros = model.Entidades.pacientesintomas.Where(a => a.idconsulta == id).ToList();

            List<sintomas> sintomas = new List<sintomas>();

            sintomas s = new sintomas();
            foreach (var item in registros)
            {
                s = model.Entidades.sintomas.Single(a => a.idsintoma == item.idsintoma);
                sintomas.Add(s);
            }


            return sintomas;
        
        }

        

        public List<enfermedades> retornarDiagnostico(int id)
        {
            Model model = new Model();

            List<diagnostico> registros = new List<diagnostico>();

            registros = model.Entidades.diagnostico.Where(a => a.idconsulta == id).ToList();

            List<enfermedades> enfermedad = new List<enfermedades>();

            enfermedades e = new enfermedades();
            foreach (var item in registros)
            {
                e = model.Entidades.enfermedades.Single(a => a.idenfermedad == item.idenfermedad);
                enfermedad.Add(e);
            }


            return enfermedad;

        }
        public string retornarPaciente(int id) {
            Model model = new Model();
            pacientes paciente = new pacientes();
            paciente = model.Entidades.pacientes.Single(a => a.idpaciente == id);
            return paciente.nombres+ " "+paciente.apellidos;

        }
        public string retornarMedico(int id)
        {
            Model model = new Model();
            medicos medico = new medicos();
            medico = model.Entidades.medicos.Single(a => a.idmedico == id);
            empleados emp = new empleados();
            emp = model.Entidades.empleados.Single(a => a.idempleado == medico.idempleado);
            return emp.nombres + " " + emp.apellidos;

        }

    }
}
