using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain
{
	[Table("ViolationRecord")]
	public class ViolationRecord
	{
		public ViolationRecord()
		{
			CreatedDate = DateTime.Now;
		}

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