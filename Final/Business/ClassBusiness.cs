using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class ClassBusiness
	{
		public static List<ClassDto> GetClassByFacultyId(string facultyId)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var classList = unitOfWork.Classes.FindBy(c => c.FacultyId == facultyId).ToList();
				return Mapper.Map<List<Class>, List<ClassDto>>(classList);
			}
		}
	}
}
