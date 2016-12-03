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
        /// Lấy ra danh sách tất cả thông tin sinh viên
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
        /// Thêm thông tin sinh viên
        /// </summary>
        /// <param name="studentDto"></param>
		public static void AddStudent(StudentDto studentDto)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				unitOfWork.Students.Add(Mapper.Map<StudentDto, Student>(studentDto));
				unitOfWork.SaveChanges();
			}
		}

        /// <summary>
        /// Chỉnh sửa thông tin sinh viên
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