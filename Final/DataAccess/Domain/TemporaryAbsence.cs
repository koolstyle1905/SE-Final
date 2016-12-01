namespace DataAccess.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

	public partial class TemporaryAbsence
    {
        [Key]
        [StringLength(10)]
        public string AbsenceId { get; set; }

        [StringLength(10)]
        public string EmployeeId { get; set; }

        [StringLength(10)]
        public string StudentId { get; set; }

        public DateTime StartDate { get; set; }

        public int NumOfAbsence { get; set; }

        [Column(TypeName = "ntext")]
        public string Reason { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }
    }
}
