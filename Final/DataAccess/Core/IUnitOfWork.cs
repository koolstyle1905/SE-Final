using System;
using DataAccess.Repositories;

namespace DataAccess.Core
{
	public interface IUnitOfWork : IDisposable
	{
		BuildingRepository Buildings { get; set; }

		ClassRepository Classes { get; set; }

		IClubRepository Clubs { get; set; }

		IEmployeeRepository Employees { get; set; }

		FacultyRepository Faculties { get; set; }

		FloorRepository Floors { get; set; }

		IStudentRepository Students { get; set; }

		IRoomRepository Rooms { get; set; }

		int SaveChanges();
	}
}