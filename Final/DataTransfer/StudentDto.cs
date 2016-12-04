using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataTransfer
{
	public class StudentDto : PersonDto
	{
		public StudentDto()
		{
			DateOfBirth = new DateTime(2000, 1, 1);
		}

		[Required]
		public string StudentId { get; set; }

		public ClassDto Class { get; set; }

		public string ClubId { get; set; }

		public string RoomId { get; set; }

		public string PlaceOfBirth { get; set; }

		public string Nation { get; set; }
		public string Religion { get; set; }

		public int Course { get; set; }

		public List<PriorityDto> Priorities { get; set; }

		public List<CarerDto> Carers { get; set; }
	}
}