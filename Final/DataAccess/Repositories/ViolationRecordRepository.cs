using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class ViolationRecordRepository : Repository<ViolationRecord>
	{
		public ViolationRecordRepository(DormitoryContext context) : base(context)
		{
		}
	}
}
