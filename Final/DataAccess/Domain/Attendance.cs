namespace DataAccess.Domain
{
	using System;
	using System.Collections.Generic;
	using System.ComponentModel.DataAnnotations;
	using System.ComponentModel.DataAnnotations.Schema;

	public interface IAttendance
	{
		string AttendanceId { get; set; }
		string EmployeeId { get; set; }
		DateTime CreatedDate { get; set; }
		Employee Employee { get; set; }
		ICollection<Student> Students { get; set; }
	}

	[Table("Attendance")]
    public partial class Attendance : IAttendance
	{
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attendance()
        {
            Students = new HashSet<Student>();
			CreatedDate = DateTime.Now;
		}

        [StringLength(10)]
        public string AttendanceId { get; set; }

        [StringLength(10)]
        public string EmployeeId { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual Employee Employee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
