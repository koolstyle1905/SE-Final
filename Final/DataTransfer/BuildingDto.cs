﻿namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class BuildingDto
	{
		public string BuildingId { get; set; }

		public List<FloorDto> Floors { get; set; }
	}
}