//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Examen2_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sede
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public sede()
        {
            this.empleadoes = new HashSet<empleado>();
            this.ventas = new HashSet<venta>();
        }
    
        public int idsede { get; set; }
        public string nombresede { get; set; }
        public Nullable<int> idempresa { get; set; }
        public Nullable<int> idusuario { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleado> empleadoes { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual usuario usuario { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<venta> ventas { get; set; }
    }
}
