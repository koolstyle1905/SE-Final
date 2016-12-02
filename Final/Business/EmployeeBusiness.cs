using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Core;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class EmployeeBusiness
	{
		private readonly IUnitOfWork unitOfWork;

		public EmployeeBusiness() : this(new UnitOfWork())
		{
		}

		public EmployeeBusiness(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public EmployeeDto GetEmployee(string employeeId)
		{
			var employee = unitOfWork.Employees.FindById(employeeId);
			return Mapper.Map<Employee, EmployeeDto>(employee);
		}

		public bool IsValid(string username, string password)
		{
			var result = unitOfWork.Employees.Any(e => (e.Username == username) && (e.Password == password));
			return result;
		}
	}
}