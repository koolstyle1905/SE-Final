using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class FacultyRepository : Repository<Faculty>
	{
		public FacultyRepository(DbContext context) : base(context)
		{
		}
	}
}