using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public sealed class SingleUser
    {
        private static SingleUser usuario = null;
        private String idusuario;

        public String Idusuario
        {
            get { return idusuario; }
            set { idusuario = value; }
        }
        private String nombres;

        public String Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }
        private String apellidos;

        public String Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }
        private int idrol;

        public int Idrol
        {
            get { return idrol; }
            set { idrol = value; }
        }
        private string rol;

        public string Rol
        {
            get { return rol; }
            set { rol = value; }
        }
        private SingleUser() { }
        public static SingleUser Usuario
        {
            get
            {
                if (usuario == null)
                    usuario = new SingleUser();
                return usuario;
            }
        }
        private int idmedico;

        public int Idmedico
        {
            get { return idmedico; }
            set { idmedico = value; }
        }
    }
}
