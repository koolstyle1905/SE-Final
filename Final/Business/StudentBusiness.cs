using System.Collections.Generic;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class StudentBusiness
	{
		public static List<StudentDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var studentList = unitOfWork.Students.ToList();
				return Mapper.Map<List<Student>, List<StudentDto>>(studentList);
			}
		}

		public static void AddStudent(StudentDto studentDto)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Students.Add(Mapper.Map<StudentDto, Student>(studentDto));
				unitOfWork.SaveChanges();
			}
		}

		public static void EditStudent(StudentDto studentDto)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Students.Edit(Mapper.Map<StudentDto, Student>(studentDto));
				unitOfWork.SaveChanges();
			}
		}
	}
}