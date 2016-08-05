using Hospital.Conexion;
using Hospital.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Controladores
{
    class ControladorSintomas
    {
        public List<sintomas> ListarSintomas(string criterio)
        {
            List<sintomas> s;
            try
            {
                Model model = new Model();
                s = model.Entidades.sintomas.Where(a => a.sintoma.Contains(criterio)).ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return s;
        }

        public List<sintomas> ListarSintomas()
        {
            List<sintomas> s;
            try
            {
                Model model = new Conexion.Model();
                s = model.Entidades.sintomas.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return s;
        }
        public bool insertarSintoma(sintomas s) {

            try
            {

                Model model = new Model();
                model.Entidades.sintomas.Add(s);
                model.Entidades.SaveChanges();
                actualizar();
                return true;
            }
            catch (Exception ex) { return false; }


        }

        public bool actualizarSintoma(int id, sintomas s) {

            try
            {

                Model model = new Model();

                sintomas original = model.Entidades.sintomas.Find(id);
                original.sintoma = s.sintoma;

                model.Entidades.SaveChanges();
                actualizar();

                model.cerrarConexion();

                return true;


            }
            catch (Exception e) { return false; }

        
        }

        private void actualizar() {

            try
            {
                Model m = new Model();
                sinversion s = m.Entidades.sinversion.First();
                int n = s.dbversion;
                m.Entidades.sinversion.Remove(s);
                m.Entidades.SaveChanges();
                s.dbversion = n +1;
                m.Entidades.sinversion.Add(s);
                m.Entidades.SaveChanges();
                m.cerrarConexion();

              


            }
            catch (Exception e) { }
        
        }

        public bool eliminarSintoma(int id) {

            try {
                Model model = new Model();
                sintomas s = model.Entidades.sintomas.Find(id);
                model.Entidades.sintomas.Remove(s);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
                actualizar();
                return true;
            }catch(Exception e){return false;}
        
        }

       /* private void cambiar() {
            try {
                Model model = new Model();
                int id = 0;
                sinversion s = model.Entidades.sinversion.First();
                id = s.dbversion;

                model.Entidades.sinversion.Remove(s);
                model.Entidades.SaveChanges();
                s.dbversion = id + 1;
                model.Entidades.sinversion.Add(s);
            
            }
            catch (Exception e) { }
        
        
        }*/
    }
}
