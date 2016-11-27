namespace DataAccess.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

	public enum Gender
	{
		Male,
		Female
	}

    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Carers = new HashSet<Carer>();
			this.DamageClaims = new HashSet<DamageClaim>();
			this.Disciplines = new HashSet<Discipline>();
			this.LateArrivalInfoes = new HashSet<LateArrivalInfo>();
			this.LeaseContracts = new HashSet<LeaseContract>();
			this.ParkingTickets = new HashSet<ParkingTicket>();
			this.TemporaryAbsences = new HashSet<TemporaryAbsence>();
			this.Attendances = new HashSet<Attendance>();
			this.Priorities = new HashSet<Priority>();
			this.DateOfBirth = new DateTime(2000, 1, 1);
        }

        public string StudentID { get; set; }

        public string ClubID { get; set; }

        public string ClassID { get; set; }

        public string RoomID { get; set; }

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

        [StringLength(20)]
        public string Position { get; set; }

        public int Course { get; set; }

        public virtual Class Class { get; set; }

        public virtual Club Club { get; set; }

        public virtual Room Room { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carer> Carers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DamageClaim> DamageClaims { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Discipline> Disciplines { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LateArrivalInfo> LateArrivalInfoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaseContract> LeaseContracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParkingTicket> ParkingTickets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TemporaryAbsence> TemporaryAbsences { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attendance> Attendances { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Priority> Priorities { get; set; }
    }
}
