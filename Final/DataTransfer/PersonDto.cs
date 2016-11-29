namespace DataTransfer
{
	using System;
	using System.ComponentModel;
	using System.ComponentModel.DataAnnotations;

	public class PersonDto
	{
		//[DisplayName("Họ tên")]
		public string Name { get; set; }

		//[DisplayName("Giới tính")]
		public string Gender { get; set; }

		//[DisplayName("Ngày sinh")]
		public DateTime DateOfBirth { get; set; }

		//[DisplayName("CMND")]
		public string SSN { get; set; }

		//[DisplayName("Địa chỉ")]
		public string Address { get; set; }

		//[DisplayName("Số điện thoại")]
		public decimal Phone { get; set; }
	}
}
