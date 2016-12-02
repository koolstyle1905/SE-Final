using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class ClubRepository : Repository<Club>
	{
		public ClubRepository(DormitoryContext context) : base(context)
		{
		}
	}
}