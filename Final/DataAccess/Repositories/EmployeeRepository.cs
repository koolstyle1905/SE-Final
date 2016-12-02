using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class EmployeeRepository : Repository<Employee>
	{
		public EmployeeRepository(DbContext context) : base(context)
		{
		}
	}
}