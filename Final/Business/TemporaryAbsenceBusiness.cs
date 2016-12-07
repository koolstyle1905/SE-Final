using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataAccess;
using DataAccess.Domain;
using DataTransfer;

namespace Business
{
	public static class TemporaryAbsenceBusiness
	{
		/// <summary>
		///     Thêm đơn tạm vắng
		/// </summary>
		/// <param name="temporaryAbsenceDto"></param>
		public static void Add(TemporaryAbsenceDto temporaryAbsenceDto)
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var temporary = Mapper.Map<TemporaryAbsenceDto, TemporaryAbsence>(temporaryAbsenceDto);
				temporary.AbsenceId = NextId();
				unitOfWork.Employees.Attach(temporary.Employee);
				unitOfWork.Students.Attach(temporary.Student);
				unitOfWork.TemporaryAbsences.Add(temporary);
			}
		}

		/// <summary>
		///     Tìm mã đơn tạm vắng tiếp theo
		/// </summary>
		/// <returns></returns>
		public static string NextId()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				var query = unitOfWork.TemporaryAbsences.OrderByDescending(t => t.AbsenceId).FirstOrDefault();
				const string prefixId = "T";
				return Utilities.NextId(query == null ? string.Empty : query.AbsenceId, prefixId);
			}
		}

		public static List<TemporaryAbsenceDto> GetAll()
		{
			using (var unitOfWork = new UnitOfWork())
			{
				return Mapper.Map<List<TemporaryAbsence>, List<TemporaryAbsenceDto>>(unitOfWork.TemporaryAbsences.ToList());
			}
		}
	}
}