namespace DataTransfer
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;

	public class StudentDto : PersonDto
	{
		[Required]
		[MinLength(8), MaxLength(8)]
		public string StudentID { get; set; }

		[Required]
		[MinLength(8), MaxLength(8)]
		public string ClassID { get; set; }

		public string RoomID { get; set; }

		public string PlaceOfBirth { get; set; }

		public string Nation { get; set; }

		public string Religion { get; set; }

		public int Course { get; set; }

		public ClubDto Club { get; set; }

		public List<PriorityDto> Priorities { get; set; }
	}
}
