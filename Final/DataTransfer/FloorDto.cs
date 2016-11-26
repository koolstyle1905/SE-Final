namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class FloorDto
	{
		public int FloorID { get; set; }

		public int BuildingID { get; set; }

		public List<RoomDto> Rooms { get; set; }
	}
}
