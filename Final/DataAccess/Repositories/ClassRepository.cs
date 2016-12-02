using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class ClassRepository : Repository<Class>
	{
		public ClassRepository(DormitoryContext context) : base(context)
		{
		}
	}
}