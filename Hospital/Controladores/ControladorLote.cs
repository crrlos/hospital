using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Modelo;
using Hospital.Controladores;
using Hospital.Conexion;

namespace Hospital.Controladores
{
    class ControladorLote
    {


        public List<Lote_Medicamentos> listarlotes()
        {
            List<Lote_Medicamentos> d;
            try
            {
                Model model = new Conexion.Model();
                d = model.Entidades.Lote_Medicamentos.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return d;
        }


        public bool insertarLote(Lote_Medicamentos p)
        {



            try
            {
                Model model = new Model();
                model.Entidades.Lote_Medicamentos.Add(p);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public bool eliminarLote(int id)
        {

            try
            {
                Model model = new Model();
            Lote_Medicamentos original = model.Entidades.Lote_Medicamentos.Find(id);
                model.Entidades.Lote_Medicamentos.Remove(original);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }



        public bool modificarLote(int id, Lote_Medicamentos lm)
        {
            try
            {
                Model model = new Model();
                Lote_Medicamentos original = model.Entidades.Lote_Medicamentos.Find(id);
                original.codigoLote = lm.codigoLote;
                original.fecha_vencimiento = lm.fecha_vencimiento;

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
