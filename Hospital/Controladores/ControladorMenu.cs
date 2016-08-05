using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Modelo;
using Hospital.Conexion;

namespace Hospital.Controladores
{
    class ControladorMenu
    {


        public List<usuariomenu> ListarMenu(int id)
        {


            List<usuariomenu> menu;
            try
            {
                Model model = new Model();
                menu = model.Entidades.usuariomenu.Where(e => e.idrol == id).ToList();

                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }



            return menu;
        }

       
    }
}
