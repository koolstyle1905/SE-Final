using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class ClassRepository : Repository<Class>
	{
		public ClassRepository(DbContext context) : base(context)
		{
		}
	}
}