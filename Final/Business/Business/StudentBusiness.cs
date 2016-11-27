namespace Business
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;
	using System.Threading.Tasks;
	using AutoMapper;
	using DataAccess;
	using DataAccess.Domain;
	using DataTransfer;

	public static class StudentBusiness
	{
		public static List<StudentDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var students = unitOfWork.Students.GetAll().ToList();
				return Mapper.Map< List<Student>, List<StudentDto>>(students);
			}
		}
	}
}
