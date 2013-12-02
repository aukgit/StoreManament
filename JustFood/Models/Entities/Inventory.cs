namespace JustFood.Models {
    public class Inventory {
        public Inventory() {
            this.AccountBalances = new HashSet<AccountBalance>();
            this.DetailedSales = new HashSet<DetailedSale>();
            this.InventoryIns = new HashSet<InventoryIn>();
        }


        public long InventoryID { get; set; }
        public string ProductName { get; set; }
        public int CategoryID { get; set; }
        public int StockQuantity { get; set; }
        public int LastEditedby { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal BuyingPrice { get; set; }

        public virtual Category Category { get; set; }
        public virtual User User { get; set; }


        public virtual ICollection<AccountBalance> AccountBalances { get; set; }
        public virtual ICollection<DetailedSale> DetailedSales { get; set; }
        public virtual ICollection<InventoryIn> InventoryIns { get; set; }
    }
}