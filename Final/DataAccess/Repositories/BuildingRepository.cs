using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class BuildingRepository : Repository<Building>
	{
		public BuildingRepository(DormitoryContext context) : base(context)
		{
		}
	}
}