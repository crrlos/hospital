using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorRoles
    {
        public bool insertarRol(roles r)
        {

            try
            {
                Model model = new Model();
                model.Entidades.roles.Add(r);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<roles> listarRoles()
        {
            List<roles> r;
            try
            {
                Model model = new Conexion.Model();
                r = model.Entidades.roles.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return r;
        }

        public bool eliminarRol( int id)
        {

            try
            {
                Model model = new Model();
                roles original = model.Entidades.roles.Find(id);
                model.Entidades.roles.Remove(original);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public List<roles> ListarRoles(string criterio)
        {
            List<roles> r;
            try
            {
                Model model = new Conexion.Model();
                r= model.Entidades.roles.Where(e => e.rol.Contains(criterio)).ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return r;
        }



    }
}
