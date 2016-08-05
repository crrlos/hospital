using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorEnfermedades
    {


        public bool insertarEnfermedad(enfermedades e)
        {

            try
            {
                Model model = new Model();
                model.Entidades.enfermedades.Add(e);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        

        public bool eliminarEnfermedad(int id)
        {

            try
            {
                Model model = new Model();
               enfermedades original = model.Entidades.enfermedades.Find(id);
                model.Entidades.enfermedades.Remove(original);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public bool modificarEnfermedad(int id, enfermedades e)
        {
            try
            {
                Model model = new Model();
                enfermedades original = model.Entidades.enfermedades.Find(id);
                original.nombre = e.nombre;
                original.codigo = e.codigo;
               

                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }


        public List<enfermedades> ListarEnfermedades(string criterio)
        {
            List<enfermedades> e;
            try
            {
                Model model = new Model();
                e = model.Entidades.enfermedades.Where(a => a.nombre.Contains(criterio)).ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return e;
        }

        public List<enfermedades> ListarEnfermedades()
        {
            List<enfermedades> e;
            try
            {
                Model model = new Conexion.Model();
                e = model.Entidades.enfermedades.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return e;
        }

    }
}
