namespace DataAccess.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Domain;
	using System.Collections;

	public class FloorRepository : Repository<Floor>
	{
		public FloorRepository(DbContext context) : base(context)
		{
		}

		public IEnumerable<Floor> GetFloorByBuildingID(string buildingID)
		{
			return this.Dbset.Where(x => x.BuildingID == buildingID).OrderBy(f => f.FloorID.Length).ThenBy(f => f.FloorID);
		}

		public IEnumerable<Floor> OrderById()
		{
			return this.Dbset.OrderBy(x => x.FloorID.Length).ThenBy(f => f.FloorID);
		}
	}
}
