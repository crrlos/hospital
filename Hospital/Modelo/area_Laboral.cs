//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class area_Laboral
    {
        public area_Laboral()
        {
            this.medicos = new HashSet<medicos>();
        }
    
        public int idarealaboral { get; set; }
        public string nombreArea { get; set; }
    
        public virtual ICollection<medicos> medicos { get; set; }
    }
}
