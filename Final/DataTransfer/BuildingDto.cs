namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public enum BuildingName
	{
		H,
		G
	}

	public class BuildingDto
	{
		public int BuildingID { get; set; }

		List<FloorDto> Floors { get; set; }
	}
}
