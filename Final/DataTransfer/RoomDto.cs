namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class RoomDto
	{
		public string RoomID { get; set; }

		public string FloorID { get; set; }

		public int NumOfStudent
		{
			get
			{
				return this.Students.Count;
			}
		}

		public List<StudentDto> Students { get; set;}
	}
}
