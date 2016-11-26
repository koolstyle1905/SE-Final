namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TemporaryAbsence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AbsenceID { get; set; }

        public int StudentID { get; set; }

        public int EmployeeID { get; set; }

        public DateTime StartDate { get; set; }

        public int NumOfAbsence { get; set; }

        [Column(TypeName = "ntext")]
        public string Reason { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }
    }
}
