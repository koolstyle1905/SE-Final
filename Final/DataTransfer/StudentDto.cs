namespace DataTransfer
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class StudentDto : PersonDto
	{
		public StudentDto()
		{
		}

		[Required]
		public string StudentId { get; set; }

		[Required]
		public string ClubId { get; set; }

		[Required]
		public string ClassId { get; set; }

		public string RoomId { get; set; }

		public string PlaceOfBirth { get; set; }

		public string Nation { get; set; }

		public string Religion { get; set; }

		public int Course { get; set; }

		public List<PriorityDto> Priorities { get; set; }
	}
}
