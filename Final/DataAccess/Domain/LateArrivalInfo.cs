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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LateID { get; set; }

        public int? StudentID { get; set; }

        [Column(TypeName = "ntext")]
        public string WorkingAddress { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "ntext")]
        public string Reason { get; set; }

        public virtual Student Student { get; set; }
    }
}
