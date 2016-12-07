using System;
using DataAccess.Repositories;

namespace DataAccess
{
	public class UnitOfWork : IDisposable
	{
		private readonly DormitoryContext dormitoryContext;
		private BuildingRepository buildings;
		private ClassRepository classes;
		private ClubRepository clubs;
		private EmployeeRepository employees;
		private FacultyRepository faculties;
		private FloorRepository floors;
		private RoomRepository rooms;
		private StudentRepository students;
		private TemporaryAbsenceRepository temporaryAbsences;
		public Rp rp;
		public ViolationRecordRepository violationRecords;
		public LateArrivalRepository lateArrivals;

		public UnitOfWork()
		{
			dormitoryContext = new DormitoryContext();
			rp = new Rp(dormitoryContext);
			violationRecords = new ViolationRecordRepository(dormitoryContext);
			lateArrivals = new LateArrivalRepository(dormitoryContext);
		}

		public TemporaryAbsenceRepository TemporaryAbsences
		{
			get
			{
				if (temporaryAbsences != null)
				{
					return temporaryAbsences;
				}
				temporaryAbsences = new TemporaryAbsenceRepository(dormitoryContext);
				return temporaryAbsences;
			}
		}

		public BuildingRepository Buildings
		{
			get
			{
				if (buildings != null)
				{
					return buildings;
				}
				buildings = new BuildingRepository(dormitoryContext);
				return buildings;
			}
		}

		public ClassRepository Classes
		{
			get
			{
				if (classes != null)
				{
					return classes;
				}
				classes = new ClassRepository(dormitoryContext);
				return classes;
			}
		}

		public ClubRepository Clubs
		{
			get
			{
				if (clubs != null)
				{
					return clubs;
				}
				clubs = new ClubRepository(dormitoryContext);
				return clubs;
			}
		}

		public EmployeeRepository Employees
		{
			get
			{
				if (employees != null)
				{
					return employees;
				}
				employees = new EmployeeRepository(dormitoryContext);
				return employees;
			}
		}

		public FacultyRepository Faculties
		{
			get
			{
				if (faculties != null)
				{
					return faculties;
				}
				faculties = new FacultyRepository(dormitoryContext);
				return faculties;
			}
		}

		public FloorRepository Floors
		{
			get
			{
				if (floors != null)
				{
					return floors;
				}
				floors = new FloorRepository(dormitoryContext);
				return floors;
			}
		}

		public StudentRepository Students
		{
			get
			{
				if (students != null)
				{
					return students;
				}
				students = new StudentRepository(dormitoryContext);
				return students;
			}
		}

		public RoomRepository Rooms
		{
			get
			{
				if (rooms != null)
				{
					return rooms;
				}
				rooms = new RoomRepository(dormitoryContext);
				return rooms;
			}
		}

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