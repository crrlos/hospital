using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Modelo;
using Hospital.Controladores;
using Hospital.Conexion;

namespace Hospital.Controladores
{
    class ControladorPresentacion
    {


        public List<presentacionmedicamento> listarPresentacion(int idunidad)
        {
            List<presentacionmedicamento> m;
            try
            {
                Model model = new Conexion.Model();
                m = model.Entidades.presentacionmedicamento.Where(a => a.idunidades == idunidad).ToList(); 
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return m;
        }


    }
}
