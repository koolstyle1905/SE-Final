using System.Collections.Generic;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class BuildingBusiness
	{
		public static List<BuildingDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var buildingList = unitOfWork.Buildings.ToList();
				return Mapper.Map<List<Building>, List<BuildingDto>>(buildingList);
			}
		}
	}
}