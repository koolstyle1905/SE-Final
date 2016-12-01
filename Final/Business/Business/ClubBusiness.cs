namespace Business.Business
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

	public class ClubBusiness
	{
		private readonly IDormitoryContext dormitoryContext;

		public ClubBusiness()
		{
		}
		public ClubBusiness(IDormitoryContext dormitoryContext)
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
