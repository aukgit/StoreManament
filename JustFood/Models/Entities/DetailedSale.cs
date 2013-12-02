using System.ComponentModel.DataAnnotations;

namespace JustFood.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    
    public partial class DetailedSale
    {
        public long DetailedSaleID { get; set; }

        public long InventoryID { get; set; }
        public decimal SellingPrice { get; set; }
        /// <summary>
        /// Linked with which invoice.
        /// </summary>
        public long InvoiceID { get; set; }
    
        
        /// <summary>
        /// How many quantities sold.
        /// </summary>
        public short Quantity { get; set; }

        /// <summary>
        /// which product linked to.
        /// </summary>
        public virtual Inventory Inventory { get; set; }
        /// <summary>
        /// details of that linked invoice.
        /// </summary>
        public virtual Invoice Invoice { get; set; }

    }
}
