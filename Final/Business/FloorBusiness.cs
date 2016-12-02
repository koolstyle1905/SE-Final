using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class FloorBusiness
	{
		public static List<FloorDto> GetFloorByBuildingId(string buildingId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var floorList = unitOfWork.Floors.GetFloorByBuildingId(buildingId).ToList();
				return Mapper.Map<List<Floor>, List<FloorDto>>(floorList);
			}
		}
	}
}