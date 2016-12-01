using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain
{
	[Table("Carer")]
	public class Carer
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
		public string SSN { get; set; }

		[Column(TypeName = "ntext")]
		public string Address { get; set; }

		[Column(TypeName = "numeric")]
		public decimal Phone { get; set; }

		[StringLength(50)]
		public string Job { get; set; }

		public virtual Student Student { get; set; }
	}
}