using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Domain
{
	public class TemporaryAbsence
	{
		public TemporaryAbsence()
		{
			CreatedDate = DateTime.Now;
		}

		[Key]
		[StringLength(10)]
		public string AbsenceId { get; set; }

		[StringLength(10)]
		public string EmployeeId { get; set; }

		[StringLength(10)]
		public string StudentId { get; set; }

		public DateTime StartDate { get; set; }

		public int NumOfAbsence { get; set; }

		public DateTime CreatedDate { get; set; }

		[Column(TypeName = "ntext")]
		public string Description { get; set; }

		public virtual Employee Employee { get; set; }

		public virtual Student Student { get; set; }
	}
}