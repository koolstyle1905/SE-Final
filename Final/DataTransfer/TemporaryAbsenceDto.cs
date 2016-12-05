using System;

namespace DataTransfer
{
	public class TemporaryAbsenceDto
	{
		public TemporaryAbsenceDto()
		{
			CreatedDate = DateTime.Now;
		}

		public string AbsenceId { get; set; }

		public DateTime StartDate { get; set; }

		public int NumOfAbsence { get; set; }

		public DateTime CreatedDate { get; set; }

		public string Description { get; set; }

		public EmployeeDto Employee { get; set; }

		public StudentDto Student { get; set; }
	}
}