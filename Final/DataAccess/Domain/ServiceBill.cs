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
        [StringLength(10)]
        public string BillId { get; set; }

        [StringLength(10)]
        public string RoomId { get; set; }

        [StringLength(10)]
        public string EmployeeId { get; set; }

        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Amount { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Room Room { get; set; }
    }
}
