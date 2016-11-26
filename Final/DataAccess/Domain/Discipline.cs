namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Discipline")]
    public partial class Discipline
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DisciplineId { get; set; }

        public int StudentID { get; set; }

        public int EmployeeID { get; set; }

        [Column(TypeName = "ntext")]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Student Student { get; set; }
    }
}
