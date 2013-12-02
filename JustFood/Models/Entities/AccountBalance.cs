using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JustFood.Models {
    public partial class AccountBalance {

        public long AccountBalanceID { get; set; }
        public DateTime Dated { get; set; }
        public double Amount { get; set; }
        [DisplayName("Is Bought")]
        public bool IsBoughtProduct { get; set; }
  
        [DisplayName("Inventory ID")]
        public long InventoryID { get; set; }

        [DisplayName("Quantity")]
        public int? AddedQuantity { get; set; }

        [DisplayName("Quantity Type")]
        public Nullable<byte> QtyType { get; set; }
        [DisplayName("Is Expense")]
        public bool IsExpense { get; set; }
        [DisplayName("Is Added Money")]
        public bool IsAddedMoney { get; set; }

        [DisplayName("Account")]
        public int AccountOf { get; set; }

        [DisplayName("Added By")]
        public int AddBy { get; set; }
        public string Note { get; set; }

        public bool IsVerified { get; set; }

        public bool IsDailyExpense { get; set; }
        public bool IsRevenueOfDailySales { get; set; }

        public virtual Category Category { get; set; }

        /// <summary>
        ///     Account of whom
        /// </summary>
        public virtual User User { get; set; }

        /// <summary>
        ///     Added by whom.
        /// </summary>
        public virtual User User1 { get; set; }

    }
}