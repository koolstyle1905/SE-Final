using System.Collections.Generic;
using System.Linq;
using DataAccess;
using DataAccess.Domain;

namespace Business
{
	public class FloorBusiness
	{
		private readonly DormitoryContext dormitoryContext;

		public FloorBusiness() : this(new DormitoryContext())
		{
		}

		public FloorBusiness(DormitoryContext dormitoryContext)
		{
			this.dormitoryContext = dormitoryContext;
		}

		public IEnumerable<Floor> GetFloorByBuildingId(string buildingId)
		{
			return
				dormitoryContext.Floors.Where(x => x.BuildingId == buildingId).OrderBy(f => f.FloorId.Length).ThenBy(f => f.FloorId);
		}

		public IEnumerable<Floor> OrderById()
		{
			return dormitoryContext.Floors.OrderBy(x => x.FloorId.Length).ThenBy(f => f.FloorId);
		}
	}
}