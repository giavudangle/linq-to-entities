//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LinqToEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class RECEIPT
    {
        public string Receipt_ID { get; set; }
        public string Product_ID { get; set; }
        public int Product_Amount { get; set; }
        public Nullable<System.DateTime> Receipt_Date { get; set; }
    
        public virtual PRODUCT PRODUCT { get; set; }
    }
}