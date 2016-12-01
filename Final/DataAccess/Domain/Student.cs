namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

	public interface IStudent
	{
		string StudentId { get; set; }
		string ClubId { get; set; }
		string ClassId { get; set; }
		string RoomId { get; set; }
		string Name { get; set; }
		string Gender { get; set; }
		DateTime DateOfBirth { get; set; }
		string Ssn { get; set; }
		string Address { get; set; }
		decimal Phone { get; set; }
		string PlaceOfBirth { get; set; }
		string Nation { get; set; }
		string Religion { get; set; }
		int Course { get; set; }
		string Position { get; set; }
		ICollection<Carer> Carers { get; set; }
		Class Class { get; set; }
		Club Club { get; set; }
		ICollection<LateArrivalInfo> LateArrivalInfoes { get; set; }
		ICollection<LeaseContract> LeaseContracts { get; set; }
		ICollection<ParkingTicket> ParkingTickets { get; set; }
		Room Room { get; set; }
		ICollection<TemporaryAbsence> TemporaryAbsences { get; set; }
		ICollection<ViolationRecord> ViolationRecords { get; set; }
		ICollection<Attendance> Attendances { get; set; }
		ICollection<Priority> Priorities { get; set; }
	}

	public partial class Student : IStudent
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {Carers = new HashSet<Carer>();
            LateArrivalInfoes = new HashSet<LateArrivalInfo>();
            LeaseContracts = new HashSet<LeaseContract>();
            ParkingTickets = new HashSet<ParkingTicket>();
            TemporaryAbsences = new HashSet<TemporaryAbsence>();
            ViolationRecords = new HashSet<ViolationRecord>();
            Attendances = new HashSet<Attendance>();
            Priorities = new HashSet<Priority>();
			DateOfBirth = new DateTime(2000, 1, 1);
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
        public string Ssn { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carer> Carers { get; set; }

        public virtual Class Class { get; set; }

        public virtual Club Club { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LateArrivalInfo> LateArrivalInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaseContract> LeaseContracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParkingTicket> ParkingTickets { get; set; }

        public virtual Room Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemporaryAbsence> TemporaryAbsences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ViolationRecord> ViolationRecords { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Priority> Priorities { get; set; }
    }
}
