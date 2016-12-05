using System;
using System.Collections.Generic;

namespace DataTransfer
{
	public class ReportAbsenceDto
	{
		public ReportAbsenceDto()
		{
			CreatedDate = DateTime.Now;
		}

		public string ReportAbsenceId { get; set; }

		public DateTime CreatedDate { get; set; }

		public int NumOfStudent => Students.Count;

		public List<StudentDto> Students { get; set; }
	}
}