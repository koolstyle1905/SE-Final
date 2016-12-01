using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Domain;
using DataAccess;

namespace Business.Business
{
	public class FloorBusiness
	{
		private readonly IDormitoryContext dormitoryContext;

		public FloorBusiness()
		{
		}
		public FloorBusiness(IDormitoryContext dormitoryContext)
		{
			this.dormitoryContext = dormitoryContext;
		}

		public IEnumerable<Floor> GetFloorByBuildingId(string buildingId)
		{
			return dormitoryContext.Floors.Where(x => x.BuildingId == buildingId).OrderBy(f => f.FloorId.Length).ThenBy(f => f.FloorId);
		}

		public IEnumerable<Floor> OrderById()
		{
			return dormitoryContext.Floors.OrderBy(x => x.FloorId.Length).ThenBy(f => f.FloorId);
		}
	}
}
