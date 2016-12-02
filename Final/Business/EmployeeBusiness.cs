using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class EmployeeBusiness
	{
		public static EmployeeDto GetEmployee(string employeeId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var employee = unitOfWork.Employees.FindById(employeeId);
				return Mapper.Map<Employee, EmployeeDto>(employee);
			}
		}

		public static bool IsValid(string username, string password)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var result = unitOfWork.Employees.Any(e => (e.Username == username) && (e.Password == password));
				return result;
			}
		}
	}
}