using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class EmployeeBusiness
	{
		private readonly DormitoryContext dormitoryContext;

		public EmployeeBusiness() : this(new DormitoryContext())
		{
		}

		public EmployeeBusiness(DormitoryContext dormitoryContext)
		{
			this.dormitoryContext = dormitoryContext;
		}

		public EmployeeDto GetEmployee(string employeeId)
		{
			var employee = dormitoryContext.Employees.Find(employeeId);
			return Mapper.Map<Employee, EmployeeDto>(employee);
		}

		public bool IsValid(string username, string password)
		{
			var result = dormitoryContext.Employees.Any(e => (e.Username == username) && (e.Password == password));
			return result;
		}
	}
}