using System.Collections.Generic;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class ClubBusiness
	{
		public static List<ClubDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var clubList = unitOfWork.Clubs.ToList();
				return Mapper.Map<List<Club>, List<ClubDto>>(clubList);
			}
		}
	}
}