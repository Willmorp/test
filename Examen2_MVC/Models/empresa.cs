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
    
    public partial class empresa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public empresa()
        {
            this.sedes = new HashSet<sede>();
        }
    
        public int idempresa { get; set; }
        public string nombreempresa { get; set; }
        public string ruc { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public Nullable<int> estadotabla { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sede> sedes { get; set; }
    }
}
