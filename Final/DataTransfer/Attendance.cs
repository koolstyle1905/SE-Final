using System;
using System.Collections.Generic;

namespace DataTransfer
{
	public class Attendance
	{
		public Attendance()
		{
			CreatedDate = DateTime.Now;
		}

		public string AttendanceId { get; set; }

		public DateTime CreatedDate { get; set; }

		public int NumOfStudent => Students.Count;

		public List<StudentDto> Students { get; set; }
	}
}