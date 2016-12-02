using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class BuildingRepository : Repository<Building>
	{
		public BuildingRepository(DbContext context) : base(context)
		{
		}
	}
}