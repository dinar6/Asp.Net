//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityLINQExercises
{
    using System;
    using System.Collections.Generic;
    
    public partial class Uye
    {
        public Uye()
        {
            this.Sepet = new HashSet<Sepet>();
            this.Siparis = new HashSet<Siparis>();
        }
    
        public int UyeId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Eposta { get; set; }
    
        public virtual ICollection<Sepet> Sepet { get; set; }
        public virtual ICollection<Siparis> Siparis { get; set; }
    }
}
