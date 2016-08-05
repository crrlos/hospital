using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorCargo
    {

        public List<cargos> listarCargos()
        {
            List<cargos> c;
            try
            {
                Model model = new Model();
                c = model.Entidades.cargos.ToList(); 
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return c;
        }
    }
}
