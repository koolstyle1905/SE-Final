using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;
using System.Collections.Generic;
using System.Linq;
using DataAccess.Core;

namespace Business
{
	public class StudentBusiness
	{
		private readonly IUnitOfWork unitOfWork;

		public StudentBusiness() : this(new UnitOfWork())
		{
		}

		public StudentBusiness(IUnitOfWork unitOfWork)
		{
			this.unitOfWork = unitOfWork;
		}

		public List<StudentDto> GetAll()
		{
			var studentList = unitOfWork.Students.ToList();
			return Mapper.Map<List<Student>, List<StudentDto>>(studentList);
		}

		public void AddStudent(StudentDto student)
		{
			unitOfWork.Students.Add(Mapper.Map<StudentDto, Student>(student));
			unitOfWork.SaveChanges();
		}

		public void EditStudent(StudentDto student)
		{
			unitOfWork.Students.Edit(Mapper.Map<StudentDto, Student>(student));
			unitOfWork.SaveChanges();
		}
	}
}