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
    
    public partial class Sale
    {
        public Sale()
        {
            this.CategoryWiseSolds = new HashSet<CategoryWiseSold>();
            this.Invoices = new HashSet<Invoice>();
        }
    
        public int SaleID { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Discount { get; set; }
        public int TotalSold { get; set; }
        public Nullable<double> TotalLess { get; set; }
        public decimal TotalAcheived { get; set; }
        public decimal OtherExpenses { get; set; }
        public bool IsDividedAmongPartners { get; set; }
        public int TotalDiscountNumber { get; set; }
        public string Noted { get; set; }
        public bool AnyProblem { get; set; }
        public int DiscardSales { get; set; }
        public bool IsDiscardsChecked { get; set; }
        public double InHandCashChange { get; set; }
        public decimal ActualAcheivedFromEmployee { get; set; }
        public decimal ActualLossProfitAfterCollection { get; set; }
    
        public virtual ICollection<CategoryWiseSold> CategoryWiseSolds { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
