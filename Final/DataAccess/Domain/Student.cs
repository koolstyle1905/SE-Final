using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace DataAccess.Domain
{
	public class Student
	{
		[SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public Student()
		{
			Carers = new HashSet<Carer>();
			LateArrivalInfoes = new HashSet<LateArrivalInfo>();
			LeaseContracts = new HashSet<LeaseContract>();
			ParkingTickets = new HashSet<ParkingTicket>();
			TemporaryAbsences = new HashSet<TemporaryAbsence>();
			ViolationRecords = new HashSet<ViolationRecord>();
			ReportAbsences = new HashSet<ReportAbsence>();
			Priorities = new HashSet<Priority>();
			DateOfBirth = new DateTime(2000, 1, 1);
			Course = 2016;
		}

		[StringLength(10)]
		public string StudentId { get; set; }

		[StringLength(10)]
		public string ClubId { get; set; }

		[StringLength(10)]
		public string ClassId { get; set; }

		[StringLength(10)]
		public string RoomId { get; set; }

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

		[StringLength(200)]
		public string PlaceOfBirth { get; set; }

		[StringLength(50)]
		public string Nation { get; set; }

		[StringLength(50)]
		public string Religion { get; set; }

		public int Course { get; set; }

		[StringLength(20)]
		public string Position { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Carer> Carers { get; set; }

		public virtual Class Class { get; set; }

		public virtual Club Club { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<LateArrivalInfo> LateArrivalInfoes { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<LeaseContract> LeaseContracts { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ParkingTicket> ParkingTickets { get; set; }

		public virtual Room Room { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<TemporaryAbsence> TemporaryAbsences { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ViolationRecord> ViolationRecords { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<ReportAbsence> ReportAbsences { get; set; }

		[SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Priority> Priorities { get; set; }
	}
}