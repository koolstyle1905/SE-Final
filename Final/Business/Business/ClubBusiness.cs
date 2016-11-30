namespace Business
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using AutoMapper;
	using DataAccess;
	using DataAccess.Domain;
	using DataTransfer;

	public static class ClubBusiness
	{
		public static List<ClubDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var clubList = unitOfWork.Clubs.GetAll().ToList();
				return Mapper.Map<List<Club>, List<ClubDto>>(clubList);
			}
		}
	}
}
