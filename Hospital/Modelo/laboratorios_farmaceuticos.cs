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
    
    public partial class laboratorios_farmaceuticos
    {
        public laboratorios_farmaceuticos()
        {
            this.inventario_medicamentos = new HashSet<inventario_medicamentos>();
        }
    
        public int idlaboratorio { get; set; }
        public string nombreLaboratorio { get; set; }
    
        public virtual ICollection<inventario_medicamentos> inventario_medicamentos { get; set; }
    }
}
