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
    
    public partial class Adiccion
    {
        public Adiccion()
        {
            this.Adiccion_Usuario = new HashSet<Adiccion_Usuario>();
            this.Adiccion_Usuario1 = new HashSet<Adiccion_Usuario>();
            this.Adiccion_Usuario2 = new HashSet<Adiccion_Usuario>();
            this.Adiccion_Usuario3 = new HashSet<Adiccion_Usuario>();
        }
    
        public int Id { get; set; }
        public string Nombre { get; set; }
    
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario { get; set; }
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario1 { get; set; }
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario2 { get; set; }
        public virtual ICollection<Adiccion_Usuario> Adiccion_Usuario3 { get; set; }
    }
}
