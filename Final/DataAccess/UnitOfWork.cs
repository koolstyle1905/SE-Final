using System;
using DataAccess.Repositories;

namespace DataAccess
{
	public class UnitOfWork : IDisposable
	{
		private readonly DormitoryContext dormitoryContext;

		public UnitOfWork()
		{
			dormitoryContext = new DormitoryContext();
			Buildings = new BuildingRepository(dormitoryContext);
			Classes = new ClassRepository(dormitoryContext);
			Clubs = new ClubRepository(dormitoryContext);
			Employees = new EmployeeRepository(dormitoryContext);
			Faculties = new FacultyRepository(dormitoryContext);
			Floors = new FloorRepository(dormitoryContext);
			Students = new StudentRepository(dormitoryContext);
			Rooms = new RoomRepository(dormitoryContext);
		}

		public BuildingRepository Buildings { get; set; }

		public ClassRepository Classes { get; set; }

		public ClubRepository Clubs { get; set; }

		public EmployeeRepository Employees { get; set; }

		public FacultyRepository Faculties { get; set; }

		public FloorRepository Floors { get; set; }

		public StudentRepository Students { get; set; }

		public RoomRepository Rooms { get; set; }

		/// <summary>
		///     Clean up any resources being used.
		/// </summary>
		public void Dispose()
		{
			dormitoryContext.Dispose();
		}

		/// <summary>
		///     Saves all pending changes
		/// </summary>
		/// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
		public int SaveChanges()
		{
			return dormitoryContext.SaveChanges();
		}
	}
}