//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoNuevoFinal
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tipo_Usuario
    {
        public Tipo_Usuario()
        {
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int Id { get; set; }
        public string Cod_Tipo_Usuario { get; set; }
    
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
