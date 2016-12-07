using System;

namespace DataTransfer
{
	public class LateArrivalDto
	{
		public LateArrivalDto()
		{
			CreatedDate = DateTime.Now;
		}

		public string LateId { get; set; }

		public string WorkingAddress { get; set; }

		public DateTime ArrivalTime { get; set; }

		public DateTime CreatedDate { get; set; }

		public string Description { get; set; }

		public virtual StudentDto Student { get; set; }
	}
}
