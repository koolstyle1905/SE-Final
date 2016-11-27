namespace DataAccess
{
	using System;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Data.Entity;
	using System.Linq;
	using DataAccess.Domain;

	public partial class DormitoryContext : DbContext
	{
		public DormitoryContext() : base(Connection.ConnectionString)
		{
		}

		public DormitoryContext(string connectionString)  : base(connectionString)
		{
		}

		public virtual DbSet<Attendance> Attendances { get; set; }

		public virtual DbSet<Building> Buildings { get; set; }

		public virtual DbSet<Carer> Carers { get; set; }

		public virtual DbSet<Class> Classes { get; set; }

		public virtual DbSet<Club> Clubs { get; set; }

		public virtual DbSet<DamageClaim> DamageClaims { get; set; }

		public virtual DbSet<Discipline> Disciplines { get; set; }

		public virtual DbSet<Employee> Employees { get; set; }

		public virtual DbSet<Faculty> Faculties { get; set; }

		public virtual DbSet<Floor> Floors { get; set; }

		public virtual DbSet<LateArrivalInfo> LateArrivalInfoes { get; set; }

		public virtual DbSet<LeaseContract> LeaseContracts { get; set; }

		public virtual DbSet<LeaseReceipt> LeaseReceipts { get; set; }

		public virtual DbSet<ParkingReceipt> ParkingReceipts { get; set; }

		public virtual DbSet<ParkingTicket> ParkingTickets { get; set; }

		public virtual DbSet<Priority> Priorities { get; set; }

		public virtual DbSet<Room> Rooms { get; set; }

		public virtual DbSet<ServiceBill> ServiceBills { get; set; }

		public virtual DbSet<Student> Students { get; set; }

		public virtual DbSet<TemporaryAbsence> TemporaryAbsences { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Attendance>()
				.HasMany(e => e.Students)
				.WithMany(e => e.Attendances)
				.Map(m => m.ToTable("AttendanceDetail").MapLeftKey("AttendanceId").MapRightKey("PersonID"));

			modelBuilder.Entity<Carer>()
				.Property(e => e.Phone)
				.HasPrecision(12, 0);

			modelBuilder.Entity<DamageClaim>()
				.Property(e => e.TotalPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Employee>()
				.Property(e => e.Phone)
				.HasPrecision(12, 0);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.Attendances)
				.WithOptional(e => e.Employee)
				.HasForeignKey(e => e.StudentID);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.LeaseReceipts)
				.WithRequired(e => e.Employee)
				.HasForeignKey(e => e.StudentID)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.ParkingReceipts)
				.WithRequired(e => e.Employee)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Employee>()
				.HasMany(e => e.ServiceBills)
				.WithOptional(e => e.Employee)
				.HasForeignKey(e => e.StudentID);

			modelBuilder.Entity<LeaseContract>()
				.HasMany(e => e.LeaseReceipts)
				.WithRequired(e => e.LeaseContract)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<LeaseReceipt>()
				.Property(e => e.TotalPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ParkingReceipt>()
				.Property(e => e.TotalPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<ParkingTicket>()
				.HasMany(e => e.ParkingReceipts)
				.WithRequired(e => e.ParkingTicket)
				.WillCascadeOnDelete(false);

			modelBuilder.Entity<Priority>()
				.HasMany(e => e.Students)
				.WithMany(e => e.Priorities)
				.Map(m => m.ToTable("PriorityTarget").MapLeftKey("PriorityID").MapRightKey("StudentID"));

			modelBuilder.Entity<ServiceBill>()
				.Property(e => e.TotalPrice)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Student>()
				.Property(e => e.Phone)
				.HasPrecision(12, 0);
		}
	}
}
