using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class TemporaryAbsenceRepository : Repository<TemporaryAbsence>
	{
		public TemporaryAbsenceRepository(DormitoryContext context) : base(context)
		{
		}
	}
}