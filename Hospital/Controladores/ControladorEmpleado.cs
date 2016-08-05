using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;
using System.Windows.Forms;

namespace Hospital.Controladores
{
    class ControladorEmpleado
    {

        public bool insertarEmpleado(empleados e)
        {

            try
            {
                Model model = new Model();
                model.Entidades.empleados.Add(e);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }


        public List<empleados> listarEmpleados()
        {
            List<empleados> e;
            try
            {
                Model model = new Conexion.Model();
                e= model.Entidades.empleados.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return e;
        }

        public void listarEmpleadoMedico(DataGridView d1)
        {

            Model model = new Model();

            var datos = model.Entidades.medicos.Select(a => new
            {

                a.idmedico,
               
                a.empleados.nombres,
                a.empleados.apellidos,
                a.especialidadmedicos.nombre_especialidad,
                a.JVPM,
                a.area_Laboral.nombreArea,
                a.empleados.telefono,
                a.empleados.estado,
                a.idempleado
                
                
                
            }).Where(b=> b.estado.Equals("ACTIVO")).ToList();
            d1.DataSource = datos;

        }

        public bool modificarEmpleado(int id, empleados e)
        {
            try
            {
                Model model = new Model();
                empleados original = model.Entidades.empleados.Find(id);
                original.nombres = e.nombres;
                original.apellidos = e.apellidos;
                original.direccion = e.direccion;
                original.dui = e.dui;
                original.NIT = e.NIT;
                original.idcargo = e.idcargo;
                original.iddepartamento = e.iddepartamento;
                original.idmunicipio = e.idmunicipio;
                original.telefono = e.telefono;
                original.fecha_contratacion = e.fecha_contratacion;
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }
        public bool eliminarEmpleado(int id)
        {

            try
            {
                Model model = new Model();
                empleados copia = model.Entidades.empleados.Find(id);
                model.Entidades.empleados.Remove(copia);
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
