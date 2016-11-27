namespace DataAccess.Core
{
	using System;
	using System.Collections.Generic;
	using Repositories;

	public interface IUnitOfWork : IDisposable
	{
		BuildingRepository Buildings { get; set; }

		ClassRepository Classes { get; set; }

		ClubRepository Clubs { get; set; }

		EmployeeRepository Employees { get; set; }

		FacultyRepository Faculties { get; set; }

		FloorRepository Floors { get; set; }

		StudentRepository Students { get; set; }

		RoomRepository Rooms { get; set; }
	}
}