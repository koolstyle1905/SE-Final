namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeaseReceipt
    {
        [Key]
        [Column(Order = 0)]
        public string StudentID { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ContractID { get; set; }

        public DateTime EndDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? TotalPrice { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual LeaseContract LeaseContract { get; set; }
    }
}
