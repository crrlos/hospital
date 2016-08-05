using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Modelo;
using Hospital.Conexion;

namespace Hospital.Controladores
{
    class ControladorMunicipio
    {
        

        public List<municipios> listarMunicipios(int id)
        {
            List<municipios> m;
            List<municipios> me;
            
            try
            {
                Model model = new Conexion.Model();
                m = model.Entidades.municipios.Where(a => a.id_departamento == id).ToList(); ;
                me = model.Entidades.municipios.ToList();
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
