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
    
    public partial class TELEFONOXCLIENTE
    {
        public int Cliente { get; set; }
        public int Telefono { get; set; }
        public bool Activo { get; set; }
    
        public virtual CLIENTE CLIENTE1 { get; set; }
    }
}
