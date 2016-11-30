namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViolationRecord")]
    public partial class ViolationRecord
    {
        [Key]
        [StringLength(10)]
        public string ViolationId { get; set; }

        [StringLength(10)]
        public string EmployeeId { get; set; }

        [StringLength(10)]
        public string StudentId { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }
    }
}
