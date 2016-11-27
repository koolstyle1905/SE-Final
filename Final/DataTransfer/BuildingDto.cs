namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public enum BuildingName
	{
		H,
		I
	}

	public class BuildingDto
	{
		public string BuildingID { get; set; }

		public List<FloorDto> Floors { get; set; }
	}
}
