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
    
    public partial class Tipo_Usuario
    {
        public Tipo_Usuario()
        {
            this.Usuario = new HashSet<Usuario>();
            this.Usuario1 = new HashSet<Usuario>();
            this.Usuario2 = new HashSet<Usuario>();
            this.Usuario3 = new HashSet<Usuario>();
        }
    
        public int Id { get; set; }
        public string Cod_Tipo_Usuario { get; set; }
    
        public virtual ICollection<Usuario> Usuario { get; set; }
        public virtual ICollection<Usuario> Usuario1 { get; set; }
        public virtual ICollection<Usuario> Usuario2 { get; set; }
        public virtual ICollection<Usuario> Usuario3 { get; set; }
    }
}