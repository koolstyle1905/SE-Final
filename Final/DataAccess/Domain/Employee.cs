using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class Employee
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Employee()
		{
			ReportAbsences = new HashSet<ReportAbsence>();
			LeaseDetails = new HashSet<LeaseDetail>();
			ParkingDetails = new HashSet<ParkingDetail>();
			TemporaryAbsences = new HashSet<TemporaryAbsence>();
			ViolationRecords = new HashSet<ViolationRecord>();
		}

		[StringLength(10)]
		public string EmployeeId { get; set; }

		[StringLength(50)]
		public string Name { get; set; }

		[StringLength(20)]
		public string Gender { get; set; }

		public DateTime DateOfBirth { get; set; }

		[StringLength(20)]
		public string SSN { get; set; }

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

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ReportAbsence> ReportAbsences { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<LeaseDetail> LeaseDetails { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ParkingDetail> ParkingDetails { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<TemporaryAbsence> TemporaryAbsences { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ViolationRecord> ViolationRecords { get; set; }
	}
}