namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class RoomDto
	{
		public int RoomID { get; set; }

		public int FloorID { get; set; }

		public int NumOfStudent { get; set; }

		public List<StudentDto> Students { get; set;}
	}
}
