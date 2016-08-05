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
    class ControladorInventarios
    {


        public bool insertaralinventario(InventarioMedicamentos im)
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



    }
}
