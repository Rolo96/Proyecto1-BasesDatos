//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROLXDEPENDIENTE
    {
        public int Dependiente { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ROL ROL1 { get; set; }
    }
}
