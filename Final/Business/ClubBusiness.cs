using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class ClubBusiness
	{
		private readonly DormitoryContext dormitoryContext;

		public ClubBusiness() : this(new DormitoryContext())
		{
		}

		public ClubBusiness(DormitoryContext dormitoryContext)
		{
			this.dormitoryContext = dormitoryContext;
		}

		public List<ClubDto> GetAll()
		{
			var clubList = dormitoryContext.Clubs.ToList();
			return Mapper.Map<List<Club>, List<ClubDto>>(clubList);
		}
	}
}