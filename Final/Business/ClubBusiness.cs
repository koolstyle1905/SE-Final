using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Core;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class ClubBusiness
	{
		private readonly IUnitOfWork unitOfWork;

		public ClubBusiness() : this(new UnitOfWork())
		{
		}

		public ClubBusiness(IUnitOfWork unitOfWork)
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