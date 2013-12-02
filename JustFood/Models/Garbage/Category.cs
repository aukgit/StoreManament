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
    
    public partial class Category
    {
        public Category()
        {
            this.CategoryWiseSolds = new HashSet<CategoryWiseSold>();
            this.Inventories = new HashSet<Inventory>();
        }
    
        public int CategoryID { get; set; }
        public string Category1 { get; set; }
        public bool IsSalable { get; set; }
        public bool IsExpense { get; set; }
        public bool IsRelatedToSalary { get; set; }
        public Nullable<bool> IsMonthlyLedger { get; set; }
    
        public virtual ICollection<CategoryWiseSold> CategoryWiseSolds { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}
