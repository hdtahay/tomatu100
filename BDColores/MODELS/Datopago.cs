//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODELS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Datopago
    {
        public int FacturaId { get; set; }
        public int ModopagoId { get; set; }
        public int DatopagoId { get; set; }
        public decimal monto_modo { get; set; }
        public string observacion_uno { get; set; }
        public string observacion_dos { get; set; }
        public string observacion_tres { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Modopago Modopago { get; set; }
    }
}
