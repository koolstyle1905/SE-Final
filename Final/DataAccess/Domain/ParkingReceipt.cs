namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ParkingReceipt
    {
        [Key]
        [Column(Order = 0)]
        public string TicketID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string EmployeeID { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public DateTime EndDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual ParkingTicket ParkingTicket { get; set; }
    }
}
