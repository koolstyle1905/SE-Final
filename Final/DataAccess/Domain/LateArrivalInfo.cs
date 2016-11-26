namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LateArrivalInfo")]
    public partial class LateArrivalInfo
    {
        [Key]
        public string LateID { get; set; }

        public string StudentID { get; set; }

        [Column(TypeName = "ntext")]
        public string WorkingAddress { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Reason { get; set; }

        public virtual Student Student { get; set; }
    }
}
