namespace DataAccess
{
	using System;
	using System.Data.Entity;
	using System.ComponentModel.DataAnnotations.Schema;
	using System.Linq;
	using Domain;

	public interface IDormitoryContext
	{
		IDbSet<Attendance> Attendances { get; set; }
		IDbSet<Building> Buildings { get; set; }
		IDbSet<Carer> Carers { get; set; }
		IDbSet<Class> Classes { get; set; }
		IDbSet<Club> Clubs { get; set; }
		IDbSet<Employee> Employees { get; set; }
		IDbSet<Faculty> Faculties { get; set; }
		IDbSet<Floor> Floors { get; set; }
		IDbSet<LateArrivalInfo> LateArrivalInfoes { get; set; }
		IDbSet<LeaseContract> LeaseContracts { get; set; }
		IDbSet<LeaseDetail> LeaseDetails { get; set; }
		IDbSet<ParkingDetail> ParkingDetails { get; set; }
		IDbSet<ParkingTicket> ParkingTickets { get; set; }
		IDbSet<Priority> Priorities { get; set; }
		IDbSet<Room> Rooms { get; set; }
		IDbSet<ServiceBill> ServiceBills { get; set; }
		IDbSet<Student> Students { get; set; }
		IDbSet<TemporaryAbsence> TemporaryAbsences { get; set; }
		IDbSet<ViolationRecord> ViolationRecords { get; set; }
		void SetModified(object entity);
		int SaveChanges();
	}

	public partial class DormitoryContext : DbContext, IDormitoryContext
	{
		public DormitoryContext() : base(Connection.ConnectionString)
		{
		}

		public DormitoryContext(string connectionString) : base(connectionString)
		{
		}

		public virtual IDbSet<Attendance> Attendances { get; set; }

		public virtual IDbSet<Building> Buildings { get; set; }

		public virtual IDbSet<Carer> Carers { get; set; }

		public virtual IDbSet<Class> Classes { get; set; }

		public virtual IDbSet<Club> Clubs { get; set; }

		public virtual IDbSet<Employee> Employees { get; set; }

		public virtual IDbSet<Faculty> Faculties { get; set; }

		public virtual IDbSet<Floor> Floors { get; set; }

		public virtual IDbSet<LateArrivalInfo> LateArrivalInfoes { get; set; }

		public virtual IDbSet<LeaseContract> LeaseContracts { get; set; }

		public virtual IDbSet<LeaseDetail> LeaseDetails { get; set; }

		public virtual IDbSet<ParkingDetail> ParkingDetails { get; set; }

		public virtual IDbSet<ParkingTicket> ParkingTickets { get; set; }

		public virtual IDbSet<Priority> Priorities { get; set; }

		public virtual IDbSet<Room> Rooms { get; set; }

		public virtual IDbSet<ServiceBill> ServiceBills { get; set; }

		public virtual IDbSet<Student> Students { get; set; }

		public virtual IDbSet<TemporaryAbsence> TemporaryAbsences { get; set; }

		public virtual IDbSet<ViolationRecord> ViolationRecords { get; set; }

		public void SetModified(object entity)
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

			modelBuilder.Entity<ServiceBill>()
				.Property(e => e.Amount)
				.HasPrecision(19, 4);

			modelBuilder.Entity<Student>()
				.Property(e => e.Phone)
				.HasPrecision(12, 0);
		}
	}
}
