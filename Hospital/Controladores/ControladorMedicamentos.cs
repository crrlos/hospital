using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Controladores;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorMedicamentos
    {




        public List<Medicamentos> ListarMedicamentos()
        {
            List<Medicamentos> e;
            try
            {
                Model model = new Conexion.Model();
                e = model.Entidades.Medicamentos.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return e;
        }
        public List<proveedores> ListarFabricante()
        {
            List<proveedores> e;
            try
            {
                Model model = new Conexion.Model();
                e = model.Entidades.proveedores.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return e;
        }

        
        public bool insertarMedicamento(Medicamentos im)
        {

            try
            {
                Model model = new Model();
                model.Entidades.Medicamentos.Add(im);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool eliminarMedicamentos(int id)
        {

            try
            {
                Model model = new Model();
                Medicamentos original = model.Entidades.Medicamentos.Find(id);
                model.Entidades.Medicamentos.Remove(original);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool modificarMedicamento(int id, Medicamentos inv)
        {
            try
            {
                Model model = new Model();
                Medicamentos original = model.Entidades.Medicamentos.Find(id);
                original.nombreMedicamento = inv.nombreMedicamento;
               
                original.presentacion = inv.presentacion;

               


                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public bool ActualizarExistenciaMedicamento(int id, detallemedicamentos_recetados dm)
        {
            try
            {
                Model model = new Model();
                Medicamentos original = model.Entidades.Medicamentos.Find(id);

                


                 model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }


        public List<Medicamentos> ListarMedicamentoscriterio(string criterio)
        {
            List<Medicamentos> e;
            try
            {
                Model model = new Model();
                e = model.Entidades.Medicamentos.Where(a => a.nombreMedicamento.Contains(criterio)).ToList();
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
