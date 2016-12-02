using System.Collections.Generic;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class ClubBusiness
	{
		private readonly UnitOfWork unitOfWork;

		public ClubBusiness() : this(new UnitOfWork())
		{
		}

		public ClubBusiness(UnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public List<ClubDto> GetAll()
		{
			var clubList = unitOfWork.Clubs.ToList();
			return Mapper.Map<List<Club>, List<ClubDto>>(clubList);
		}
	}
}