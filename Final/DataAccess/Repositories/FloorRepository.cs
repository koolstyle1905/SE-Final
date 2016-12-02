using DataAccess.Domain;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess.Repositories
{
	public class FloorRepository : Repository<Floor>
	{
		public FloorRepository(DbContext context) : base(context)
		{
		}

		public IEnumerable<Floor> GetFloorByBuildingId(string buildingId)
		{
			return DbSet.Where(x => x.BuildingId == buildingId).OrderBy(f => f.FloorId.Length).ThenBy(f => f.FloorId);
		}

		public IEnumerable<Floor> OrderById()
		{
			return DbSet.OrderBy(x => x.FloorId.Length).ThenBy(f => f.FloorId);
		}
	}
}