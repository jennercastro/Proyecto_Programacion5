//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto01.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registro_Poliza
    {
        public int Id { get; set; }
        public Nullable<double> Monto_Asegurado { get; set; }
        public Nullable<double> Prima_Impuesto { get; set; }
        public Nullable<double> Impuesto { get; set; }
        public Nullable<double> Porcentaje_Cobertura { get; set; }
        public Nullable<int> Numero_Adiccion { get; set; }
        public Nullable<double> Monto_Adiccion { get; set; }
        public Nullable<double> Prima_Final { get; set; }
        public Nullable<int> Cod_Cobertura_Poliza { get; set; }
        public Nullable<int> Cod_Cliente { get; set; }
        public Nullable<int> Cod_Tipo_Poliza { get; set; }
    
        public virtual Cobertura_Poliza Cobertura_Poliza { get; set; }
        public virtual Cobertura_Poliza Cobertura_Poliza1 { get; set; }
        public virtual Cobertura_Poliza Cobertura_Poliza2 { get; set; }
        public virtual Cobertura_Poliza Cobertura_Poliza3 { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }
        public virtual Usuario Usuario3 { get; set; }
        public virtual Tipo_Poliza Tipo_Poliza { get; set; }
        public virtual Tipo_Poliza Tipo_Poliza1 { get; set; }
        public virtual Tipo_Poliza Tipo_Poliza2 { get; set; }
        public virtual Tipo_Poliza Tipo_Poliza3 { get; set; }
    }
}
