using System.Collections.Generic;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class StudentBusiness
	{
		/// <summary>
		///     Lấy sinh viên theo mã học viên
		/// </summary>
		/// <param name="studetnId"></param>
		/// <returns></returns>
		public static StudentDto GetStudent(string studetnId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var student = unitOfWork.Students.FindById(studetnId);
				return Mapper.Map<Student, StudentDto>(student);
			}
		}

		/// <summary>
		///     Lấy ra danh sách tất cả thông tin sinh viên
		/// </summary>
		/// <returns></returns>
		public static List<StudentDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var studentList = unitOfWork.Students.ToList();
				return Mapper.Map<List<Student>, List<StudentDto>>(studentList);
			}
		}

		/// <summary>
		///     Thêm thông tin sinh viên
		/// </summary>
		/// <param name="studentDto"></param>
		public static void AddStudent(StudentDto studentDto)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var student = Mapper.Map<StudentDto, Student>(studentDto);
				unitOfWork.Classes.Attach(student.Class);
				unitOfWork.Students.Add(student);
				unitOfWork.SaveChanges();
			}
		}

		/// <summary>
		///     Chỉnh sửa thông tin sinh viên
		/// </summary>
		/// <param name="studentDto"></param>
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