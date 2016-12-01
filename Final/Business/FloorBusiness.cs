using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

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

		public List<FloorDto> GetFloorByBuildingIdOrderByFloorId(string buildingId)
		{
			var floorList = dormitoryContext.Floors
				.Where(x => x.BuildingId == buildingId)
				.OrderBy(f => f.FloorId.Length)
				.ThenBy(f => f.FloorId).ToList();
			return Mapper.Map<List<Floor>, List<FloorDto>>(floorList);
		}

		public List<FloorDto> GetAllOrderByFloorId()
		{
			var floorList = dormitoryContext.Floors
				.OrderBy(x => x.FloorId.Length)
				.ThenBy(f => f.FloorId).ToList();
			return Mapper.Map<List<Floor>, List<FloorDto>>(floorList);
		}
	}
}