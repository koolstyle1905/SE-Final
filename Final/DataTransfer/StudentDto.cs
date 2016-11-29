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
		[MinLength(8), MaxLength(8)]
		//[DisplayName("Mã học viên")]
		public string StudentID { get; set; }

		[Required]
		[MinLength(8), MaxLength(8)]
		//[DisplayName("Mã lớp")]
		public string ClassID { get; set; }

		//[DisplayName("Phòng")]
		public string RoomID { get; set; }

		//[DisplayName("Nơi sinh")]
		public string PlaceOfBirth { get; set; }

		//[DisplayName("Dân tộc")]
		public string Nation { get; set; }

		//[DisplayName("Tôn giáo")]
		public string Religion { get; set; }

		//[DisplayName("Khoá")]
		public int Course { get; set; }

		public ClubDto Club { get; set; }

		//[DisplayName("Diện ưu tiên")]
		public List<PriorityDto> Priorities { get; set; }
	}
}
