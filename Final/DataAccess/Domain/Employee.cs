namespace DataAccess.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public interface IEmployee
	{
		string EmployeeId { get; set; }
		string Name { get; set; }
		string Gender { get; set; }
		DateTime DateOfBirth { get; set; }
		string Ssn { get; set; }
		string Address { get; set; }
		decimal Phone { get; set; }
		string Username { get; set; }
		string Password { get; set; }
		string Position { get; set; }
		ICollection<Attendance> Attendances { get; set; }
		ICollection<LeaseDetail> LeaseDetails { get; set; }
		ICollection<ParkingDetail> ParkingDetails { get; set; }
		ICollection<ServiceBill> ServiceBills { get; set; }
		ICollection<TemporaryAbsence> TemporaryAbsences { get; set; }
		ICollection<ViolationRecord> ViolationRecords { get; set; }
	}

	public partial class Employee : IEmployee
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Employee()
		{
			Attendances = new HashSet<Attendance>();
			LeaseDetails = new HashSet<LeaseDetail>();
			ParkingDetails = new HashSet<ParkingDetail>();
			ServiceBills = new HashSet<ServiceBill>();
			TemporaryAbsences = new HashSet<TemporaryAbsence>();
			ViolationRecords = new HashSet<ViolationRecord>();
			DateOfBirth = new DateTime(2000, 1, 1);
		}

		[StringLength(10)]
		public string EmployeeId { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(20)]
		public string Gender { get; set; }

		public DateTime DateOfBirth { get; set; }

		[StringLength(20)]
		public string Ssn { get; set; }

		[Column(TypeName = "ntext")]
		public string Address { get; set; }

		[Column(TypeName = "numeric")]
		public decimal Phone { get; set; }

		[StringLength(20)]
		public string Username { get; set; }

		[StringLength(20)]
		public string Password { get; set; }

		[StringLength(20)]
		public string Position { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Attendance> Attendances { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<LeaseDetail> LeaseDetails { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ParkingDetail> ParkingDetails { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ServiceBill> ServiceBills { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<TemporaryAbsence> TemporaryAbsences { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ViolationRecord> ViolationRecords { get; set; }
	}
}
