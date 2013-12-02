
namespace JustFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientDetail
    {
        public ClientDetail()
        {
            this.Invoices = new HashSet<Invoice>();
        }
    
        public long ClientDetailID { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
