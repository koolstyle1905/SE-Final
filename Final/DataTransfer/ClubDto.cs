using System.Collections.Generic;

namespace DataTransfer
{
	public class ClubDto
	{
		public string ClubId { get; set; }

		public string Name { get; set; }

		public List<StudentDto> Students { get; set; }
	}
}