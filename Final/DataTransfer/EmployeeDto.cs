﻿namespace DataTransfer
{
	public class EmployeeDto : PersonDto
	{
		public string EmployeeId { get; set; }

		public string Username { get; set; }

		public string Password { get; set; }

		public string Position { get; set; }
	}
}