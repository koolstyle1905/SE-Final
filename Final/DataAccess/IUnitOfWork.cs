namespace DataAccess
{
	using System;
	using System.Collections.Generic;
	using Repositories;

	internal interface IUnitOfWork : IDisposable
	{
		BuildingRepository Buildings { get; set; }

		ClubRepository Clubs { get; set; }

		EmployeeRepository Employees { get; set; }

		FloorRepository Floors { get; set; }

		StudentRepository Students { get; set; }

		RoomRepository Rooms { get; set; }
	}
}