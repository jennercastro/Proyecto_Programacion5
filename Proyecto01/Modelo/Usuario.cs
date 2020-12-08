//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto01.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.Adiccion_Usuario = new HashSet<Adiccion_Usuario>();
            this.Adiccion_Usuario1 = new HashSet<Adiccion_Usuario>();
            this.Adiccion_Usuario2 = new HashSet<Adiccion_Usuario>();
            this.Adiccion_Usuario3 = new HashSet<Adiccion_Usuario>();
            this.Registro_Poliza = new HashSet<Registro_Poliza>();
            this.Registro_Poliza1 = new HashSet<Registro_Poliza>();
            this.Registro_Poliza2 = new HashSet<Registro_Poliza>();
            this.Registro_Poliza3 = new HashSet<Registro_Poliza>();
        }
    
        public int Id { get; set; }
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public string Correo { get; set; }
        public Nullable<int> Telefono1 { get; set; }
        public Nullable<int> Telefono2 { get; set; }
        public Nullable<System.DateTime> Fecha_Nacimiento { get; set; }
        public string Genero { get; set; }
        public Nullable<int> Cod_Tipo_Usuario { get; set; }
        public Nullable<int> Cod_Cobertura_Poliza { get; set; }
        public string Alias_Usuario { get; set; }
        public string Pass_Usuario { get; set; }
        public string Direccion { get; set; }
    
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario { get; set; }
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario1 { get; set; }
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario2 { get; set; }
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario3 { get; set; }
        public virtual Cobertura_Poliza Cobertura_Poliza { get; set; }
        public virtual Cobertura_Poliza Cobertura_Poliza1 { get; set; }
        public virtual Cobertura_Poliza Cobertura_Poliza2 { get; set; }
        public virtual Cobertura_Poliza Cobertura_Poliza3 { get; set; }
        public virtual ICollection<Registro_Poliza> Registro_Poliza { get; set; }
        public virtual ICollection<Registro_Poliza> Registro_Poliza1 { get; set; }
        public virtual ICollection<Registro_Poliza> Registro_Poliza2 { get; set; }
        public virtual ICollection<Registro_Poliza> Registro_Poliza3 { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario1 { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario2 { get; set; }
        public virtual Tipo_Usuario Tipo_Usuario3 { get; set; }
    }
}
