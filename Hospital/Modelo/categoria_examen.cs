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
    
    public partial class categoria_examen
    {
        public categoria_examen()
        {
            this.subcategoria_examen = new HashSet<subcategoria_examen>();
        }
    
        public int idcategoria { get; set; }
        public string nombrecategoria { get; set; }
    
        public virtual ICollection<subcategoria_examen> subcategoria_examen { get; set; }
    }
}