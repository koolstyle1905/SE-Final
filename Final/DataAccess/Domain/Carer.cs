namespace DataAccess.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

	public interface ICarer
	{
		string CarerId { get; set; }
		string StudentId { get; set; }
		string Name { get; set; }
		string Gender { get; set; }
		DateTime DateOfBirth { get; set; }
		string Ssn { get; set; }
		string Address { get; set; }
		decimal Phone { get; set; }
		string Job { get; set; }
		Student Student { get; set; }
	}

	[Table("Carer")]
    public partial class Carer : ICarer
	{
        [StringLength(10)]
        public string CarerId { get; set; }

        [StringLength(10)]
        public string StudentId { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(20)]
        public string Ssn { get; set; }

        [Column(TypeName = "ntext")]
        public string Address { get; set; }

        [Column(TypeName = "numeric")]
        public decimal Phone { get; set; }

        [StringLength(50)]
        public string Job { get; set; }

        public virtual Student Student { get; set; }
    }
}
