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
    
    public partial class empleado
    {
        public int idempleado { get; set; }
        public Nullable<int> idpersona { get; set; }
        public Nullable<int> idcargo { get; set; }
        public Nullable<int> idsede { get; set; }
    
        public virtual cargo cargo { get; set; }
        public virtual persona persona { get; set; }
        public virtual sede sede { get; set; }
    }
}