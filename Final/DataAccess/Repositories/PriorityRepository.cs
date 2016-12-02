using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class PriorityRepository : Repository<Priority>
	{
		public PriorityRepository(DormitoryContext context) : base(context)
		{
		}
	}
}