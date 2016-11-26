namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DamageClaim")]
    public partial class DamageClaim
    {
        [Key]
        public string ClaimID { get; set; }

        public string StudentID { get; set; }

        public string EmployeeID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "money")]
        public decimal TotalPrice { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }
    }
}
