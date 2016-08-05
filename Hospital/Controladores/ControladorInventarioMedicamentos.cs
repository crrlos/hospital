using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    public class ControladorInventarioMedicamentos
    {



        public List<InventarioMedicamentos> listarInv()
        {
            List<InventarioMedicamentos> im;
            try
            {
                Model model = new Conexion.Model();
               im = model.Entidades.InventarioMedicamentos.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return im;
        }


        public bool insertarAinventario(InventarioMedicamentos im)
        {

            try
            {
                Model model = new Model();
                model.Entidades.InventarioMedicamentos.Add(im);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool eliminarInv(int id)
        {

            try
            {
                Model model = new Model();
               InventarioMedicamentos original = model.Entidades.InventarioMedicamentos.Find(id);
                model.Entidades.InventarioMedicamentos.Remove(original);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public bool modificarInv(int id, InventarioMedicamentos inv)
        {
            try
            {
                Model model = new Model();
           InventarioMedicamentos original = model.Entidades.InventarioMedicamentos.Find(id);
           
           original.CodLote = inv.CodLote;
           



                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public bool ActualizarCantidadInv(int id, inventario_medicamentos inv)
        {
            try
            {
                Model model = new Model();
                inventario_medicamentos original = model.Entidades.inventario_medicamentos.Find(id);

                original.cantidad_unidad = inv.cantidad_unidad;
                


                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public List<inventario_medicamentos> ListarInv(string criterio)
        {
            List<inventario_medicamentos> e;
            try
            {
                Model model = new Model();
                e = model.Entidades.inventario_medicamentos.Where(a => a.nombreMedicamento.Contains(criterio)).ToList();
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
