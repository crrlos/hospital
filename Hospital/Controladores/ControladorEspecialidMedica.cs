using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Controladores;
using Hospital.Modelo;
using Hospital.Conexion;
namespace Hospital.Controladores
{
    class ControladorEspecialidMedica
    {



        public List<especialidadmedicos> ListarEspecialidad()
        {
            
            List<especialidadmedicos> s;
            try
            {
                Model model = new Conexion.Model();
                s = model.Entidades.especialidadmedicos.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return s;
        }
    }
}
