namespace JustFood.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Notification
    {
        public Notification()
        {
            this.NotificationSeens = new HashSet<NotificationSeen>();
            this.NotificationSpecifics = new HashSet<NotificationSpecific>();
        }
    
        public long NotificationID { get; set; }
        public string Note { get; set; }
        public bool IsProductNeeded { get; set; }
        public bool IsAdminOnly { get; set; }
        public bool IsEmployeeOnly { get; set; }
        public bool IsForAll { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsAutogenerated { get; set; }
        public Nullable<int> GeneratedBy { get; set; }
        public System.DateTime GeneratedDate { get; set; }
        public bool IsForSpecificUsersOnly { get; set; }
    
        public virtual User User { get; set; }
        public virtual ICollection<NotificationSeen> NotificationSeens { get; set; }
        public virtual ICollection<NotificationSpecific> NotificationSpecifics { get; set; }
    }
}
