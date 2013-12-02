using System.ComponentModel.DataAnnotations;
namespace JustFood.Models {
    public class InventoryIn {
        public long InventoryInID { get; set; }
     
        public bool IsAddedBySelling { get; set; }
        /// <summary>
        /// How many quantities of that item buy at that moment.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:###.00##}")]
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        [Required]
        public System.DateTime Dated { get; set; }

        public long InventoryID { get; set; }

        public int AddedBy { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual User User { get; set; }
    }
}