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
    
    public partial class EMPLEADO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EMPLEADO()
        {
            this.ADMINISTRADORXSUCURSALs = new HashSet<ADMINISTRADORXSUCURSAL>();
        }
    
        public int Cedula { get; set; }
        public string Nombre1 { get; set; }
        public string Nombre2 { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Provincia { get; set; }
        public string Cuidad { get; set; }
        public string Señas { get; set; }
        public System.DateTime FechaNacimiento { get; set; }
        public string Contraseña { get; set; }
        public string Sucursal { get; set; }
        public bool Activo { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ADMINISTRADORXSUCURSAL> ADMINISTRADORXSUCURSALs { get; set; }
        public virtual SUCURSAL SUCURSAL1 { get; set; }
    }
}
