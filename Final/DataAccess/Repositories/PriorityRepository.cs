using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class PriorityRepository : Repository<Priority>
	{
		public PriorityRepository(DbContext context) : base(context)
		{
		}
	}
}