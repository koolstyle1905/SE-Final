namespace DataAccess
{
	using System;
	using System.Collections.Generic;
	using Repositories;
	using Core;

	public class UnitOfWork : IUnitOfWork
	{
		private readonly DormitoryContext dormitoryContext;

		public UnitOfWork()
		{
			this.dormitoryContext = new DormitoryContext();
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
		/// Saves all pending changes
		/// </summary>
		/// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
		public int SaveChanges()
		{
			return this.dormitoryContext.SaveChanges();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		public void Dispose()
		{
			this.dormitoryContext.Dispose();
		}
	}
}
