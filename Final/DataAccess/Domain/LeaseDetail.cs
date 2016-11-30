namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LeaseDetail
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string EmployeeId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string ContractId { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual LeaseContract LeaseContract { get; set; }
    }
}