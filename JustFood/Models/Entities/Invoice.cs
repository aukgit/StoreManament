
namespace JustFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice
    {
        public Invoice()
        {
            this.DetailedSales = new HashSet<DetailedSale>();
        }
    
        public long InvoiceID { get; set; }
        public int SaleID { get; set; }
        public long ClientDetailID { get; set; }
        public int SoldByUserID { get; set; }
        public string Note { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public decimal Due { get; set; }
        public System.DateTime Time { get; set; }
    
        public virtual ClientDetail ClientDetail { get; set; }
        public virtual ICollection<DetailedSale> DetailedSales { get; set; }
        public virtual Sale Sale { get; set; }
        public virtual User User { get; set; }
    }
}
