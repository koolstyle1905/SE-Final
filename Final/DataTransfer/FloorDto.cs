﻿namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class FloorDto
	{
		public string FloorId { get; set; }

		public string BuildingId { get; set; }

		public List<RoomDto> Rooms { get; set; }
	}
}
