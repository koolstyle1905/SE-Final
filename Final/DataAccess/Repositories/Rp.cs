using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class Rp : Repository<ReportAbsence>
	{
		public Rp(DormitoryContext context) : base(context)
		{
		}
	}

	public class LateArrivalRepository : Repository<LateArrivalInfo>
	{
		public LateArrivalRepository(DormitoryContext context) : base(context)
		{
		}
	}
}
