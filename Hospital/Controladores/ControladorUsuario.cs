using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;
using System.Data.Entity.Validation;

namespace Hospital.Controladores
{
    class ControladorUsuario
    {
        public bool insertarUsuario(usuarios u)
        {

            try
            {
                Model model = new Model();
                model.Entidades.usuarios.Add(u);
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
