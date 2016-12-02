using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Core;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class FloorBusiness
	{
		private readonly IUnitOfWork unitOfWork;

		public FloorBusiness() : this(new UnitOfWork())
		{
		}

		public FloorBusiness(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}
	}
}