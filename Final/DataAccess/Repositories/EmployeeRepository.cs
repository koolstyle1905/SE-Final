namespace DataAccess.Repositories
{
	using System;
	using System.Collections.Generic;
	using System.Data.Entity;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using Domain;

	public class EmployeeRepository : Repository<Employee>
	{
		public EmployeeRepository(DbContext context) : base(context)
		{
		}
	}
}