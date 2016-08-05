using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Modelo;

using Hospital.Conexion;


namespace Hospital.Controladores
{
    class ControladorUnidadmedida
    {


        public bool insertarUnidad(unidades d)
        {

            try
            {
                Model model = new Model();
                model.Entidades.unidades.Add(d);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<unidades> listarUnidad()
        {
            List<unidades> d;
            try
            {
                Model model = new Conexion.Model();
                d = model.Entidades.unidades.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return d;
        }
        public bool modificarUnidades(int id, unidades d)
        {
            try
            {
                Model model = new Model();
                unidades original = model.Entidades.unidades.Find(id);
                original.unidad = d.unidad; 
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }






    }
}
