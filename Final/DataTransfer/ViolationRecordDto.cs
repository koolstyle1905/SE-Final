using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransfer
{
	public class ViolationRecordDto
	{
		public ViolationRecordDto()
		{
			CreatedDate = DateTime.Now;
		}

		public string ViolationId { get; set; }

		public string EmployeeId { get; set; }

		public string Description { get; set; }

		public DateTime CreatedDate { get; set; }

		public StudentDto Student { get; set; }
	}
}
