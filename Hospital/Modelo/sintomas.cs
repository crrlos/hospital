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
    
    public partial class sintomas
    {
        public sintomas()
        {
            this.pacientesintomas = new HashSet<pacientesintomas>();
        }
    
        public int idsintoma { get; set; }
        public string sintoma { get; set; }
    
        public virtual ICollection<pacientesintomas> pacientesintomas { get; set; }
    }
}