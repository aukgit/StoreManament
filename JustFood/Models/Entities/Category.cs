using System.Collections.Generic;
using System.ComponentModel;
using System;

namespace JustFood.Models {
    public partial class  Category {
        public Category() {
            this.AccountBalances = new HashSet<AccountBalance>();
            this.CategoryWiseSolds = new HashSet<CategoryWiseSold>();
            this.DetailedSales = new HashSet<DetailedSale>();
            this.Inventories = new HashSet<Inventory>();
            this.InventoryIns = new HashSet<InventoryIn>();
            this.InventoryOuts = new HashSet<InventoryOut>();
            this.InventoryOutConfigs = new HashSet<InventoryOutConfig>();
            this.InventoryOutConfigs1 = new HashSet<InventoryOutConfig>();
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


        public virtual ICollection<DetailedSale> DetailedSales { get; set; }
        public virtual QuantityType QuantityType { get; set; }
        public virtual ICollection<Inventory> Inventories { get; set; }
        public virtual ICollection<InventoryIn> InventoryIns { get; set; }
        public virtual ICollection<InventoryOut> InventoryOuts { get; set; }
        public virtual ICollection<InventoryOutConfig> InventoryOutConfigs { get; set; }
        public virtual ICollection<InventoryOutConfig> InventoryOutConfigs1 { get; set; }
    }
}