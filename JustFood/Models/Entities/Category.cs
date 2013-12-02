using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace JustFood.Models {
    public partial class  Category {
        public Category() {
            this.CategoryWiseSolds = new HashSet<CategoryWiseSold>();
            this.Inventories = new HashSet<Inventory>();
        }

        public int CategoryID { get; set; }

        [DisplayName("Category")]
        public string Category1 { get; set; }

        [DisplayName("Is Salable")]
        public bool IsSalable { get; set; }

        [DisplayName("Is Expense")]
        public bool IsExpense { get; set; }

        [DisplayName("Quantity Type")]

        public byte QtyType { get; set; }


        [DisplayName("Is Salary Related")]
        public bool IsRelatedToSalary { get; set; }

        public Nullable<bool> IsMonthlyLedger { get; set; }


        public virtual ICollection<AccountBalance> AccountBalances { get; set; }
        public virtual ICollection<CategoryWiseSold> CategoryWiseSolds { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }


    }
}