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
    
    public partial class Estaciones
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estaciones()
        {
            this.Cajas = new HashSet<Cajas>();
        }
    
        public short id_Estaciones { get; set; }
        public short id_Licencia { get; set; }
        public short id_DefTipos_Estacion { get; set; }
        public Nullable<short> id_DefTipos_PedirDatosCliente { get; set; }
        public short id_DefTipos_PrecioPredet { get; set; }
        public Nullable<short> id_DefTipos_DescargaInventario { get; set; }
        public short id_Almacenes { get; set; }
        public bool esActivo { get; set; }
        public bool esimprimirEgreso { get; set; }
        public bool esImprimirFiscal { get; set; }
        public bool esOffline { get; set; }
        public bool esPedirCantidad { get; set; }
        public bool esPreguntarCerrarApp { get; set; }
        public bool esRemoto { get; set; }
        public bool esRequierePassword { get; set; }
        public string IPEstacion { get; set; }
        public string NombreEquipo { get; set; }
        public string NombreEstacion { get; set; }
        public bool esImprimirNConsumo { get; set; }
        public bool esPoseeTeclado { get; set; }
        public bool esPoseeVisorPrecio { get; set; }
        public bool esPoseeVisorPreciosMonitorExtra { get; set; }
        public Nullable<bool> esPoseeGaveta { get; set; }
        public Nullable<bool> esPoseeCaptaHuella { get; set; }
        public Nullable<bool> esPoseePantallaTactil { get; set; }
        public Nullable<bool> esPoseeMouse { get; set; }
        public Nullable<bool> esPoseeLectorPOSBanca { get; set; }
        public Nullable<System.DateTime> FechaUltimaConfiguracion { get; set; }
        public Nullable<bool> esCliente_SolicitarEmail { get; set; }
        public Nullable<bool> esCliente_SolicitarRIF { get; set; }
        public Nullable<bool> esCliente_SolicitarTelefono { get; set; }
        public Nullable<bool> esSolicitarEmpleado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cajas> Cajas { get; set; }
    }
}