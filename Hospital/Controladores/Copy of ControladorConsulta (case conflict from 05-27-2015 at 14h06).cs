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
        Model model = new Model();
        public bool insertarConsulta(consulta c) {
            try {
                model.Entidades.consulta.Add(c);
                model.Entidades.SaveChanges();
            
            
            
            }
            catch (Exception e) {
                return false;
            }



            return true;
        }

    }
}
