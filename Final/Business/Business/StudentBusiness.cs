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

		public static void AddStudent(StudentDto student)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Students.Add(Mapper.Map<StudentDto, Student>(student));
				unitOfWork.SaveChanges();
			}
		}

		public static void EditStudent(StudentDto student)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Students.Edit(Mapper.Map<StudentDto, Student>(student));
				unitOfWork.SaveChanges();
			}
		}
	}
}
