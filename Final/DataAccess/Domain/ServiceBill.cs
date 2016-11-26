namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ServiceBill
    {
        [Key]
        public string BillID { get; set; }

        public string RoomID { get; set; }

        public string StudentID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Room Room { get; set; }
    }
}
