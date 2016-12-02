using System.Collections.Generic;

namespace DataTransfer
{
	public class BuildingDto
	{
		public string BuildingId { get; set; }

		public List<FloorDto> Floors { get; set; }
	}
}