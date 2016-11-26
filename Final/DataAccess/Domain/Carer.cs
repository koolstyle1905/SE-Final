namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Carer")]
    public partial class Carer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CareID { get; set; }

        public int StudentID { get; set; }

        [StringLength(50)]
        public string Job { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string SSN { get; set; }

        [Column(TypeName = "ntext")]
        public string Address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Phone { get; set; }

        public virtual Student Student { get; set; }
    }
}
