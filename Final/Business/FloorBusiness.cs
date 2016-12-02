using DataAccess;

namespace Business
{
	public class FloorBusiness
	{
		private readonly UnitOfWork unitOfWork;

		public FloorBusiness() : this(new UnitOfWork())
		{
		}

		public FloorBusiness(UnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}
	}
}