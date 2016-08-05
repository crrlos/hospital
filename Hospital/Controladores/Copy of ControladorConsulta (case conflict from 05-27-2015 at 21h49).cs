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

        public consulta retornarRegistros(int id) {
            Model model = new Model();

            List<consulta> registros = new List<consulta>();
            registros = model.Entidades.consulta.Where(a => a.idpaciente == id).ToList(); ;


        }

    }
}
