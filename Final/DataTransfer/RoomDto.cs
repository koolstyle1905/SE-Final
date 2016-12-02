using System.Collections.Generic;

namespace DataTransfer
{
	public class RoomDto
	{
		public string RoomId { get; set; }

		public string FloorId { get; set; }


		public int NumOfStudent => Students.Count;

		public List<StudentDto> Students { get; set; }
	}
}