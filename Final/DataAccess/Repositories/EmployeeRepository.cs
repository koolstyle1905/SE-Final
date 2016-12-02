using DataAccess.Domain;

namespace DataAccess.Repositories
{
	public class EmployeeRepository : Repository<Employee>
	{
		public EmployeeRepository(DormitoryContext context) : base(context)
		{
		}
	}
}