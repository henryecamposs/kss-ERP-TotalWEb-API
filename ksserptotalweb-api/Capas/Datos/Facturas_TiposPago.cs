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
    
    public partial class Facturas_TiposPago
    {
        public long id_Facturas_TiposPago { get; set; }
        public Nullable<short> id_TiposBancos { get; set; }
        public long id_Facturas { get; set; }
        public short id_TiposPago { get; set; }
        public string DescripicionDocumento { get; set; }
        public decimal Monto { get; set; }
        public Nullable<byte> nroAprobacion { get; set; }
        public string nroDocumento { get; set; }
        public string nroRecibo { get; set; }
        public System.DateTime FechaActual { get; set; }
    
        public virtual Facturas Facturas { get; set; }
    }
}