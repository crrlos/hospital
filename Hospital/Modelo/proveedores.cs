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
    
    public partial class proveedores
    {
        public proveedores()
        {
            this.InventarioMedicamentos = new HashSet<InventarioMedicamentos>();
            this.pedidoMedicamento = new HashSet<pedidoMedicamento>();
        }
    
        public int idproveedor { get; set; }
        public string Nombre { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
    
        public virtual ICollection<InventarioMedicamentos> InventarioMedicamentos { get; set; }
        public virtual ICollection<pedidoMedicamento> pedidoMedicamento { get; set; }
    }
}