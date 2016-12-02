using System;

namespace DataTransfer
{
	public class LeaseContractDto
	{
		public LeaseContractDto()
		{
			CreatedDate = DateTime.Now;
		}

		public string LeaseContractId { get; set; }

		public DateTime CreatedDate { get; set; }
	}
}