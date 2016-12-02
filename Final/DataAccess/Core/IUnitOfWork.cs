using System;
using DataAccess.Repositories;

namespace DataAccess.Core
{
	public interface IUnitOfWork : IDisposable
	{
		BuildingRepository Buildings { get; set; }

		ClassRepository Classes { get; set; }

		ClubRepository Clubs { get; set; }

		EmployeeRepository Employees { get; set; }

		FacultyRepository Faculties { get; set; }

		FloorRepository Floors { get; set; }

		IStudentRepository Students { get; set; }

		RoomRepository Rooms { get; set; }

		int SaveChanges();
	}
}