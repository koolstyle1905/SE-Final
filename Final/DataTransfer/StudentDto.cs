namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class StudentDto : PersonDto
	{
		public string StudentID { get; set; }

		public string ClassID { get; set; }

		public string RoomID { get; set; }

		public string PlaceOfBirth { get; set; }

		public string Nation { get; set; }

		public string Religion { get; set; }

		public int Course { get; set; }

		public ClubDto Club { get; set; }

		public List<PriorityTargetDto> PriorityTargets { get; set; }
	}
}
