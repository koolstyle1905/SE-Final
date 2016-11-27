namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class FloorDto
	{
		public string FloorID { get; set; }

		public string BuildingID { get; set; }

		public List<RoomDto> Rooms { get; set; }
	}
}
