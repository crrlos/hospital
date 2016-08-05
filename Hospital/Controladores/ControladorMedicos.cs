using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorMedicos
    {


        public bool insertarMedico(medicos p)
        {



            try
            {
                Model model = new Model();
                model.Entidades.medicos.Add(p);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


       
        public List<medicos> ListarMedico()
        {
            List<medicos> s;
            try
            {
                Model model = new Conexion.Model();
                s = model.Entidades.medicos.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return s;
        }


        public bool eliminarMedicos(int id)
        {

            try
            {
                Model model = new Model();
                medicos original = model.Entidades.medicos.Find(id);
                model.Entidades.medicos.Remove(original);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }



        public bool modificarMedicos(int id,medicos pac)
        {
            try
            {
                Model model = new Model();
                medicos original = model.Entidades.medicos.Find(id);
                original.JVPM = pac.JVPM;
                original.idespecialidad= pac.idespecialidad;
                original.id_arealaboral = pac.id_arealaboral;
                
                original.idempleado = pac.idempleado;



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
