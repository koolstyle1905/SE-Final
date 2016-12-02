using System.Data.Entity;
using DataAccess.Core;
using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public interface IEmployeeRepository : IRepository<Employee>
	{
	}

	public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
	{
		public EmployeeRepository(DbContext context) : base(context)
		{
		}
	}
}