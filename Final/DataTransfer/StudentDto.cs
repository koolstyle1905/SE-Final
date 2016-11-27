namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class StudentDto : PersonDto
	{
		public int StudentID { get; set; }

		public int ClubID { get; set; }

		public int ClassID { get; set; }

		public int RoomID { get; set; }

		public string PlaceOfBirth { get; set; }

		public string Nation { get; set; }

		public string Religion { get; set; }

		public int Course { get; set; }

		public string Position { get; set; }

		public List<PriorityTargetDto> PriorityTargets { get; set; }
	}
}
