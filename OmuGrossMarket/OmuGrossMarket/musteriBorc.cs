//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OmuGrossMarket
{
    using System;
    using System.Collections.Generic;
    
    public partial class musteriBorc
    {
        public int musteriID { get; set; }
        public Nullable<int> borcMiktari { get; set; }
    
        public virtual musteri musteri { get; set; }
    }
}
