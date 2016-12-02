using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class FacultyRepository : Repository<Faculty>
	{
		public FacultyRepository(DormitoryContext context) : base(context)
		{
		}
	}
}