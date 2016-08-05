using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorLaboratoriosFarma
    {


        public List<laboratorios_farmaceuticos> listarlabid(int id)
        {
            List<laboratorios_farmaceuticos> lf;
            try
            {
                Model model = new Conexion.Model();
                lf = model.Entidades.laboratorios_farmaceuticos.Where(a => a.idlaboratorio == id).ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return lf;
        }



        public List<laboratorios_farmaceuticos> listarlab()
        {
            List<laboratorios_farmaceuticos> lf;
            try
            {
                Model model = new Conexion.Model();
                lf = model.Entidades.laboratorios_farmaceuticos.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return lf;
        }
    }
}
