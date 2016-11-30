namespace DataTransfer
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class PersonDto
	{
		public string Name { get; set; }

		public string Gender { get; set; }

		public DateTime DateOfBirth { get; set; }

		public string Ssn { get; set; }

		public string Address { get; set; }

		public decimal Phone { get; set; }
	}
}
