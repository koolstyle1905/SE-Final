using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public class StudentBusiness
	{
		private readonly IDormitoryContext dormitoryContext;

		public StudentBusiness() : this(new DormitoryContext())
		{
		}

		public StudentBusiness(IDormitoryContext dormitoryContext)
		{
			this.dormitoryContext = dormitoryContext;
		}

		public List<StudentDto> GetAll()
		{
			var studentList = dormitoryContext.Students.ToList();
			return Mapper.Map<List<Student>, List<StudentDto>>(studentList);
		}

		public void AddStudent(StudentDto student)
		{
			dormitoryContext.Students.Add(Mapper.Map<StudentDto, Student>(student));
			dormitoryContext.SaveChanges();
		}

		public void EditStudent(StudentDto student)
		{
			dormitoryContext.SetModified(Mapper.Map<StudentDto, Student>(student));
			dormitoryContext.SaveChanges();
		}
	}
}
