namespace DataTransfer
{
	using System;
	using System.Collections.Generic;

	public class CarerDto : PersonDto
	{
		public int CarerID { get; set; }

		public string Job { get; set; }
	}
}
