//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ksserptotalweb_api.Capas.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturas_Detalle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facturas_Detalle()
        {
            this.Facturas_Detalle_Descuentos = new HashSet<Facturas_Detalle_Descuentos>();
            this.Facturas_Detalle_Impuestos = new HashSet<Facturas_Detalle_Impuestos>();
        }
    
        public long id_Facturas_Detalle { get; set; }
        public long id_Facturas { get; set; }
        public long id_Productos { get; set; }
        public Nullable<short> id_TiposProducto { get; set; }
        public byte id_DefTiposPrecio { get; set; }
        public byte nroItem { get; set; }
        public decimal Cantidad { get; set; }
        public string Producto { get; set; }
        public decimal MontoPrecio { get; set; }
        public string Observacion { get; set; }
    
        public virtual Facturas Facturas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas_Detalle_Descuentos> Facturas_Detalle_Descuentos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas_Detalle_Impuestos> Facturas_Detalle_Impuestos { get; set; }
        public virtual Productos Productos { get; set; }
    }
}
