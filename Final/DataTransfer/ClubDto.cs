namespace DataTransfer
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel;

	public class ClubDto
	{
		public string ClubId { get; set; }
		
		public string Name { get; set; }

		public List<StudentDto> Students { get; set; }
	}
}
