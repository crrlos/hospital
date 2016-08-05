using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorExamenes
    {
        public List<categoria_examen> listarCategoria()
        {
            List<categoria_examen> d;
            try
            {
                Model model = new Conexion.Model();
                d = model.Entidades.categoria_examen.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return d;
        }






        public List<subcategoria_examen> listarSubcategoria(int id)
        {
            List<subcategoria_examen> m;
            try
            {
                Model model = new Conexion.Model();
                m = model.Entidades.subcategoria_examen.Where(a => a.idcategoria == id).ToList(); ;
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return m;
        }

        public subcategoria_examen listarExamen(string id)
        {
            Model model = new Model();
            subcategoria_examen examen = new subcategoria_examen();
            examen = model.Entidades.subcategoria_examen.Single(a=> a.nombresubcategoria.Equals(id));

            return examen;
            

        }



    }
}
