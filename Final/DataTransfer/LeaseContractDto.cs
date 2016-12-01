using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
