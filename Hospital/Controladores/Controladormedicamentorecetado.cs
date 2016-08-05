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
    class Controladormedicamentorecetado
    {

        public List<medicamentosrecetados> listarRecetados()
        {
            List<medicamentosrecetados> im;
            try
            {
                Model model = new Conexion.Model();
                im = model.Entidades.medicamentosrecetados.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return im;
        }


        public bool insertarMedicamentorecetado(medicamentosrecetados im)
        {

            try
            {
                Model model = new Model();
                model.Entidades.medicamentosrecetados.Add(im);
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
