using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class EmployeeBusiness
	{
        /// <summary>
        /// Lấy thông tin nhân viên thông qua mã nhân viên
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
		public static EmployeeDto GetEmployee(string employeeId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var employee = unitOfWork.Employees.FindById(employeeId);
				return Mapper.Map<Employee, EmployeeDto>(employee);
			}
		}
        /// <summary>
        /// Kiểm tra tên đăng nhập và mật khẩu hợp lệ
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
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