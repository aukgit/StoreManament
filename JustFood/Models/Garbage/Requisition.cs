//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JustFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requisition
    {
        public int RequisitionID { get; set; }
        public int CategoryID { get; set; }
        public int Quantity { get; set; }
        public byte QtyType { get; set; }
        public bool IsAutoAdded { get; set; }
        public bool IsInProcess { get; set; }
        public Nullable<int> ByWhomUser { get; set; }
        public bool IsDone { get; set; }
        public int AddedBy { get; set; }
    
        public virtual QuantityType QuantityType { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}