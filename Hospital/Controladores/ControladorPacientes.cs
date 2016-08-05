using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hospital.Conexion;
using Hospital.Modelo;

namespace Hospital.Controladores
{
    class ControladorPacientes
    {



        public bool modificarPaciente(int id, pacientes pac)
        {
            try
            {
                Model model = new Model();
                pacientes original = model.Entidades.pacientes.Find(id);
                original.nombres = pac.nombres;
                original.apellidos = pac.apellidos;
                original.direccion = pac.direccion;
                original.dui = pac.dui;
                original.telefono = pac.telefono;
                original.telefono_encargado = pac.telefono_encargado;
                original.nombreencargado = pac.nombreencargado;
                original.duiencargado = pac.duiencargado;
                original.apellidoencargado = pac.apellidoencargado;
                original.id_departamento = pac.id_departamento;
                original.id_municipio = pac.id_municipio;
                original.fecha_nacimiento = pac.fecha_nacimiento;
                original.genero = pac.genero;


                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {

                return false;
            }
            return true;
        }

        public bool insertarPaciente(pacientes p)
        {



            try
            {
                Model model = new Model();
                model.Entidades.pacientes.Add(p);
                model.Entidades.SaveChanges();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public List<pacientes> listarPacientes()
        {
            List<pacientes> e;
            try
            {
                Model model = new Conexion.Model();
                e = model.Entidades.pacientes.ToList();
                model.cerrarConexion();
            }
            catch (Exception ex)
            {
                return null;
            }

            return e;
        }


        public bool eliminarPaciente(int id)
        {

            try
            {
                Model model = new Model();
                pacientes copia = model.Entidades.pacientes.Find(id);
                model.Entidades.pacientes.Remove(copia);
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
