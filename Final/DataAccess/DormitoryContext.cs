using System.Data.Entity;
using DataAccess.Domain;

namespace DataAccess
{
	public interface IDormitoryContext
	{
		DbSet<Student> Students { get; set; }
		int SaveChanges();
	}

	public class DormitoryContext : DbContext, IDormitoryContext
	{
		public DormitoryContext() : base(Connection.ConnectionString)
		{
		}

		public DormitoryContext(string connectionString) : base(connectionString)
		{
		}

		public virtual DbSet<Attendance> Attendances { get; set; }

		public virtual DbSet<Building> Buildings { get; set; }

		public virtual DbSet<Carer> Carers { get; set; }

		public virtual DbSet<Class> Classes { get; set; }

		public virtual DbSet<Club> Clubs { get; set; }

		public virtual DbSet<Employee> Employees { get; set; }

		public virtual DbSet<Faculty> Faculties { get; set; }

		public virtual DbSet<Floor> Floors { get; set; }

		public virtual DbSet<LateArrivalInfo> LateArrivalInfoes { get; set; }

		public virtual DbSet<LeaseContract> LeaseContracts { get; set; }

		public virtual DbSet<LeaseDetail> LeaseDetails { get; set; }

		public virtual DbSet<ParkingDetail> ParkingDetails { get; set; }

		public virtual DbSet<ParkingTicket> ParkingTickets { get; set; }

		public virtual DbSet<Priority> Priorities { get; set; }

		public virtual DbSet<Room> Rooms { get; set; }

		public virtual DbSet<Student> Students { get; set; }

		public virtual DbSet<TemporaryAbsence> TemporaryAbsences { get; set; }

		public virtual DbSet<ViolationRecord> ViolationRecords { get; set; }

		public virtual void SetModified(object entity)
		{
			Entry(entity).State = EntityState.Modified;
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Attendance>()
				.HasMany(e => e.Students)
				.WithMany(e => e.Attendances)
				.Map(m => m.ToTable("AttendanceDetail").MapLeftKey("AttendanceId").MapRightKey("StudentId"));

			modelBuilder.Entity<Carer>()
				.Property(e => e.Phone)
				.HasPrecision(12, 0);

			modelBuilder.Entity<Employee>()
				.Property(e => e.Phone)
				.HasPrecision(12, 0);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.LeaseDetails)
				.WithRequired(e => e.Employee)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.ParkingDetails)
				.WithRequired(e => e.Employee)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<LeaseContract>()
				.HasMany(e => e.LeaseDetails)
				.WithRequired(e => e.LeaseContract)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<LeaseDetail>()
				.Property(e => e.Amount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ParkingDetail>()
				.Property(e => e.Amount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ParkingTicket>()
				.HasMany(e => e.ParkingDetails)
				.WithRequired(e => e.ParkingTicket)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Priority>()
				.HasMany(e => e.Students)
				.WithMany(e => e.Priorities)
				.Map(m => m.ToTable("PriorityTarget").MapLeftKey("PriorityId").MapRightKey("StudentId"));

			modelBuilder.Entity<Student>()
				.Property(e => e.Phone)
				.HasPrecision(12, 0);
		}
	}
}