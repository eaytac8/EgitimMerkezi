//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EgtMerkezi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class KursTip
    {
        public KursTip()
        {
            this.Kurs = new HashSet<Kurs>();
        }
    
        public int KursTipId { get; set; }
        public string KursKategoriAd { get; set; }
        public string Renk { get; set; }
    
        public virtual ICollection<Kurs> Kurs { get; set; }
    }
}
