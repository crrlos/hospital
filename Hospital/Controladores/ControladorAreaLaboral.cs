using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Modelo;
using Hospital.Conexion;

namespace Hospital.Controladores
{
    class ControladorAreaLaboral
    {
       

        public List<area_Laboral> listararea_Laboral()
        {
            List<area_Laboral> d;
            try
            {
                Model model = new Conexion.Model();
                d = model.Entidades.area_Laboral.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return d;
        }

    }
}
