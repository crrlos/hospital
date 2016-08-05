using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;


namespace Hospital.Controladores
{
    class ControladorDepartamentos
    {
        public bool insertarDepartamento(departamentos d)
        {

            try
            {
                Model model = new Model();
                model.Entidades.departamentos.Add(d);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public List<departamentos> listarDepartamentos()
        {
            List<departamentos> d;
            try
            {
                Model model = new Conexion.Model();
               d = model.Entidades.departamentos.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return d;
        }

        public bool eliminarDepartamento(int id)
        {

            try
            {
                Model model = new Model();
                departamentos original = model.Entidades.departamentos.Find(id);
                model.Entidades.departamentos.Remove(original);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool modificarDepartamento(int id, departamentos d)
        {
            try
            {
                Model model = new Model();
                departamentos original = model.Entidades.departamentos.Find(id);
                original.nombredepartamento = d.nombredepartamento;
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
